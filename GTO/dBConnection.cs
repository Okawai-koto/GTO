using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO
{
    class dBConnection
    {
        static public MySqlConnection dBConnect()
        {
            MySqlConnection db = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=gto");
            try
            {
                db.Open();
            }
            catch (Exception)
            {
                return null;
            }
            db.Close();
            return db;
        }
    }
}
