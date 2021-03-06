﻿using System;
using System.Collections.Generic;
using System.Linq;
using Tobasco.Constants;
using Tobasco.Properties;
using Tobasco.Templates;

namespace Tobasco.Model.Builders.DatabaseBuilders
{
    public class MergeBuilder : DatabaseHelper
    {
        public MergeBuilder(Entity entity, Database database) : base(entity, database)
        {

        }

        public string Build()
        {
            var template = new Template();
            template.SetTemplate(SqlResources.SqlMergeStp);
            template.Fill(GetParameters());

            return template.GetText;
        }

        private TemplateParameter GetParameters()
        {
            var parameters = new TemplateParameter();
            parameters.Add(SqlConstants.TableName, Entity.Name);
            parameters.Add(SqlConstants.TableProperties, string.Join(Environment.NewLine, GetTableProperties()));
            parameters.Add(SqlConstants.StpPropertyNames, string.Join("," +Environment.NewLine, GetSqlParameterNames()));
            parameters.Add(SqlConstants.StpMergeSourcePropertyNames, string.Join("," + Environment.NewLine, GetMergeInsertParameters()));
            parameters.Add(SqlConstants.StpMergeOutputAction, string.Join(Environment.NewLine, GetMergeOuputActions()));
            parameters.Add(SqlConstants.UpdateSetTableParemeters, string.Join(Environment.NewLine, GetSqlUpdateParameters()));
            parameters.Add(SqlConstants.MergeOutputParameters, GetMergeOutputParameters());
            return parameters;
        }

        private List<string> GetMergeOuputActions()
        {
            var sqlParameters = GetNonChildCollectionProperties;

            return sqlParameters.Select(x => $",IIF($action = 'DELETE', deleted.{x.SelectSqlParameterNaam}, inserted.{x.SelectSqlParameterNaam})").ToList();
        }

        private List<string> GetMergeInsertParameters()
        {
            var sqlparams = GetSqlParameterNames();

            return sqlparams.Select(x => $"[Source].{x}").ToList();
        }

        private List<string> GetMergeOutputParameters()
        {
            var sqlParams = GetSqlParameterNames();

            return sqlParams.Select(x => $"#output.{x}").ToList();
        }

        public override List<string> GetSqlUpdateParameters()
        {
            var list = new List<string>();

            foreach (var selectSqlProperty in GetNonChildCollectionProperties)
            {
                list.Add($"{selectSqlProperty.SelectSqlParameterNaam} = [Source].{selectSqlProperty.SelectSqlParameterNaam},");
            }

            return list;
        }
    }
}
