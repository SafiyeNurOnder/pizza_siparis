using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SiparisAl_Click(object sender, EventArgs e)
        {
            // ücret ve extra değişkenlerini tanımlayacağız
            decimal ucret = 0;
            string extra = "";

            if (checkBox_Sucuk.Checked == true)
            {
                extra += "Sucuk";
                ucret = 1;
            }
            else if (checkBox_Sosis.Checked == true)
            {
                extra += "" + "Sosis";
                ucret = 1;
            }
            else if (checkBox_Zeytin.Checked == true)
            {
                extra += "" + "Zeytin";
                ucret = 1;
            }
            else if (checkBox_Mantar.Checked == true)
            {
                extra += "" + "Mantar";
                ucret = 1;
            }
            else if (checkBox_Peynir.Checked == true)
            {
                extra += "" + "Peynir";
                ucret = 1;
            }
            else if (checkBox_Et.Checked == true)
            {
                extra += "" + "Et";
                ucret = 1;
            }

            //pizzalar listesi
            if(cmbBox_PizzaBoy.Text == "Küçük")
            {
                ucret += numericUpDown_PAdet.Value * 15;
            }
            else if (cmbBox_PizzaBoy.Text == "Orta")
            {
                ucret += numericUpDown_PAdet.Value * 20;
            }
            else if (cmbBox_PizzaBoy.Text == "Büyük")
            {
                ucret += numericUpDown_PAdet.Value * 25;
            }

            //içecekler listesi
            if (cmbBox_Icecek.Text == "2.5 lt Coca Cola")
            {
                ucret += numericUpDown_IAdet.Value * 5;
            }
            else if (cmbBox_Icecek.Text == "1 lt Fanta")
            {
                ucret += numericUpDown_IAdet.Value * 3;
            }
            else if (cmbBox_Icecek.Text == "1 lt Sprite")
            {
                ucret += numericUpDown_IAdet.Value * 3;
            }

            listeAdSoyad.Items.Add(txtBox_AdSoyad.Text);
            listeTelefon.Items.Add(txtBox_Telefon.Text);
            listeAdres.Items.Add(txtBox_Adres.Text);
            listePizzaBoyAdet.Items.Add("Adet:" + numericUpDown_PAdet.Value + "Boy" + cmbBox_PizzaBoy.Text);
            listeExtra.Items.Add(extra);
            listeIcecekAdet.Items.Add("Adet:" + numericUpDown_IAdet.Value + "Boy" + cmbBox_Icecek.Text);
            listeUcret.Items.Add(ucret + "TL");

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            // textboxları temizledik
            txtBox_AdSoyad.Text = "";
            txtBox_Telefon.Text = null;
            txtBox_Adres.Clear();
            
            // comboboxları temizledik
            cmbBox_Icecek.Text = "";
            cmbBox_PizzaBoy.Text = "";

            numericUpDown_PAdet.Value = 0;
            numericUpDown_IAdet.Value = 0;

            // checkboxları temizledik
            checkBox_Sucuk.Checked = false;
            checkBox_Sosis.Checked = false;
            checkBox_Zeytin.Checked = false;
            checkBox_Mantar.Checked = false;
            checkBox_Peynir.Checked = false;
            checkBox_Et.Checked = false;
        }

        private void btn_SiparisleriTemizle_Click(object sender, EventArgs e)
        {
            txtBox_AdSoyad.Text = "";
            txtBox_Telefon.Text = null;
            txtBox_Adres.Clear();

            cmbBox_Icecek.Text = "";
            cmbBox_PizzaBoy.Text = "";

            numericUpDown_PAdet.Value = 0;
            numericUpDown_IAdet.Value = 0;

            checkBox_Sucuk.Checked = false;
            checkBox_Sosis.Checked = false;
            checkBox_Zeytin.Checked = false;
            checkBox_Mantar.Checked = false;
            checkBox_Peynir.Checked = false;
            checkBox_Et.Checked = false;

            listeAdSoyad.Items.Clear();
            listeTelefon.Items.Clear();
            listeAdres.Items.Clear();
            listePizzaBoyAdet.Items.Clear();
            listeExtra.Items.Clear();
            listeIcecekAdet.Items.Clear();
            listeUcret.Items.Clear();
        }


    }
}
