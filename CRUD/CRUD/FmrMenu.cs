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
    public partial class FmrMenu : Form
    {
        public FmrMenu()
        {
            InitializeComponent();
        }

        private void FmrMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FmrText fmr = new FmrText();
            //definir formulario padre
            fmr.MdiParent = this;
            fmr.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fmr = new Form1();
            fmr.MdiParent = this;
            fmr.Show();
        }
    }
}
