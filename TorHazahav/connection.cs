using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorHazahav
{
    class connection
    {
        public static string connectionString = "Data Source=DESKTOP-805B3L5\\SQLEXPRESS;Initial Catalog=TOR_HAZAHAV;Integrated Security=True";
        public static tzDataContext dbDataContext = new tzDataContext(connectionString);
        public static tzDataContext getDataContextInstance()
        {
            return dbDataContext;
        }
    }
}
