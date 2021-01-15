namespace MIS
{
    partial class FormStokGirisEkrani
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
            this.btnStogaIsle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.cbTedarikciBorcSorgula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciOdemeYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTedarikciBorcGiris = new System.Windows.Forms.TextBox();
            this.txtTedarikciTotalBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lBStokGoruntule = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.stokonay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idTed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ıd = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStogaIsle
            // 
            this.btnStogaIsle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStogaIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStogaIsle.Location = new System.Drawing.Point(227, 32);
            this.btnStogaIsle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStogaIsle.Name = "btnStogaIsle";
            this.btnStogaIsle.Size = new System.Drawing.Size(137, 65);
            this.btnStogaIsle.TabIndex = 0;
            this.btnStogaIsle.Text = "Stoğa İşle";
            this.btnStogaIsle.UseVisualStyleBackColor = false;
            this.btnStogaIsle.Click += new System.EventHandler(this.btnStogaIsle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDosyaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaSec.Location = new System.Drawing.Point(15, 32);
            this.btnDosyaSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(135, 65);
            this.btnDosyaSec.TabIndex = 1;
            this.btnDosyaSec.Text = "Dosya Görüntüle";
            this.btnDosyaSec.UseVisualStyleBackColor = false;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // cbTedarikciBorcSorgula
            // 
            this.cbTedarikciBorcSorgula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTedarikciBorcSorgula.FormattingEnabled = true;
            this.cbTedarikciBorcSorgula.Location = new System.Drawing.Point(296, 459);
            this.cbTedarikciBorcSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.cbTedarikciBorcSorgula.Name = "cbTedarikciBorcSorgula";
            this.cbTedarikciBorcSorgula.Size = new System.Drawing.Size(307, 24);
            this.cbTedarikciBorcSorgula.TabIndex = 2;
            this.cbTedarikciBorcSorgula.SelectedIndexChanged += new System.EventHandler(this.cbTedarikciBorcSorgula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi Borç Sorgula";
            // 
            // btnTedarikciOdemeYap
            // 
            this.btnTedarikciOdemeYap.BackColor = System.Drawing.Color.SlateGray;
            this.btnTedarikciOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciOdemeYap.Location = new System.Drawing.Point(648, 740);
            this.btnTedarikciOdemeYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnTedarikciOdemeYap.Name = "btnTedarikciOdemeYap";
            this.btnTedarikciOdemeYap.Size = new System.Drawing.Size(233, 96);
            this.btnTedarikciOdemeYap.TabIndex = 12;
            this.btnTedarikciOdemeYap.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.btnTedarikciOdemeYap.UseVisualStyleBackColor = false;
            this.btnTedarikciOdemeYap.Click += new System.EventHandler(this.btnTedarikciOdemeYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 763);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 762);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL BORÇ";
            // 
            // txtTedarikciBorcGiris
            // 
            this.txtTedarikciBorcGiris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTedarikciBorcGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciBorcGiris.Location = new System.Drawing.Point(295, 791);
            this.txtTedarikciBorcGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciBorcGiris.Name = "txtTedarikciBorcGiris";
            this.txtTedarikciBorcGiris.Size = new System.Drawing.Size(232, 27);
            this.txtTedarikciBorcGiris.TabIndex = 8;
            this.txtTedarikciBorcGiris.Text = "0";
            this.txtTedarikciBorcGiris.TextChanged += new System.EventHandler(this.txtTedarikciBorcGiris_TextChanged);
            // 
            // txtTedarikciTotalBorc
            // 
            this.txtTedarikciTotalBorc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTedarikciTotalBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciTotalBorc.Location = new System.Drawing.Point(55, 791);
            this.txtTedarikciTotalBorc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciTotalBorc.Name = "txtTedarikciTotalBorc";
            this.txtTedarikciTotalBorc.Size = new System.Drawing.Size(232, 26);
            this.txtTedarikciTotalBorc.TabIndex = 9;
            this.txtTedarikciTotalBorc.Text = "0";
            this.txtTedarikciTotalBorc.TextChanged += new System.EventHandler(this.txtTedarikciTotalBorc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Giriş Bilgileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 492);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1221, 239);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lBStokGoruntule
            // 
            this.lBStokGoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lBStokGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBStokGoruntule.FormattingEnabled = true;
            this.lBStokGoruntule.ItemHeight = 29;
            this.lBStokGoruntule.Location = new System.Drawing.Point(12, 199);
            this.lBStokGoruntule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lBStokGoruntule.Name = "lBStokGoruntule";
            this.lBStokGoruntule.Size = new System.Drawing.Size(1232, 178);
            this.lBStokGoruntule.TabIndex = 16;
            this.lBStokGoruntule.SelectedIndexChanged += new System.EventHandler(this.lBStokGoruntule_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1035, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ürün ID \\ Ürün AD \\ Ürün Depo Tarihi \\ Ürün Alış Fiyatı \\ Ürün Satış Fiyatı \\ Ürü" +
    "n GR \\ STT \\ İrsaliye No \\ Kategori \\ %Kar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tedarikçi ID Seçiniz :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.stokonay);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.idTed);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ıd);
            this.panel1.Location = new System.Drawing.Point(548, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 277);
            this.panel1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(217, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(62, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "ONAYLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Stok Onay Şifresi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // stokonay
            // 
            this.stokonay.Location = new System.Drawing.Point(26, 169);
            this.stokonay.Name = "stokonay";
            this.stokonay.Size = new System.Drawing.Size(193, 22);
            this.stokonay.TabIndex = 4;
            this.stokonay.TextChanged += new System.EventHandler(this.stokonay_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tedarikci ID";
            // 
            // idTed
            // 
            this.idTed.Location = new System.Drawing.Point(26, 99);
            this.idTed.Name = "idTed";
            this.idTed.Size = new System.Drawing.Size(193, 22);
            this.idTed.TabIndex = 2;
            this.idTed.TextChanged += new System.EventHandler(this.idTed_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Çalışan ID";
            // 
            // ıd
            // 
            this.ıd.Location = new System.Drawing.Point(26, 39);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(193, 22);
            this.ıd.TabIndex = 0;
            this.ıd.TextChanged += new System.EventHandler(this.ıd_TextChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1124, 442);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 41);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormStokGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1276, 892);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lBStokGoruntule);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTedarikciOdemeYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTedarikciBorcGiris);
            this.Controls.Add(this.txtTedarikciTotalBorc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTedarikciBorcSorgula);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnStogaIsle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStokGirisEkrani";
            this.Text = "FormStokGirisEkrani";
            this.Load += new System.EventHandler(this.FormStokGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStogaIsle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.ComboBox cbTedarikciBorcSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTedarikciOdemeYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTedarikciBorcGiris;
        private System.Windows.Forms.TextBox txtTedarikciTotalBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListBox lBStokGoruntule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stokonay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox idTed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ıd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuncelle;
    }
}