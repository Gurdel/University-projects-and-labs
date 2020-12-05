using System;
using System.Collections.Generic;

namespace itLab4_5MVC_MSSQL
{
    public partial class Row
    {
        public Row()
        {
            Data = new HashSet<Data>();
        }

        public int Id { get; set; }
        public int TableId { get; set; }

        public virtual Table Table { get; set; }
        public virtual ICollection<Data> Data { get; set; }
    }
}
