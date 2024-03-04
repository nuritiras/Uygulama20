using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBagla_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 1453;
            ogrenci.AdSoyad = "Fatih Sultan  Mehmet";
            ogrenci.Alan = "Bilişim Teknolojileri";
            textNumara.DataBindings.Add("Text", ogrenci, "Numara");
            textAdSoyad.DataBindings.Add("Text", ogrenci, "AdSoyad");
            textAlan.DataBindings.Add("Text", ogrenci, "Alan");
        }
    }
}
