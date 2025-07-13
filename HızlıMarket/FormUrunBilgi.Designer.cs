namespace HızlıMarket
{
    partial class FormUrunBilgi
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
            panel1 = new Panel();
            labelSatis = new Label();
            labelAlis = new Label();
            labelAdet = new Label();
            labelUrunAdi = new Label();
            btnAra = new Button();
            textBoxBarkod = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelSatis);
            panel1.Controls.Add(labelAlis);
            panel1.Controls.Add(labelAdet);
            panel1.Controls.Add(labelUrunAdi);
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(textBoxBarkod);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(201, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 495);
            panel1.TabIndex = 0;
            // 
            // labelSatis
            // 
            labelSatis.BackColor = Color.Yellow;
            labelSatis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelSatis.Location = new Point(153, 441);
            labelSatis.Name = "labelSatis";
            labelSatis.Size = new Size(282, 43);
            labelSatis.TabIndex = 6;
            labelSatis.Text = "SATIŞ FİYATI";
            labelSatis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAlis
            // 
            labelAlis.BackColor = Color.Yellow;
            labelAlis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelAlis.Location = new Point(153, 378);
            labelAlis.Name = "labelAlis";
            labelAlis.Size = new Size(282, 45);
            labelAlis.TabIndex = 5;
            labelAlis.Text = "ALIŞ FİYATI";
            labelAlis.TextAlign = ContentAlignment.MiddleCenter;
            labelAlis.Click += labelAlis_Click;
            // 
            // labelAdet
            // 
            labelAdet.BackColor = Color.Yellow;
            labelAdet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelAdet.Location = new Point(153, 316);
            labelAdet.Name = "labelAdet";
            labelAdet.Size = new Size(282, 46);
            labelAdet.TabIndex = 4;
            labelAdet.Text = "ÜRÜN ADEDİ";
            labelAdet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUrunAdi
            // 
            labelUrunAdi.BackColor = Color.Yellow;
            labelUrunAdi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelUrunAdi.Location = new Point(153, 250);
            labelUrunAdi.Name = "labelUrunAdi";
            labelUrunAdi.Size = new Size(282, 49);
            labelUrunAdi.TabIndex = 3;
            labelUrunAdi.Text = "ÜRÜN ADI";
            labelUrunAdi.TextAlign = ContentAlignment.MiddleCenter;
            labelUrunAdi.Click += labelUrunAdi_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.LimeGreen;
            btnAra.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAra.Location = new Point(181, 148);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(235, 81);
            btnAra.TabIndex = 2;
            btnAra.Text = "ARA";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // textBoxBarkod
            // 
            textBoxBarkod.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBarkod.Location = new Point(295, 47);
            textBoxBarkod.Name = "textBoxBarkod";
            textBoxBarkod.Size = new Size(242, 71);
            textBoxBarkod.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 47);
            label1.Name = "label1";
            label1.Size = new Size(240, 71);
            label1.TabIndex = 0;
            label1.Text = "BARKOD GİRİNİZ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormUrunBilgi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(panel1);
            Name = "FormUrunBilgi";
            Text = "FormUrunBilgi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAra;
        private TextBox textBoxBarkod;
        private Label label1;
        private Label labelSatis;
        private Label labelAlis;
        private Label labelAdet;
        private Label labelUrunAdi;
    }
}