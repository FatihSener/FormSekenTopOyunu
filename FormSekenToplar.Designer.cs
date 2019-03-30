namespace _06_DinamikKontrolOlusturma
{
    partial class FormSekenToplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlAlan = new System.Windows.Forms.Panel();
            this.txtTopSayisi = new System.Windows.Forms.TextBox();
            this.lblTopSayisi = new System.Windows.Forms.Label();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.tmrHareket = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlAlan
            // 
            this.pnlAlan.BackColor = System.Drawing.Color.White;
            this.pnlAlan.Location = new System.Drawing.Point(13, 45);
            this.pnlAlan.Name = "pnlAlan";
            this.pnlAlan.Size = new System.Drawing.Size(775, 393);
            this.pnlAlan.TabIndex = 0;
            // 
            // txtTopSayisi
            // 
            this.txtTopSayisi.Location = new System.Drawing.Point(84, 10);
            this.txtTopSayisi.MaxLength = 2;
            this.txtTopSayisi.Name = "txtTopSayisi";
            this.txtTopSayisi.Size = new System.Drawing.Size(156, 20);
            this.txtTopSayisi.TabIndex = 1;
            this.txtTopSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTopSayisi_KeyPress);
            // 
            // lblTopSayisi
            // 
            this.lblTopSayisi.AutoSize = true;
            this.lblTopSayisi.Location = new System.Drawing.Point(13, 13);
            this.lblTopSayisi.Name = "lblTopSayisi";
            this.lblTopSayisi.Size = new System.Drawing.Size(56, 13);
            this.lblTopSayisi.TabIndex = 2;
            this.lblTopSayisi.Text = "Top Sayisi";
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(269, 8);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // tmrHareket
            // 
            this.tmrHareket.Interval = 10;
            this.tmrHareket.Tick += new System.EventHandler(this.tmrHareket_Tick);
            // 
            // FormSekenToplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.lblTopSayisi);
            this.Controls.Add(this.txtTopSayisi);
            this.Controls.Add(this.pnlAlan);
            this.Name = "FormSekenToplar";
            this.Text = "Seken Toplar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlan;
        private System.Windows.Forms.TextBox txtTopSayisi;
        private System.Windows.Forms.Label lblTopSayisi;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Timer tmrHareket;
    }
}

