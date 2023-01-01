namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Kategoriid = new System.Windows.Forms.TextBox();
            this.Text_KategoriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Listele = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.Tbl_Ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Text_Kategoriid);
            this.groupBox1.Controls.Add(this.Text_KategoriAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori id:";
            // 
            // Text_Kategoriid
            // 
            this.Text_Kategoriid.Location = new System.Drawing.Point(221, 20);
            this.Text_Kategoriid.Name = "Text_Kategoriid";
            this.Text_Kategoriid.Size = new System.Drawing.Size(93, 20);
            this.Text_Kategoriid.TabIndex = 2;
            // 
            // Text_KategoriAd
            // 
            this.Text_KategoriAd.Location = new System.Drawing.Point(77, 20);
            this.Text_KategoriAd.Name = "Text_KategoriAd";
            this.Text_KategoriAd.Size = new System.Drawing.Size(68, 20);
            this.Text_KategoriAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ad:";
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.Location = new System.Drawing.Point(329, 83);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(91, 36);
            this.Btn_Listele.TabIndex = 2;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.UseVisualStyleBackColor = true;
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(328, 125);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(91, 36);
            this.Btn_Kaydet.TabIndex = 3;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(329, 167);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(91, 36);
            this.Btn_Sil.TabIndex = 4;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.Location = new System.Drawing.Point(329, 210);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(91, 36);
            this.Btn_guncelle.TabIndex = 5;
            this.Btn_guncelle.Text = "Güncelle";
            this.Btn_guncelle.UseVisualStyleBackColor = true;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // Tbl_Ara
            // 
            this.Tbl_Ara.Location = new System.Drawing.Point(329, 252);
            this.Tbl_Ara.Name = "Tbl_Ara";
            this.Tbl_Ara.Size = new System.Drawing.Size(91, 36);
            this.Tbl_Ara.TabIndex = 6;
            this.Tbl_Ara.Text = "Ara";
            this.Tbl_Ara.UseVisualStyleBackColor = true;
            this.Tbl_Ara.Click += new System.EventHandler(this.Tbl_Ara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 314);
            this.Controls.Add(this.Tbl_Ara);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.Btn_Sil);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Text_KategoriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Listele;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Kategoriid;
        private System.Windows.Forms.Button Tbl_Ara;
    }
}

