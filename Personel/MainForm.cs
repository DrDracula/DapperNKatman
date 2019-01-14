using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void marsSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarsForm mars = new MarsForm();
            mars.MdiParent = this;
            mars.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void cıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void personelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 personel = new Form1();
            personel.MdiParent = this;
            personel.Show();
        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Firmalar f = new Firmalar();
            f.MdiParent = this;
            f.Show();
        }
    }
}
