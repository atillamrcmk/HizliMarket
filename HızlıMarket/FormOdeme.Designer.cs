namespace HızlıMarket
{
    partial class FormOdeme
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
            labelParaUstu = new Label();
            btnOdemeYap = new Button();
            textBoxOdeme = new TextBox();
            label1 = new Label();
            labelToplamTutar = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelParaUstu);
            panel1.Controls.Add(btnOdemeYap);
            panel1.Controls.Add(textBoxOdeme);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelToplamTutar);
            panel1.Location = new Point(267, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 400);
            panel1.TabIndex = 0;
            // 
            // labelParaUstu
            // 
            labelParaUstu.BackColor = Color.Yellow;
            labelParaUstu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelParaUstu.Location = new Point(225, 234);
            labelParaUstu.Name = "labelParaUstu";
            labelParaUstu.Size = new Size(276, 66);
            labelParaUstu.TabIndex = 4;
            labelParaUstu.Text = "Para Üstü: ₺...";
            labelParaUstu.TextAlign = ContentAlignment.MiddleCenter;
            labelParaUstu.Click += labelParaUstu_Click;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.BackColor = Color.Lime;
            btnOdemeYap.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdemeYap.Location = new Point(192, 320);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(347, 77);
            btnOdemeYap.TabIndex = 3;
            btnOdemeYap.Text = "ÖDEMEYİ TAMAMLA";
            btnOdemeYap.UseVisualStyleBackColor = false;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // textBoxOdeme
            // 
            textBoxOdeme.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxOdeme.Location = new Point(432, 133);
            textBoxOdeme.Name = "textBoxOdeme";
            textBoxOdeme.Size = new Size(217, 54);
            textBoxOdeme.TabIndex = 2;
            textBoxOdeme.TextChanged += textBoxOdeme_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 134);
            label1.Name = "label1";
            label1.Size = new Size(371, 53);
            label1.TabIndex = 1;
            label1.Text = "KULLANICI NE KADAR VERDİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelToplamTutar
            // 
            labelToplamTutar.BackColor = Color.Yellow;
            labelToplamTutar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelToplamTutar.Location = new Point(202, 23);
            labelToplamTutar.Name = "labelToplamTutar";
            labelToplamTutar.Size = new Size(313, 89);
            labelToplamTutar.TabIndex = 0;
            labelToplamTutar.Text = "Toplam Tutar: ₺0.00";
            labelToplamTutar.TextAlign = ContentAlignment.MiddleCenter;
            labelToplamTutar.Click += labelToplamTutar_Click;
            // 
            // FormOdeme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 685);
            Controls.Add(panel1);
            Name = "FormOdeme";
            Text = "FormOdeme";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label labelToplamTutar;
        private Label labelParaUstu;
        private Button btnOdemeYap;
        private TextBox textBoxOdeme;
    }
}