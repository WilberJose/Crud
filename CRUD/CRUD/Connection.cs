using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class Connection
    {
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=smis058221;Uid=root;" +
                "Pwd=usbw;SSL Mode=Node");
        public MySqlCommand command;

        public MySqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
            return conn;
        }

        internal void closeConnection()
        {
            throw new NotImplementedException();
        }
    }
}
