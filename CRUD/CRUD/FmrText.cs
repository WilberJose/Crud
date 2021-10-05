using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class FmrText : Form
    {
        public FmrText()
        {
            InitializeComponent();
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            //prueba de conexion a base de datos 
            string connectionString = "";
            MySqlConnection conn;

            try
            {
                connectionString = @"Server=localhost;Database=smis058221;Uid=root;pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, "Se establecio la conexion",
                    "Conexion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
