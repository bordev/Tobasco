﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tobasco.Enums;
using Tobasco.Extensions;
using Tobasco.FileBuilder;
using Tobasco.Manager;
using Tobasco.Model.Builders.Base;

namespace Tobasco.Model.Builders
{
    public class DefaultRepositoryBuilder : RepositoryBuilderBase
    {

        public DefaultRepositoryBuilder(EntityHandler entity, Repository repository) : base(entity, repository)
        {
        }
        
        protected virtual StringBuilder GetTransaction(StringBuilder builder, Func<StringBuilder, int, StringBuilder> implementation)
        {
            var tabs = 3;
            var trans = Repository.Transaction;
            if (trans != null && trans.UseTransaction)
            {
                builder.AppendLineWithTabs("using (var ts = new TransactionScope())", tabs);
                builder.AppendLineWithTabs("{", tabs);
                implementation(builder, tabs + 1);
                builder.AppendLineWithTabs("    ts.Complete();", tabs);
                builder.AppendLineWithTabs("}", tabs);
            }
            return implementation(builder, tabs);
        }
        
        protected virtual string GetSaveMethod()
        {
            var builder = new StringBuilder();
            builder.AppendLineWithTabs($"public {GetEntityName} Save({GetEntityName} {GetEntityName.ToLower()})", 0);
            builder.AppendLineWithTabs("{", 2);
            GetTransaction(builder, GetSaveImplementation);
            builder.AppendLineWithTabs($"return {GetEntityName.ToLower()};", 3);
            builder.AppendLineWithTabs("}", 2);
            return builder.ToString();
        }

        protected virtual string GetByIdMethod()
        {
            var builder = new StringBuilder();
            builder.AppendLineWithTabs($"public {GetEntityName} GetById(long id)", 0);
            builder.AppendLineWithTabs("{", 2);
            builder.AppendLineWithTabs("return _genericRepository.GetById(id);", 3);
            builder.AppendLineWithTabs("}", 2);
            return builder.ToString();
        }

        protected virtual ClassFile GetClassFile()
        {
            var classFile = FileManager.StartNewClassFile(GetRepositoryName, Repository.FileLocation.Project, Repository.FileLocation.Folder);
            classFile.Namespaces.AddRange(GetRepositoryNamespaces);
            classFile.Namespaces.Add(Repository.InterfaceLocation.GetProjectLocation);
            classFile.Namespaces.Add("System.Collections.Generic");
            classFile.OwnNamespace = Repository.FileLocation.GetNamespace;
            classFile.Constructor.ParameterWithField.AddRange(GetFieldWithParameters());
            classFile.BaseClass = $": {GetRepositoryInterfaceName}";
            classFile.Methods.Add(GetSaveMethod());
            classFile.Methods.Add(GetByIdMethod());
            return classFile;
        }

        protected virtual InterfaceFile GetInterfaceFile()
        {
            var interfaceFile = FileManager.StartNewInterfaceFile(GetRepositoryInterfaceName, Repository.InterfaceLocation.Project, Repository.InterfaceLocation.Folder);
            interfaceFile.Namespaces.Add(Repository.InterfaceLocation.GetProjectLocation);
            interfaceFile.Namespaces.AddRange(GetRepositoryNamespaces);
            interfaceFile.OwnNamespace = Repository.InterfaceLocation.GetNamespace;
            interfaceFile.Methods.Add($"{GetEntityName} Save({GetEntityName} {GetEntityName.ToLower()});");
            interfaceFile.Methods.Add($"{GetEntityName} GetById(long id);");
            return interfaceFile;
        }

        public override IEnumerable<FileBuilder.OutputFile> Build()
        {
            OutputPaneManager.WriteToOutputPane($"Build {GetRepositoryName} for {Entity.GetRepository.FileLocation.GetProjectLocation}");
            var classFile = GetClassFile();

            OutputPaneManager.WriteToOutputPane($"Build {GetRepositoryInterfaceName} for {Entity.GetRepository.InterfaceLocation.GetProjectLocation}");
            var interfaceFile = GetInterfaceFile();

            return new List<FileBuilder.OutputFile> { classFile, interfaceFile };
        }

        protected virtual FieldWithParameter GetGenericRepositoryParameter()
        {
            return new FieldWithParameter
            {
                Parameter =
                    new TypeWithName {Name = "genericRepository", Type = $"IGenericRepository<{GetEntityName}>"},
                Field = new TypeWithName {Name = "_genericRepository", Type = $"IGenericRepository<{GetEntityName}>"}
            };
        }

        private IEnumerable<FieldWithParameter> GetFieldWithParameters()
        {
            List<FieldWithParameter> fields = new List<FieldWithParameter> {GetGenericRepositoryParameter()};
            fields.AddRange(Entity.SelectChildRepositoryInterfaces(Entity.Entity.Properties.Where(x => x.DataType.Datatype == Datatype.ChildCollection || x.DataType.Datatype == Datatype.Child))
                    .Select(childRep => new FieldWithParameter
                    {
                        Field = new TypeWithName {Name = $"_{childRep.FirstCharToLower()}", Type = childRep},
                        Parameter = new TypeWithName {Name = childRep.FirstCharToLower(), Type = childRep}
                    }));
            return fields;
        }

        protected virtual StringBuilder GetSaveImplementation(StringBuilder builder, int tabs)
        {
            foreach (var itemToSave in GetChildProperties)
            {
                if (itemToSave.Required)
                {
                    builder.AppendLineWithTabs($"{GetEntityName.ToLower()}.{itemToSave.Name} = _{Entity.GetRepositoryInterface(itemToSave.DataType.Type).FirstCharToLower()}.Save({GetEntityName.ToLower()}.{itemToSave.Name});", tabs);
                }
                else
                {
                    builder.AppendLineWithTabs($"if ({GetEntityName.ToLower()}.{itemToSave.Name} != null)", tabs);
                    builder.AppendLineWithTabs("{", tabs);
                    builder.AppendLineWithTabs($"{GetEntityName.ToLower()}.{itemToSave.Name} = _{Entity.GetRepositoryInterface(itemToSave.DataType.Type).FirstCharToLower()}.Save({GetEntityName.ToLower()}.{itemToSave.Name});", tabs + 1);
                    builder.AppendLineWithTabs("}", tabs);
                }
            }
            builder.AppendLineWithTabs($"{GetEntityName.ToLower()} = _genericRepository.Save({GetEntityName.ToLower()});", tabs);
            foreach (var itemToSave in GetChildCollectionProperties)
            {
                builder.AppendLineWithTabs($"foreach(var toSaveItem in {GetEntityName.ToLower()}.{itemToSave.Name})", tabs);
                builder.AppendLineWithTabs("{", tabs);
                builder.AppendLineWithTabs($"toSaveItem.{Entity.GetChildReferenceProperty(itemToSave.DataType.Type, GetEntityName).Name} = {GetEntityName.ToLower()}.Id;", tabs + 1);
                builder.AppendLineWithTabs($"_{Entity.GetRepositoryInterface(itemToSave.DataType.Type).FirstCharToLower()}.Save(toSaveItem);", tabs + 1);
                builder.AppendLineWithTabs("}", tabs);
            }
            return builder;
        }

    }
}
