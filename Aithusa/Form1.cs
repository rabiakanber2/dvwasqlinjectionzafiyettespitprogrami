﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aithusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKullanici.Text =="" || TxtParola.Text =="")
            {
                MessageBox.Show("Kullanıcı adı ve / veya parola boş bırakılamaz.", "Uyarı");
            }
           else
            {
                if (TxtKullanici.Text == "rabia" && TxtParola.Text == "456789")
                {
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya parola yanlış", "Uyarı");
                }
            }
        }
    }
}