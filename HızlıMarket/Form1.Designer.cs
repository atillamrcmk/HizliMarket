namespace HızlıMarket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            sonsatısbtn = new Button();
            label4 = new Label();
            odemeyapbtn = new Button();
            karzararbtn = new Button();
            urunbilgibtn = new Button();
            urunckrbtn = new Button();
            uruneklebtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBoxBarkod = new TextBox();
            label2 = new Label();
            dataGridViewUrunler = new DataGridView();
            contextMenuSepet = new ContextMenuStrip(components);
            menuSepettenCikar = new ToolStripMenuItem();
            panel3 = new Panel();
            label3 = new Label();
            labelToplam = new Label();
            pictureBoxLogo = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).BeginInit();
            contextMenuSepet.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sonsatısbtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(odemeyapbtn);
            panel1.Controls.Add(karzararbtn);
            panel1.Controls.Add(urunbilgibtn);
            panel1.Controls.Add(urunckrbtn);
            panel1.Controls.Add(uruneklebtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 616);
            panel1.TabIndex = 0;
            // 
            // sonsatısbtn
            // 
            sonsatısbtn.BackColor = Color.FromArgb(255, 192, 255);
            sonsatısbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            sonsatısbtn.Location = new Point(3, 463);
            sonsatısbtn.Name = "sonsatısbtn";
            sonsatısbtn.Size = new Size(245, 60);
            sonsatısbtn.TabIndex = 7;
            sonsatısbtn.Text = "SON SATIŞLAR";
            sonsatısbtn.UseVisualStyleBackColor = false;
            sonsatısbtn.Click += sonsatısbtn_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Red;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, -3);
            label4.Name = "label4";
            label4.Size = new Size(242, 82);
            label4.TabIndex = 4;
            label4.Text = "NASİP GIDA";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // odemeyapbtn
            // 
            odemeyapbtn.BackColor = Color.Lime;
            odemeyapbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            odemeyapbtn.Location = new Point(3, 529);
            odemeyapbtn.Name = "odemeyapbtn";
            odemeyapbtn.Size = new Size(245, 84);
            odemeyapbtn.TabIndex = 5;
            odemeyapbtn.Text = "ÖDEME YAP";
            odemeyapbtn.UseVisualStyleBackColor = false;
            odemeyapbtn.Click += odemeyapbtn_Click;
            // 
            // karzararbtn
            // 
            karzararbtn.BackColor = Color.Orange;
            karzararbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            karzararbtn.Location = new Point(3, 397);
            karzararbtn.Name = "karzararbtn";
            karzararbtn.Size = new Size(245, 60);
            karzararbtn.TabIndex = 6;
            karzararbtn.Text = "KAR/ZARAR HESAPLA";
            karzararbtn.UseVisualStyleBackColor = false;
            karzararbtn.Click += karzararbtn_Click;
            // 
            // urunbilgibtn
            // 
            urunbilgibtn.BackColor = Color.LightSalmon;
            urunbilgibtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunbilgibtn.Location = new Point(0, 330);
            urunbilgibtn.Name = "urunbilgibtn";
            urunbilgibtn.Size = new Size(245, 61);
            urunbilgibtn.TabIndex = 4;
            urunbilgibtn.Text = "ÜRÜN BİLGİSİ";
            urunbilgibtn.UseVisualStyleBackColor = false;
            urunbilgibtn.Click += urunbilgibtn_Click;
            // 
            // urunckrbtn
            // 
            urunckrbtn.BackColor = Color.FromArgb(255, 192, 128);
            urunckrbtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunckrbtn.Location = new Point(0, 258);
            urunckrbtn.Name = "urunckrbtn";
            urunckrbtn.Size = new Size(245, 66);
            urunckrbtn.TabIndex = 3;
            urunckrbtn.Text = "ÜRÜN ÇIKAR";
            urunckrbtn.UseVisualStyleBackColor = false;
            urunckrbtn.Click += urunckrbtn_Click;
            // 
            // uruneklebtn
            // 
            uruneklebtn.BackColor = Color.FromArgb(128, 255, 255);
            uruneklebtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uruneklebtn.Location = new Point(0, 171);
            uruneklebtn.Name = "uruneklebtn";
            uruneklebtn.Size = new Size(245, 81);
            uruneklebtn.TabIndex = 2;
            uruneklebtn.Text = "ÜRÜN EKLE";
            uruneklebtn.UseVisualStyleBackColor = false;
            uruneklebtn.Click += uruneklebtn_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 79);
            label1.Name = "label1";
            label1.Size = new Size(245, 89);
            label1.TabIndex = 1;
            label1.Text = "İŞLEMLER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxBarkod);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(378, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 150);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // textBoxBarkod
            // 
            textBoxBarkod.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBoxBarkod.Location = new Point(390, 67);
            textBoxBarkod.Name = "textBoxBarkod";
            textBoxBarkod.Size = new Size(281, 57);
            textBoxBarkod.TabIndex = 1;
            textBoxBarkod.TextChanged += textBoxBarkod_TextChanged;
            textBoxBarkod.KeyDown += textBoxBarkod_KeyDown;
            // 
            // label2
            // 
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(361, 66);
            label2.TabIndex = 0;
            label2.Text = "BARKADODU BURAYA GİRİNİZ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewUrunler
            // 
            dataGridViewUrunler.BackgroundColor = Color.LightSalmon;
            dataGridViewUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrunler.ContextMenuStrip = contextMenuSepet;
            dataGridViewUrunler.Location = new Point(324, 251);
            dataGridViewUrunler.Name = "dataGridViewUrunler";
            dataGridViewUrunler.Size = new Size(809, 456);
            dataGridViewUrunler.TabIndex = 2;
            dataGridViewUrunler.Click += menuSepettenCikar_Click;
            // 
            // contextMenuSepet
            // 
            contextMenuSepet.Items.AddRange(new ToolStripItem[] { menuSepettenCikar });
            contextMenuSepet.Name = "contextMenuSepet";
            contextMenuSepet.Size = new Size(208, 26);
            // 
            // menuSepettenCikar
            // 
            menuSepettenCikar.Name = "menuSepettenCikar";
            menuSepettenCikar.Size = new Size(207, 22);
            menuSepettenCikar.Text = "ÜRÜNÜ SEPETTEN ÇIKAR";
            menuSepettenCikar.Click += menuSepettenCikar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(labelToplam);
            panel3.Location = new Point(1193, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 174);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(171, 138);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 1;
            label3.Text = "TL";
            label3.Click += label3_Click;
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelToplam.Location = new Point(34, 53);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(50, 59);
            labelToplam.TabIndex = 0;
            labelToplam.Text = "0";
            labelToplam.Click += labelToplam_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(22, 23);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(251, 171);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1244, 792);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "GELİŞTİRİCİ ";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Red;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(1078, 750);
            label6.Name = "label6";
            label6.Size = new Size(256, 37);
            label6.TabIndex = 6;
            label6.Text = "ATİLLA MERCİMEK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1414, 796);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBoxLogo);
            Controls.Add(panel3);
            Controls.Add(dataGridViewUrunler);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " HızlıMarket Satış Ekranı";
            Load += Form1_Load;
            Shown += Form1_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).EndInit();
            contextMenuSepet.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button sonsatısbtn;
        private Button karzararbtn;
        private Button odemeyapbtn;
        private Button urunbilgibtn;
        private Button urunckrbtn;
        private Button uruneklebtn;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBoxBarkod;
        private Label label2;
        private DataGridView dataGridViewUrunler;
        private Panel panel3;
        private Label label3;
        private Label labelToplam;
        private Label label4;
        private PictureBox pictureBoxLogo;
        private Label label5;
        private Label label6;
        private ContextMenuStrip contextMenuSepet;
        private ToolStripMenuItem menuSepettenCikar;
    }
}
