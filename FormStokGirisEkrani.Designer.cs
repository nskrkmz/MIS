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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.cbTedarikciBorcSorgula.Items.AddRange(new object[] {
            "18061256",
            "18061277",
            "18061263"});
            this.cbTedarikciBorcSorgula.Location = new System.Drawing.Point(22, 503);
            this.cbTedarikciBorcSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.cbTedarikciBorcSorgula.Name = "cbTedarikciBorcSorgula";
            this.cbTedarikciBorcSorgula.Size = new System.Drawing.Size(307, 24);
            this.cbTedarikciBorcSorgula.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi Borç Sorgula";
            // 
            // btnTedarikciOdemeYap
            // 
            this.btnTedarikciOdemeYap.BackColor = System.Drawing.Color.SlateGray;
            this.btnTedarikciOdemeYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikciOdemeYap.Location = new System.Drawing.Point(623, 783);
            this.btnTedarikciOdemeYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnTedarikciOdemeYap.Name = "btnTedarikciOdemeYap";
            this.btnTedarikciOdemeYap.Size = new System.Drawing.Size(233, 96);
            this.btnTedarikciOdemeYap.TabIndex = 12;
            this.btnTedarikciOdemeYap.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.btnTedarikciOdemeYap.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(285, 806);
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
            this.label2.Location = new System.Drawing.Point(44, 805);
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
            this.txtTedarikciBorcGiris.Location = new System.Drawing.Point(289, 834);
            this.txtTedarikciBorcGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciBorcGiris.Name = "txtTedarikciBorcGiris";
            this.txtTedarikciBorcGiris.Size = new System.Drawing.Size(232, 27);
            this.txtTedarikciBorcGiris.TabIndex = 8;
            this.txtTedarikciBorcGiris.Text = "10";
            // 
            // txtTedarikciTotalBorc
            // 
            this.txtTedarikciTotalBorc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTedarikciTotalBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciTotalBorc.Location = new System.Drawing.Point(49, 834);
            this.txtTedarikciTotalBorc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciTotalBorc.Name = "txtTedarikciTotalBorc";
            this.txtTedarikciTotalBorc.Size = new System.Drawing.Size(232, 26);
            this.txtTedarikciTotalBorc.TabIndex = 9;
            this.txtTedarikciTotalBorc.Text = "156456";
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
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 536);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1222, 239);
            this.dataGridView2.TabIndex = 15;
            // 
            // lBStokGoruntule
            // 
            this.lBStokGoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lBStokGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBStokGoruntule.FormattingEnabled = true;
            this.lBStokGoruntule.ItemHeight = 29;
            this.lBStokGoruntule.Location = new System.Drawing.Point(12, 200);
            this.lBStokGoruntule.Name = "lBStokGoruntule";
            this.lBStokGoruntule.Size = new System.Drawing.Size(1232, 236);
            this.lBStokGoruntule.TabIndex = 16;
            this.lBStokGoruntule.SelectedIndexChanged += new System.EventHandler(this.lBStokGoruntule_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1035, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ürün ID \\ Ürün AD \\ Ürün Depo Tarihi \\ Ürün Alış Fiyatı \\ Ürün Satış Fiyatı \\ Ürü" +
    "n GR \\ STT \\ İrsaliye No \\ Kategori \\ %Kar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormStokGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1276, 892);
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
    }
}