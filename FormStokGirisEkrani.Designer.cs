﻿namespace MIS
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStogaIsle
            // 
            this.btnStogaIsle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStogaIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStogaIsle.Location = new System.Drawing.Point(170, 26);
            this.btnStogaIsle.Margin = new System.Windows.Forms.Padding(2);
            this.btnStogaIsle.Name = "btnStogaIsle";
            this.btnStogaIsle.Size = new System.Drawing.Size(103, 53);
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
            this.btnDosyaSec.Location = new System.Drawing.Point(11, 26);
            this.btnDosyaSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(101, 53);
            this.btnDosyaSec.TabIndex = 1;
            this.btnDosyaSec.Text = "Dosya Görüntüle";
            this.btnDosyaSec.UseVisualStyleBackColor = false;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // cbTedarikciBorcSorgula
            // 
            this.cbTedarikciBorcSorgula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbTedarikciBorcSorgula.FormattingEnabled = true;
            this.cbTedarikciBorcSorgula.Location = new System.Drawing.Point(222, 373);
            this.cbTedarikciBorcSorgula.Name = "cbTedarikciBorcSorgula";
            this.cbTedarikciBorcSorgula.Size = new System.Drawing.Size(231, 21);
            this.cbTedarikciBorcSorgula.TabIndex = 2;
            this.cbTedarikciBorcSorgula.SelectedIndexChanged += new System.EventHandler(this.cbTedarikciBorcSorgula_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi Borç Sorgula";
            // 
            // btnTedarikciOdemeYap
            // 
            this.btnTedarikciOdemeYap.BackColor = System.Drawing.Color.SlateGray;
            this.btnTedarikciOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciOdemeYap.Location = new System.Drawing.Point(486, 601);
            this.btnTedarikciOdemeYap.Name = "btnTedarikciOdemeYap";
            this.btnTedarikciOdemeYap.Size = new System.Drawing.Size(175, 78);
            this.btnTedarikciOdemeYap.TabIndex = 12;
            this.btnTedarikciOdemeYap.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.btnTedarikciOdemeYap.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 619);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL BORÇ";
            // 
            // txtTedarikciBorcGiris
            // 
            this.txtTedarikciBorcGiris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTedarikciBorcGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciBorcGiris.Location = new System.Drawing.Point(221, 643);
            this.txtTedarikciBorcGiris.Name = "txtTedarikciBorcGiris";
            this.txtTedarikciBorcGiris.Size = new System.Drawing.Size(175, 24);
            this.txtTedarikciBorcGiris.TabIndex = 8;
            this.txtTedarikciBorcGiris.Text = "0";
            // 
            // txtTedarikciTotalBorc
            // 
            this.txtTedarikciTotalBorc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTedarikciTotalBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciTotalBorc.Location = new System.Drawing.Point(41, 643);
            this.txtTedarikciTotalBorc.Name = "txtTedarikciTotalBorc";
            this.txtTedarikciTotalBorc.Size = new System.Drawing.Size(175, 24);
            this.txtTedarikciTotalBorc.TabIndex = 9;
            this.txtTedarikciTotalBorc.Text = "0";
            this.txtTedarikciTotalBorc.TextChanged += new System.EventHandler(this.txtTedarikciTotalBorc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Giriş Bilgileri";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 400);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(916, 194);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lBStokGoruntule
            // 
            this.lBStokGoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lBStokGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBStokGoruntule.FormattingEnabled = true;
            this.lBStokGoruntule.ItemHeight = 25;
            this.lBStokGoruntule.Location = new System.Drawing.Point(9, 162);
            this.lBStokGoruntule.Margin = new System.Windows.Forms.Padding(2);
            this.lBStokGoruntule.Name = "lBStokGoruntule";
            this.lBStokGoruntule.Size = new System.Drawing.Size(925, 154);
            this.lBStokGoruntule.TabIndex = 16;
            this.lBStokGoruntule.SelectedIndexChanged += new System.EventHandler(this.lBStokGoruntule_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(962, 20);
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
            this.label6.Location = new System.Drawing.Point(37, 373);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tedarikçi ID Seçiniz :";
            // 
            // FormStokGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(957, 725);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStokGirisEkrani";
            this.Text = "FormStokGirisEkrani";
            this.Load += new System.EventHandler(this.FormStokGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
    }
}