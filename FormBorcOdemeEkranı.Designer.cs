
namespace MIS
{
    partial class FormBorcOdemeEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbBorcluMustList = new System.Windows.Forms.ComboBox();
            this.btnBorcSorgula = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.txtBTotalBorc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veresiye Müşteri Listesi";
            // 
            // cbBorcluMustList
            // 
            this.cbBorcluMustList.FormattingEnabled = true;
            this.cbBorcluMustList.Items.AddRange(new object[] {
            "18061256",
            "18061277",
            "18061263"});
            this.cbBorcluMustList.Location = new System.Drawing.Point(16, 36);
            this.cbBorcluMustList.Name = "cbBorcluMustList";
            this.cbBorcluMustList.Size = new System.Drawing.Size(231, 21);
            this.cbBorcluMustList.TabIndex = 1;
            // 
            // btnBorcSorgula
            // 
            this.btnBorcSorgula.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorcSorgula.Location = new System.Drawing.Point(16, 63);
            this.btnBorcSorgula.Name = "btnBorcSorgula";
            this.btnBorcSorgula.Size = new System.Drawing.Size(231, 40);
            this.btnBorcSorgula.TabIndex = 2;
            this.btnBorcSorgula.Text = "BORÇ SORGULA";
            this.btnBorcSorgula.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox3.Location = new System.Drawing.Point(280, 9);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(655, 511);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "+deterjan\n+çikolata\n+yumurta\n+tavuk\n+kırmızı et\n+tuz\n+vs..";
            // 
            // txtBTotalBorc
            // 
            this.txtBTotalBorc.Location = new System.Drawing.Point(16, 299);
            this.txtBTotalBorc.Name = "txtBTotalBorc";
            this.txtBTotalBorc.Size = new System.Drawing.Size(175, 20);
            this.txtBTotalBorc.TabIndex = 5;
            this.txtBTotalBorc.Text = "156456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL BORÇ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormBorcOdemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(947, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBTotalBorc);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.btnBorcSorgula);
            this.Controls.Add(this.cbBorcluMustList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorcOdemeEkranı";
            this.Text = "FormBorcOdemeEkranı";
            this.Load += new System.EventHandler(this.FormBorcOdemeEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBorcluMustList;
        private System.Windows.Forms.Button btnBorcSorgula;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox txtBTotalBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}