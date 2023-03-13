using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDatabase
{
    class myDBConnection
    {
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection(@"Datasource=127.0.0.1;username=root;password=;database=med_schema");
        }
    }
}