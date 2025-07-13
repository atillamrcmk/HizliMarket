namespace HızlıMarket
{
    partial class FormUrunEkle
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
            buttonKaydet = new Button();
            textBoxSatis = new TextBox();
            label5 = new Label();
            textBoxAlis = new TextBox();
            label4 = new Label();
            textBoxAdet = new TextBox();
            label3 = new Label();
            textBoxBarkod = new TextBox();
            label2 = new Label();
            textBoxUrunAdi = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonKaydet);
            panel1.Controls.Add(textBoxSatis);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxAlis);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxAdet);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxBarkod);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUrunAdi);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(317, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 502);
            panel1.TabIndex = 0;
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.Lime;
            buttonKaydet.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonKaydet.Location = new Point(245, 425);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(169, 74);
            buttonKaydet.TabIndex = 10;
            buttonKaydet.Text = "KAYDET";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click_1;
            // 
            // textBoxSatis
            // 
            textBoxSatis.Location = new Point(366, 385);
            textBoxSatis.Name = "textBoxSatis";
            textBoxSatis.Size = new Size(161, 23);
            textBoxSatis.TabIndex = 9;
            // 
            // label5
            // 
            label5.BackColor = Color.Yellow;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(22, 358);
            label5.Name = "label5";
            label5.Size = new Size(221, 67);
            label5.TabIndex = 8;
            label5.Text = "ÜRÜN SATIŞ FİYAT";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAlis
            // 
            textBoxAlis.Location = new Point(366, 306);
            textBoxAlis.Name = "textBoxAlis";
            textBoxAlis.Size = new Size(161, 23);
            textBoxAlis.TabIndex = 7;
            // 
            // label4
            // 
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(22, 277);
            label4.Name = "label4";
            label4.Size = new Size(221, 70);
            label4.TabIndex = 6;
            label4.Text = "ÜRÜN ALIŞ FİYAT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxAdet
            // 
            textBoxAdet.Location = new Point(366, 230);
            textBoxAdet.Name = "textBoxAdet";
            textBoxAdet.Size = new Size(161, 23);
            textBoxAdet.TabIndex = 5;
            // 
            // label3
            // 
            label3.BackColor = Color.Yellow;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(22, 203);
            label3.Name = "label3";
            label3.Size = new Size(221, 66);
            label3.TabIndex = 4;
            label3.Text = "ÜRÜN ADEDİ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBarkod
            // 
            textBoxBarkod.Location = new Point(366, 148);
            textBoxBarkod.Name = "textBoxBarkod";
            textBoxBarkod.Size = new Size(161, 23);
            textBoxBarkod.TabIndex = 3;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(22, 118);
            label2.Name = "label2";
            label2.Size = new Size(221, 73);
            label2.TabIndex = 2;
            label2.Text = "ÜRÜN BARKODU";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxUrunAdi
            // 
            textBoxUrunAdi.Location = new Point(366, 62);
            textBoxUrunAdi.Name = "textBoxUrunAdi";
            textBoxUrunAdi.Size = new Size(161, 23);
            textBoxUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(221, 75);
            label1.TabIndex = 0;
            label1.Text = "ÜRÜN ADI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormUrunEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 661);
            Controls.Add(panel1);
            Name = "FormUrunEkle";
            Text = "FormUrunEkle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonKaydet;
        private TextBox textBoxSatis;
        private Label label5;
        private TextBox textBoxAlis;
        private Label label4;
        private TextBox textBoxAdet;
        private Label label3;
        private TextBox textBoxBarkod;
        private Label label2;
        private TextBox textBoxUrunAdi;
    }
}