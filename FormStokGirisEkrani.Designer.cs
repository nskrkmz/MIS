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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTedarikciOdemeYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTedarikciBorcGiris = new System.Windows.Forms.TextBox();
            this.txtTedarikciTotalBorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxStokGoruntule = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStogaIsle
            // 
            this.btnStogaIsle.Location = new System.Drawing.Point(201, 58);
            this.btnStogaIsle.Name = "btnStogaIsle";
            this.btnStogaIsle.Size = new System.Drawing.Size(143, 47);
            this.btnStogaIsle.TabIndex = 0;
            this.btnStogaIsle.Text = "Stoğa İşle";
            this.btnStogaIsle.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(47, 58);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(124, 44);
            this.btnDosyaSec.TabIndex = 1;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // cbTedarikciBorcSorgula
            // 
            this.cbTedarikciBorcSorgula.FormattingEnabled = true;
            this.cbTedarikciBorcSorgula.Items.AddRange(new object[] {
            "18061256",
            "18061277",
            "18061263"});
            this.cbTedarikciBorcSorgula.Location = new System.Drawing.Point(490, 70);
            this.cbTedarikciBorcSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.cbTedarikciBorcSorgula.Name = "cbTedarikciBorcSorgula";
            this.cbTedarikciBorcSorgula.Size = new System.Drawing.Size(307, 24);
            this.cbTedarikciBorcSorgula.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(486, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi Borç Sorgula";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(490, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(743, 183);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnTedarikciOdemeYap
            // 
            this.btnTedarikciOdemeYap.Location = new System.Drawing.Point(490, 458);
            this.btnTedarikciOdemeYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnTedarikciOdemeYap.Name = "btnTedarikciOdemeYap";
            this.btnTedarikciOdemeYap.Size = new System.Drawing.Size(233, 28);
            this.btnTedarikciOdemeYap.TabIndex = 12;
            this.btnTedarikciOdemeYap.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.btnTedarikciOdemeYap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL BORÇ";
            // 
            // txtTedarikciBorcGiris
            // 
            this.txtTedarikciBorcGiris.Location = new System.Drawing.Point(490, 430);
            this.txtTedarikciBorcGiris.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciBorcGiris.Name = "txtTedarikciBorcGiris";
            this.txtTedarikciBorcGiris.Size = new System.Drawing.Size(232, 22);
            this.txtTedarikciBorcGiris.TabIndex = 8;
            this.txtTedarikciBorcGiris.Text = "10";
            // 
            // txtTedarikciTotalBorc
            // 
            this.txtTedarikciTotalBorc.Location = new System.Drawing.Point(490, 380);
            this.txtTedarikciTotalBorc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTedarikciTotalBorc.Name = "txtTedarikciTotalBorc";
            this.txtTedarikciTotalBorc.Size = new System.Drawing.Size(232, 22);
            this.txtTedarikciTotalBorc.TabIndex = 9;
            this.txtTedarikciTotalBorc.Text = "156456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Bilgileri";
            // 
            // richTextBoxStokGoruntule
            // 
            this.richTextBoxStokGoruntule.Location = new System.Drawing.Point(44, 163);
            this.richTextBoxStokGoruntule.Name = "richTextBoxStokGoruntule";
            this.richTextBoxStokGoruntule.Size = new System.Drawing.Size(383, 289);
            this.richTextBoxStokGoruntule.TabIndex = 14;
            this.richTextBoxStokGoruntule.Text = "";
            // 
            // FormStokGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1245, 608);
            this.Controls.Add(this.richTextBoxStokGoruntule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTedarikciOdemeYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTedarikciBorcGiris);
            this.Controls.Add(this.txtTedarikciTotalBorc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTedarikciBorcSorgula);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnStogaIsle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStokGirisEkrani";
            this.Text = "FormStokGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStogaIsle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.ComboBox cbTedarikciBorcSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTedarikciOdemeYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTedarikciBorcGiris;
        private System.Windows.Forms.TextBox txtTedarikciTotalBorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxStokGoruntule;
    }
}