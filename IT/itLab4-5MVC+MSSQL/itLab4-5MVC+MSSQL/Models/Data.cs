using System;
using System.Collections.Generic;

namespace itLab4_5MVC_MSSQL
{
    public partial class Data
    {
        public int Id { get; set; }
        public string Data1 { get; set; }
        public int RowId { get; set; }
        public int ColumnId { get; set; }

        public virtual Column Column { get; set; }
        public virtual Row Row { get; set; }
    }
}
