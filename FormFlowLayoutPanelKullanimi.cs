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
    public partial class FormFlowLayoutPanelKullanimi : Form
    {
        public FormFlowLayoutPanelKullanimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int butonSayisi = int.Parse(txtButonSayisi.Text);
            flpPanel.Controls.Clear();
            for (int i = 0; i < butonSayisi; i++)
            {
                Button btn = new Button();
                btn.Top = 0;
                btn.Left = 0;

                btn.Width = 50;
                btn.Height = 50;
                btn.Name = "btnOtomatikEklenenButon" + (i + 1);
                btn.Text = "";
                btn.Click += Btn_Click;
                flpPanel.Controls.Add(btn);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Name);
        }
    }
}
