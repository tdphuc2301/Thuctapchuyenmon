﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLMatket
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Desktop\Market\QLMatket\QLMatket\CSDL_Market.mdf;Integrated Security=True;Connect Timeout=30");

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenCon()
        {
            if(connection.State== System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open) ;
            {
                connection.Close();
            }
        }
    }
}
