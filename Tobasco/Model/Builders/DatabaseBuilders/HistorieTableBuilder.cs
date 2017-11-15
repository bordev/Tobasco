﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobasco.Constants;
using Tobasco.Properties;
using Tobasco.Templates;

namespace Tobasco.Model.Builders.DatabaseBuilders
{
    public class HistorieTableBuilder : TableHelper
    {
        public HistorieTableBuilder(Entity entity, Database database) : base(entity, database)
        {
        }

        public string Build()
        {
            var template = new Template();
            template.SetTemplate(Entity.GenerateReadonlyGuid ? GetTemplateUid : GetTemplate);
            template.Fill(GetParameters());
            return template.GetText;
        }

        protected virtual string GetTemplate => SqlResources.SqlHistorieTable;
        protected virtual string GetTemplateUid => SqlResources.SqlHistorieTableWithUid;
    }
}
