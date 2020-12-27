﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace FootballFieldManagement.DAL
{
    public class SQLConnection
    {
        private string strConn;
        public SqlConnection conn;
        public SQLConnection()
        {
            try
            {
                strConn = ConfigurationManager.ConnectionStrings["FFM"].ConnectionString;
            }
            catch
            {
                CustomMessageBox.Show("Mất kết nối đến cơ sở dữ liệu!", "Thông báo");
                return;
            }
            conn = new SqlConnection(strConn);
        }
    }
}
