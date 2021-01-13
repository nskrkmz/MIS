namespace MIS
{
    partial class FormSatisEkrani
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
            this.VeresiyeÖdemeButonu = new System.Windows.Forms.Button();
            this.PeşinÖdemeButonu = new System.Windows.Forms.Button();
            this.btnAlınanUrunler = new System.Windows.Forms.RichTextBox();
            this.OdemeYontemi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSıl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VeresiyeÖdemeButonu
            // 
            this.VeresiyeÖdemeButonu.BackColor = System.Drawing.Color.SlateGray;
            this.VeresiyeÖdemeButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VeresiyeÖdemeButonu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VeresiyeÖdemeButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VeresiyeÖdemeButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VeresiyeÖdemeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeresiyeÖdemeButonu.Location = new System.Drawing.Point(465, 553);
            this.VeresiyeÖdemeButonu.Name = "VeresiyeÖdemeButonu";
            this.VeresiyeÖdemeButonu.Size = new System.Drawing.Size(208, 44);
            this.VeresiyeÖdemeButonu.TabIndex = 2;
            this.VeresiyeÖdemeButonu.Text = "Veresiye";
            this.VeresiyeÖdemeButonu.UseVisualStyleBackColor = false;
            this.VeresiyeÖdemeButonu.Click += new System.EventHandler(this.VeresiyeÖdemeButonu_Click);
            // 
            // PeşinÖdemeButonu
            // 
            this.PeşinÖdemeButonu.BackColor = System.Drawing.Color.SlateGray;
            this.PeşinÖdemeButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PeşinÖdemeButonu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PeşinÖdemeButonu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PeşinÖdemeButonu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PeşinÖdemeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.73585F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PeşinÖdemeButonu.Location = new System.Drawing.Point(465, 617);
            this.PeşinÖdemeButonu.Name = "PeşinÖdemeButonu";
            this.PeşinÖdemeButonu.Size = new System.Drawing.Size(208, 45);
            this.PeşinÖdemeButonu.TabIndex = 2;
            this.PeşinÖdemeButonu.Text = "Peşin";
            this.PeşinÖdemeButonu.UseVisualStyleBackColor = false;
            // 
            // btnAlınanUrunler
            // 
            this.btnAlınanUrunler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAlınanUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.btnAlınanUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlınanUrunler.ForeColor = System.Drawing.Color.White;
            this.btnAlınanUrunler.Location = new System.Drawing.Point(44, 1);
            this.btnAlınanUrunler.Name = "btnAlınanUrunler";
            this.btnAlınanUrunler.Size = new System.Drawing.Size(198, 38);
            this.btnAlınanUrunler.TabIndex = 4;
            this.btnAlınanUrunler.Text = "Alınan Ürünler";
            this.btnAlınanUrunler.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // OdemeYontemi
            // 
            this.OdemeYontemi.AutoSize = true;
            this.OdemeYontemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.OdemeYontemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdemeYontemi.ForeColor = System.Drawing.Color.White;
            this.OdemeYontemi.Location = new System.Drawing.Point(234, 553);
            this.OdemeYontemi.Name = "OdemeYontemi";
            this.OdemeYontemi.Size = new System.Drawing.Size(208, 31);
            this.OdemeYontemi.TabIndex = 7;
            this.OdemeYontemi.Text = "Ödeme Yöntemi";
            this.OdemeYontemi.Click += new System.EventHandler(this.OdemeYontemi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 598);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnSıl
            // 
            this.btnSıl.BackColor = System.Drawing.Color.SlateGray;
            this.btnSıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıl.Location = new System.Drawing.Point(52, 582);
            this.btnSıl.Name = "btnSıl";
            this.btnSıl.Size = new System.Drawing.Size(176, 37);
            this.btnSıl.TabIndex = 10;
            this.btnSıl.Text = "SİL";
            this.btnSıl.UseVisualStyleBackColor = false;
            this.btnSıl.Click += new System.EventHandler(this.btnSıl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOnayla);
            this.panel1.Controls.Add(this.SifreLabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(242, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 120);
            this.panel1.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(629, 485);
            this.listBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(66, 66);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(84, 39);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLabel.ForeColor = System.Drawing.Color.White;
            this.SifreLabel.Location = new System.Drawing.Point(38, 18);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(140, 19);
            this.SifreLabel.TabIndex = 4;
            this.SifreLabel.Text = "Doğrulama Şifresi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FormSatisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(957, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VeresiyeÖdemeButonu);
            this.Controls.Add(this.btnSıl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OdemeYontemi);
            this.Controls.Add(this.btnAlınanUrunler);
            this.Controls.Add(this.PeşinÖdemeButonu);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSatisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSatisEkrani";
            this.Load += new System.EventHandler(this.FormSatisEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VeresiyeÖdemeButonu;
        private System.Windows.Forms.Button PeşinÖdemeButonu;
        private System.Windows.Forms.RichTextBox btnAlınanUrunler;
        private System.Windows.Forms.Label OdemeYontemi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSıl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}