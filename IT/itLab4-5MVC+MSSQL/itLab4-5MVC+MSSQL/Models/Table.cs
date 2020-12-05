using System;
using System.Collections.Generic;

namespace itLab4_5MVC_MSSQL
{
    public partial class Table
    {
        public Table()
        {
            Column = new HashSet<Column>();
            Row = new HashSet<Row>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DbId { get; set; }

        public virtual DataBase Db { get; set; }
        public virtual ICollection<Column> Column { get; set; }
        public virtual ICollection<Row> Row { get; set; }
    }
}
