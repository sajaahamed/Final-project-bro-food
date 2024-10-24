using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bro_Hot_Food_And_Beverage
{
   public class DbCon
    {
        public MySqlConnection connectDB()
        {
            string ConnectionString = @"server=127.0.0.1;userid=root; Password=Saja1234##;Database=bro_food";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }

        int kalhara;
        int asedd;
        int kakakaka;

    }
}
