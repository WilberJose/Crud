using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    class Compra
    {
        public int _compraId { get; set; }

        public int _precio { get; set; }

        public int _cantidad { get; set; }

        public int _fechacompra { get; set; }
        public static string precio { get; internal set; }

        private Crud crud = new Crud();
        internal static int cantidad;

        public MySqlDataReader getCompra()
        {
            string query = "SELECT compraid,precio,cantidad,fechacompra" + "FROM compra";

            return crud.select(query);
        }
        public Boolean newEditCompra(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INFO compra(precio, cantidad, fechacompra) VALUES" +
                    "('" + _precio + "','" + _cantidad + "','" + _fechacompra + "')";
                crud.executeQuery(query);
                return true;
            }
            return false;
        }

        internal static void getAll(DataGridView dtgRegistro)
        {
            
        }

        internal static void insert()
        {
           
        }

        internal static void update()
        {
            
        }

        internal static void delete()
        {
            
        }
    }
}



