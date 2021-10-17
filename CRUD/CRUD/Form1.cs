using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void dtgRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Compra.getAll(dtgRegistro);
            txtcantidad.Focus();

            txtcantidad.Text = dtgRegistro.CurrentRow.Cells[0].Value.ToString();
            txtprecio.Text = dtgRegistro.CurrentRow.Cells[1].Value.ToString();          

         }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            Compra.precio = txtprecio.Text;
            Compra.insert();
            Compra.getAll(dtgRegistro);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            
            Compra.precio = txtprecio.Text;
            Compra.insert();
            Compra.update();
            clearData();
            Compra.getAll(dtgRegistro);
        }

        private void clearData()
        {
            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            Compra.delete();
            clearData();
            Compra.getAll(dtgRegistro);
        }
    }
 }
            
        
    
