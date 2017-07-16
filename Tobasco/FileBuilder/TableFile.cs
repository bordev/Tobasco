﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobasco.Enums;

namespace Tobasco.FileBuilder
{
    public class TableFile : OutputFile
    {
        public override FileType Type => FileType.Table;

        public string Table { get; set; }

        public string HistorieTable { get; set; }

        public string Indexes { get; set; }

        public string Triggers { get; set; }

        public override string BuildContent()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Table);
            builder.AppendLine("GO");
            builder.AppendLine(HistorieTable);
            builder.AppendLine("GO");
            builder.AppendLine(Indexes);
            builder.AppendLine("GO");
            builder.AppendLine(Triggers);
            return builder.ToString();
        }
    }
}
