﻿using System;
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
    public partial class Firmalar : Form
    {
        public Firmalar()
        {
            InitializeComponent();
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Firma' table. You can move, or remove it, as needed.
            this.firmaTableAdapter.Fill(this.testDataSet.Firma);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
