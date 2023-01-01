namespace WindowsFormsApp1
{
    partial class FrmUrun
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_Urun = new System.Windows.Forms.TextBox();
            this.Btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nud_Stok = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Text_Satış = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Text_Alısfiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Text_Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_kaydet = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Stok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Id:";
            // 
            // Text_Urun
            // 
            this.Text_Urun.Location = new System.Drawing.Point(109, 23);
            this.Text_Urun.Name = "Text_Urun";
            this.Text_Urun.Size = new System.Drawing.Size(99, 24);
            this.Text_Urun.TabIndex = 2;
            // 
            // Btn_listele
            // 
            this.Btn_listele.Location = new System.Drawing.Point(544, 248);
            this.Btn_listele.Name = "Btn_listele";
            this.Btn_listele.Size = new System.Drawing.Size(226, 31);
            this.Btn_listele.TabIndex = 5;
            this.Btn_listele.Text = "Listele";
            this.Btn_listele.UseVisualStyleBackColor = true;
            this.Btn_listele.Click += new System.EventHandler(this.Btn_listele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nud_Stok);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Text_Satış);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Text_Alısfiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Text_Ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Text_Urun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(544, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Nud_Stok
            // 
            this.Nud_Stok.Location = new System.Drawing.Point(109, 80);
            this.Nud_Stok.Name = "Nud_Stok";
            this.Nud_Stok.Size = new System.Drawing.Size(99, 24);
            this.Nud_Stok.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 26);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategori:";
            // 
            // Text_Satış
            // 
            this.Text_Satış.Location = new System.Drawing.Point(109, 143);
            this.Text_Satış.Name = "Text_Satış";
            this.Text_Satış.Size = new System.Drawing.Size(99, 24);
            this.Text_Satış.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // Text_Alısfiyat
            // 
            this.Text_Alısfiyat.Location = new System.Drawing.Point(109, 113);
            this.Text_Alısfiyat.Name = "Text_Alısfiyat";
            this.Text_Alısfiyat.Size = new System.Drawing.Size(99, 24);
            this.Text_Alısfiyat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok :";
            // 
            // Text_Ad
            // 
            this.Text_Ad.Location = new System.Drawing.Point(109, 53);
            this.Text_Ad.Name = "Text_Ad";
            this.Text_Ad.Size = new System.Drawing.Size(99, 24);
            this.Text_Ad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı:";
            // 
            // Btn_kaydet
            // 
            this.Btn_kaydet.Location = new System.Drawing.Point(544, 285);
            this.Btn_kaydet.Name = "Btn_kaydet";
            this.Btn_kaydet.Size = new System.Drawing.Size(226, 31);
            this.Btn_kaydet.TabIndex = 7;
            this.Btn_kaydet.Text = "Kaydet";
            this.Btn_kaydet.UseVisualStyleBackColor = true;
            this.Btn_kaydet.Click += new System.EventHandler(this.Btn_kaydet_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(544, 322);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(226, 31);
            this.Btn_Sil.TabIndex = 8;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(544, 365);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(226, 31);
            this.Btn_Guncelle.TabIndex = 9;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 408);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_kaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_listele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Stok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_Urun;
        private System.Windows.Forms.Button Btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Text_Satış;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_Alısfiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Text_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_kaydet;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown Nud_Stok;
    }
}