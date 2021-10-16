using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test frm = new Test();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actores frm = new Actores();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
