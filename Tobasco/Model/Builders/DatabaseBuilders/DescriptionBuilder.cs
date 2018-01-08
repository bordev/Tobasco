﻿using System.Collections.Generic;
using System.Linq;
using Tobasco.Constants;
using Tobasco.Manager;
using Tobasco.Properties;
using Tobasco.Templates;

namespace Tobasco.Model.Builders.DatabaseBuilders
{
    public class DescriptionBuilder : DatabaseHelper
    {
        public DescriptionBuilder(Entity entity, Database database, EntityInformation information) : base(entity, database, information)
        {
        }

        public virtual string GetTemplateTableDescription => SqlResources.DescriptionTable;

        public string Build()
        {
            var template = new Template();
            template.SetTemplate(GetTemplateTableDescription);
            template.Fill(GetParameters());
            return template.GetText;
        }

        private TemplateParameter GetParameters()
        {
            var parameters = new TemplateParameter();
            parameters.Add(SqlConstants.TableName, Name);
            parameters.Add(SqlConstants.Description, string.IsNullOrEmpty(Entity.Description) ? Name : Entity.Description);
            parameters.Add(SqlConstants.DescriptionColumns, GetColumnDescriptions());
            return parameters;
        }

        private List<string> GetColumnDescriptions()
        {
            var columnDescriptions = new List<string>();
            foreach(var prop in Entity.GetSqlProperties.Where(x => x.Property.DataType.Datatype != Enums.Datatype.ChildCollection))
            {
                OutputPaneManager.WriteToOutputPane($"{MainInformation.Description.Required}");
                if (MainInformation.Description.Required || !string.IsNullOrEmpty(prop.Property.Description) || prop.Property.DataType.Datatype == Enums.Datatype.Enum)
                {
                    var builder = new DescriptionColumnBuilder(prop, Entity, MainInformation);
                    columnDescriptions.Add(builder.Build());
                }
            }
            return columnDescriptions;
        }
    }
}
