﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_adı_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullanici;
            kullanici=txtKullanici.Text;

            if (kullanici == "Hayri Koçmarlar")
                MessageBox.Show("Kullanıcı kayıtlı");
            else
            {
                MessageBox.Show("Kullanıcı kayıtlı değil");
            }
        }
    }
}
