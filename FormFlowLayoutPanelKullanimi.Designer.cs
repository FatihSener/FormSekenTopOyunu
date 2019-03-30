namespace _06_DinamikKontrolOlusturma
{
    partial class FormFlowLayoutPanelKullanimi
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
            this.flpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtButonSayisi = new System.Windows.Forms.TextBox();
            this.lblButonSayisi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpPanel
            // 
            this.flpPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPanel.Location = new System.Drawing.Point(30, 77);
            this.flpPanel.Name = "flpPanel";
            this.flpPanel.Size = new System.Drawing.Size(740, 337);
            this.flpPanel.TabIndex = 0;
            // 
            // txtButonSayisi
            // 
            this.txtButonSayisi.Location = new System.Drawing.Point(131, 27);
            this.txtButonSayisi.Name = "txtButonSayisi";
            this.txtButonSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtButonSayisi.TabIndex = 1;
            // 
            // lblButonSayisi
            // 
            this.lblButonSayisi.AutoSize = true;
            this.lblButonSayisi.Location = new System.Drawing.Point(43, 30);
            this.lblButonSayisi.Name = "lblButonSayisi";
            this.lblButonSayisi.Size = new System.Drawing.Size(62, 13);
            this.lblButonSayisi.TabIndex = 2;
            this.lblButonSayisi.Text = "ButonSayisi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(254, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FormFlowLayoutPanelKullanimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblButonSayisi);
            this.Controls.Add(this.txtButonSayisi);
            this.Controls.Add(this.flpPanel);
            this.Name = "FormFlowLayoutPanelKullanimi";
            this.Text = "FormFlowLayoutPanelKullanimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPanel;
        private System.Windows.Forms.TextBox txtButonSayisi;
        private System.Windows.Forms.Label lblButonSayisi;
        private System.Windows.Forms.Button btnEkle;
    }
}