using System.Windows.Forms;

namespace Temel_Araç_Kullanımları
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            TextAdSoyad = new TextBox();
            label3 = new Label();
            TextSinav1 = new TextBox();
            label4 = new Label();
            TextSinav2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            TextSinav3 = new TextBox();
            label6 = new Label();
            TextOrtalama = new TextBox();
            label7 = new Label();
            Btn_Kaydet = new Button();
            Btn_Hesapla = new Button();
            Btn_Temizle = new Button();
            listBox1 = new ListBox();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            TextDurum = new TextBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            Btn_Cizgi = new Button();
            Txt_Sayac = new Button();
            label10 = new Label();
            Btn_Mesaj = new Button();
            listBox2 = new ListBox();
            BtnForDöngüsü2 = new Button();
            BtnListTemizle = new Button();
            BtnWhile = new Button();
            BtnDizi1 = new Button();
            BtnDizi2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(167, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Not Kayıt Sistemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // TextAdSoyad
            // 
            TextAdSoyad.Location = new System.Drawing.Point(117, 89);
            TextAdSoyad.Name = "TextAdSoyad";
            TextAdSoyad.Size = new System.Drawing.Size(100, 29);
            TextAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 136);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 21);
            label3.TabIndex = 3;
            label3.Text = "ders:";
            // 
            // TextSinav1
            // 
            TextSinav1.Location = new System.Drawing.Point(117, 236);
            TextSinav1.Name = "TextSinav1";
            TextSinav1.Size = new System.Drawing.Size(100, 29);
            TextSinav1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(40, 234);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 21);
            label4.TabIndex = 5;
            label4.Text = "Sınav1:";
            // 
            // TextSinav2
            // 
            TextSinav2.Location = new System.Drawing.Point(117, 271);
            TextSinav2.Name = "TextSinav2";
            TextSinav2.Size = new System.Drawing.Size(100, 29);
            TextSinav2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(40, 269);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 21);
            label5.TabIndex = 7;
            label5.Text = "Sınav2:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Algoritma ", "Yapay Zeka", "Mikro işlemciler " });
            comboBox1.Location = new System.Drawing.Point(117, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(108, 29);
            comboBox1.TabIndex = 9;
            // 
            // TextSinav3
            // 
            TextSinav3.Location = new System.Drawing.Point(117, 325);
            TextSinav3.Name = "TextSinav3";
            TextSinav3.Size = new System.Drawing.Size(100, 29);
            TextSinav3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(40, 323);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(64, 21);
            label6.TabIndex = 10;
            label6.Text = "Sınav 3:";
            // 
            // TextOrtalama
            // 
            TextOrtalama.Enabled = false;
            TextOrtalama.Location = new System.Drawing.Point(117, 370);
            TextOrtalama.Name = "TextOrtalama";
            TextOrtalama.Size = new System.Drawing.Size(100, 29);
            TextOrtalama.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(62, 370);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(36, 21);
            label7.TabIndex = 12;
            label7.Text = "Ort:";
            // 
            // Btn_Kaydet
            // 
            Btn_Kaydet.Location = new System.Drawing.Point(12, 444);
            Btn_Kaydet.Name = "Btn_Kaydet";
            Btn_Kaydet.Size = new System.Drawing.Size(76, 32);
            Btn_Kaydet.TabIndex = 14;
            Btn_Kaydet.Text = "Kaydet";
            Btn_Kaydet.UseVisualStyleBackColor = true;
            Btn_Kaydet.Click += Btn_Kaydet_Click;
            // 
            // Btn_Hesapla
            // 
            Btn_Hesapla.Location = new System.Drawing.Point(94, 444);
            Btn_Hesapla.Name = "Btn_Hesapla";
            Btn_Hesapla.Size = new System.Drawing.Size(76, 32);
            Btn_Hesapla.TabIndex = 15;
            Btn_Hesapla.Text = "Hesapla";
            Btn_Hesapla.UseVisualStyleBackColor = true;
            Btn_Hesapla.Click += Btn_Hesapla_Click;
            // 
            // Btn_Temizle
            // 
            Btn_Temizle.Location = new System.Drawing.Point(176, 444);
            Btn_Temizle.Name = "Btn_Temizle";
            Btn_Temizle.Size = new System.Drawing.Size(76, 32);
            Btn_Temizle.TabIndex = 16;
            Btn_Temizle.Text = "Temizle";
            Btn_Temizle.UseVisualStyleBackColor = true;
            Btn_Temizle.Click += Btn_Temizle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new System.Drawing.Point(300, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(207, 340);
            listBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(24, 188);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 21);
            label8.TabIndex = 18;
            label8.Text = "Numara: ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new System.Drawing.Point(117, 190);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(100, 29);
            maskedTextBox1.TabIndex = 19;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // TextDurum
            // 
            TextDurum.Enabled = false;
            TextDurum.Location = new System.Drawing.Point(117, 405);
            TextDurum.Name = "TextDurum";
            TextDurum.Size = new System.Drawing.Size(100, 29);
            TextDurum.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(36, 405);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(62, 21);
            label9.TabIndex = 20;
            label9.Text = "Durum:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(472, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(230, 50);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Btn_Cizgi
            // 
            Btn_Cizgi.Location = new System.Drawing.Point(258, 444);
            Btn_Cizgi.Name = "Btn_Cizgi";
            Btn_Cizgi.Size = new System.Drawing.Size(63, 32);
            Btn_Cizgi.TabIndex = 23;
            Btn_Cizgi.Text = "Çizgi";
            Btn_Cizgi.UseVisualStyleBackColor = true;
            Btn_Cizgi.Click += Btn_Cizgi_Click;
            // 
            // Txt_Sayac
            // 
            Txt_Sayac.Location = new System.Drawing.Point(327, 444);
            Txt_Sayac.Name = "Txt_Sayac";
            Txt_Sayac.Size = new System.Drawing.Size(63, 32);
            Txt_Sayac.TabIndex = 24;
            Txt_Sayac.Text = "Sayac";
            Txt_Sayac.UseVisualStyleBackColor = true;
            Txt_Sayac.Click += Txt_Sayac_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(233, 417);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(61, 21);
            label10.TabIndex = 25;
            label10.Text = "label10";
            // 
            // Btn_Mesaj
            // 
            Btn_Mesaj.Location = new System.Drawing.Point(409, 444);
            Btn_Mesaj.Name = "Btn_Mesaj";
            Btn_Mesaj.Size = new System.Drawing.Size(111, 32);
            Btn_Mesaj.TabIndex = 26;
            Btn_Mesaj.Text = "Mesaj kutusu";
            Btn_Mesaj.UseVisualStyleBackColor = true;
            Btn_Mesaj.Click += Btn_Mesaj_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new System.Drawing.Point(537, 98);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(165, 340);
            listBox2.TabIndex = 28;
            // 
            // BtnForDöngüsü2
            // 
            BtnForDöngüsü2.Location = new System.Drawing.Point(12, 494);
            BtnForDöngüsü2.Name = "BtnForDöngüsü2";
            BtnForDöngüsü2.Size = new System.Drawing.Size(124, 33);
            BtnForDöngüsü2.TabIndex = 29;
            BtnForDöngüsü2.Text = "For döngüsü 2 ";
            BtnForDöngüsü2.UseVisualStyleBackColor = true;
            BtnForDöngüsü2.Click += BtnForDöngüsü2_Click;
            // 
            // BtnListTemizle
            // 
            BtnListTemizle.Location = new System.Drawing.Point(142, 494);
            BtnListTemizle.Name = "BtnListTemizle";
            BtnListTemizle.Size = new System.Drawing.Size(124, 33);
            BtnListTemizle.TabIndex = 30;
            BtnListTemizle.Text = "ListBoxTemizle";
            BtnListTemizle.UseVisualStyleBackColor = true;
            BtnListTemizle.Click += BtnListTemizle_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new System.Drawing.Point(272, 494);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new System.Drawing.Size(85, 33);
            BtnWhile.TabIndex = 31;
            BtnWhile.Text = "While";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // BtnDizi1
            // 
            BtnDizi1.Location = new System.Drawing.Point(373, 494);
            BtnDizi1.Name = "BtnDizi1";
            BtnDizi1.Size = new System.Drawing.Size(85, 33);
            BtnDizi1.TabIndex = 32;
            BtnDizi1.Text = "Dizi1";
            BtnDizi1.UseVisualStyleBackColor = true;
            BtnDizi1.Click += BtnDizi1_Click;
            // 
            // BtnDizi2
            // 
            BtnDizi2.Location = new System.Drawing.Point(472, 494);
            BtnDizi2.Name = "BtnDizi2";
            BtnDizi2.Size = new System.Drawing.Size(85, 33);
            BtnDizi2.TabIndex = 33;
            BtnDizi2.Text = "Dizi2";
            BtnDizi2.UseVisualStyleBackColor = true;
            BtnDizi2.Click += BtnDizi2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(537, 443);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(124, 33);
            button1.TabIndex = 29;
            button1.Text = "For döngüsü 2 ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnFor_;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(726, 561);
            Controls.Add(BtnDizi2);
            Controls.Add(BtnDizi1);
            Controls.Add(BtnWhile);
            Controls.Add(BtnListTemizle);
            Controls.Add(button1);
            Controls.Add(BtnForDöngüsü2);
            Controls.Add(listBox2);
            Controls.Add(Btn_Mesaj);
            Controls.Add(label10);
            Controls.Add(Txt_Sayac);
            Controls.Add(Btn_Cizgi);
            Controls.Add(pictureBox1);
            Controls.Add(TextDurum);
            Controls.Add(label9);
            Controls.Add(maskedTextBox1);
            Controls.Add(label8);
            Controls.Add(listBox1);
            Controls.Add(Btn_Temizle);
            Controls.Add(Btn_Hesapla);
            Controls.Add(Btn_Kaydet);
            Controls.Add(TextOrtalama);
            Controls.Add(label7);
            Controls.Add(TextSinav3);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(TextSinav2);
            Controls.Add(label5);
            Controls.Add(TextSinav1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TextAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextSinav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextSinav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TextSinav3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextOrtalama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Button Btn_Hesapla;
        private System.Windows.Forms.Button Btn_Temizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox TextDurum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cizgi;
        private System.Windows.Forms.Button Txt_Sayac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_Mesaj;

        public Button BtnForDöngüsü1 { get; private set; }

        private System.Windows.Forms.Button BtnForDöngüsü;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnForDöngüsü2;
        private System.Windows.Forms.Button BtnListTemizle;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Button BtnDizi1;
        private System.Windows.Forms.Button BtnDizi2;
        private Button button1;
    }
}