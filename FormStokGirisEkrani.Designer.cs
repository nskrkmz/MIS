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
            this.btnStogaIsle.Location = new System.Drawing.Point(151, 47);
            this.btnStogaIsle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStogaIsle.Name = "btnStogaIsle";
            this.btnStogaIsle.Size = new System.Drawing.Size(107, 38);
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
            this.btnDosyaSec.Location = new System.Drawing.Point(35, 47);
            this.btnDosyaSec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(93, 36);
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
            this.cbTedarikciBorcSorgula.Location = new System.Drawing.Point(368, 57);
            this.cbTedarikciBorcSorgula.Name = "cbTedarikciBorcSorgula";
            this.cbTedarikciBorcSorgula.Size = new System.Drawing.Size(231, 21);
            this.cbTedarikciBorcSorgula.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tedarikçi Borç Sorgula";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(368, 118);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(558, 149);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnTedarikciOdemeYap
            // 
            this.btnTedarikciOdemeYap.Location = new System.Drawing.Point(368, 372);
            this.btnTedarikciOdemeYap.Name = "btnTedarikciOdemeYap";
            this.btnTedarikciOdemeYap.Size = new System.Drawing.Size(175, 23);
            this.btnTedarikciOdemeYap.TabIndex = 12;
            this.btnTedarikciOdemeYap.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.btnTedarikciOdemeYap.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(369, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(369, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "TOTAL BORÇ";
            // 
            // txtTedarikciBorcGiris
            // 
            this.txtTedarikciBorcGiris.Location = new System.Drawing.Point(368, 349);
            this.txtTedarikciBorcGiris.Name = "txtTedarikciBorcGiris";
            this.txtTedarikciBorcGiris.Size = new System.Drawing.Size(175, 20);
            this.txtTedarikciBorcGiris.TabIndex = 8;
            this.txtTedarikciBorcGiris.Text = "10";
            // 
            // txtTedarikciTotalBorc
            // 
            this.txtTedarikciTotalBorc.Location = new System.Drawing.Point(368, 309);
            this.txtTedarikciTotalBorc.Name = "txtTedarikciTotalBorc";
            this.txtTedarikciTotalBorc.Size = new System.Drawing.Size(175, 20);
            this.txtTedarikciTotalBorc.TabIndex = 9;
            this.txtTedarikciTotalBorc.Text = "156456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stok Bilgileri";
            // 
            // richTextBoxStokGoruntule
            // 
            this.richTextBoxStokGoruntule.Location = new System.Drawing.Point(33, 132);
            this.richTextBoxStokGoruntule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxStokGoruntule.Name = "richTextBoxStokGoruntule";
            this.richTextBoxStokGoruntule.Size = new System.Drawing.Size(288, 236);
            this.richTextBoxStokGoruntule.TabIndex = 14;
            this.richTextBoxStokGoruntule.Text = "";
            // 
            // FormStokGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(940, 494);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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