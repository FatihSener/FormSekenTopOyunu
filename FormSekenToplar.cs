using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_DinamikKontrolOlusturma
{
    public partial class FormSekenToplar : Form
    {
        public FormSekenToplar()
        {
            InitializeComponent();
        }
        Random _random = new Random();

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTopSayisi.Text))
            {
                //hata ver
                return;
            }
            int topSayisi = int.Parse(txtTopSayisi.Text);
            pnlAlan.Controls.Clear();
            for (int i = 0; i < topSayisi; i++)
            {
                PictureBox top = new PictureBox();
                top.ImageLocation = Application.StartupPath + @"\..\..\Resources\top.png";
                top.SizeMode = PictureBoxSizeMode.StretchImage;
                top.Width = 50;
                top.Height = 50;

                top.Top = _random.Next(0, pnlAlan.Height - top.Height);
                top.Left = _random.Next(0, pnlAlan.Width - top.Width);
                top.Click += TopZiplat;

                int x = _random.Next(-3,4);
                int y = _random.Next(-3, 4);
                HareketYonu hareketYonu = new HareketYonu(x, y);         
                top.Tag = hareketYonu;

                pnlAlan.Controls.Add(top);
            }

            tmrHareket.Start();
        }

        private void TopZiplat(object sender, EventArgs e)
        {
            PictureBox top = sender as PictureBox;            
            top.Top -= 30;
        }

        private void txtTopSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        struct HareketYonu
        {
            public HareketYonu(int x,int y)
            {
                X = x;
                Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox top in pnlAlan.Controls)
            {
                HareketYonu topHareketYonu = (HareketYonu)top.Tag;
                top.Left += topHareketYonu.X;
                top.Top += topHareketYonu.Y;

                if(top.Bottom>=pnlAlan.Height || top.Top<=0)
                {
                    topHareketYonu.Y *= -1;                    
                }
                else if(top.Right>=pnlAlan.Width || top.Left<=0)
                {
                    topHareketYonu.X *= -1;                  
                }
                top.Tag = topHareketYonu;
            }
        }
    }
}
