using System;
using System.Collections.Generic;

namespace itLab4_5MVC_MSSQL
{
    public partial class DataBase
    {
        public DataBase()
        {
            Table = new HashSet<Table>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Table> Table { get; set; }
    }
}
