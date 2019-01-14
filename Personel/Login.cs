﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace Personel
{
    public partial class Login : Form
    {
        BusinessLogicLayer bl;
        public Login()
        {
            InitializeComponent();
            bl= new BusinessLogicLayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bl.LoginKontrol(txtAd.Text, txtSifre.Text) > 0)
            {
                this.Visible = false;
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Girilen Bilgiler Hatalidir");
            }
        }
    }
}
