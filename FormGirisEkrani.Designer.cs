namespace MIS
{
    partial class FormGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisEkrani));
            this.pictureBoxKucukResim1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxKucukResim2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMISLogo = new System.Windows.Forms.PictureBox();
            this.KullaniciNoGiris = new System.Windows.Forms.TextBox();
            this.SifreGiris = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.btnKayıtOl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucukResim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucukResim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMISLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKucukResim1
            // 
            this.pictureBoxKucukResim1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKucukResim1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKucukResim1.Image = global::MIS.Properties.Resources.users;
            this.pictureBoxKucukResim1.Location = new System.Drawing.Point(101, 250);
            this.pictureBoxKucukResim1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxKucukResim1.MaximumSize = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim1.MinimumSize = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim1.Name = "pictureBoxKucukResim1";
            this.pictureBoxKucukResim1.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKucukResim1.TabIndex = 0;
            this.pictureBoxKucukResim1.TabStop = false;
            // 
            // pictureBoxKucukResim2
            // 
            this.pictureBoxKucukResim2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKucukResim2.Image = global::MIS.Properties.Resources.password_Image;
            this.pictureBoxKucukResim2.Location = new System.Drawing.Point(101, 306);
            this.pictureBoxKucukResim2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxKucukResim2.MaximumSize = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim2.MinimumSize = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim2.Name = "pictureBoxKucukResim2";
            this.pictureBoxKucukResim2.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxKucukResim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKucukResim2.TabIndex = 1;
            this.pictureBoxKucukResim2.TabStop = false;
            // 
            // pictureBoxMISLogo
            // 
            this.pictureBoxMISLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMISLogo.Image = global::MIS.Properties.Resources.login_logooo;
            this.pictureBoxMISLogo.Location = new System.Drawing.Point(101, 81);
            this.pictureBoxMISLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMISLogo.Name = "pictureBoxMISLogo";
            this.pictureBoxMISLogo.Size = new System.Drawing.Size(272, 137);
            this.pictureBoxMISLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMISLogo.TabIndex = 2;
            this.pictureBoxMISLogo.TabStop = false;
            this.pictureBoxMISLogo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // KullaniciNoGiris
            // 
            this.KullaniciNoGiris.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciNoGiris.Location = new System.Drawing.Point(144, 256);
            this.KullaniciNoGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KullaniciNoGiris.Name = "KullaniciNoGiris";
            this.KullaniciNoGiris.Size = new System.Drawing.Size(209, 25);
            this.KullaniciNoGiris.TabIndex = 3;
            this.KullaniciNoGiris.Text = "Çalışan ID";
            this.KullaniciNoGiris.TextChanged += new System.EventHandler(this.KullaniciNoGiris_TextChanged);
            // 
            // SifreGiris
            // 
            this.SifreGiris.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreGiris.Location = new System.Drawing.Point(144, 313);
            this.SifreGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SifreGiris.Name = "SifreGiris";
            this.SifreGiris.Size = new System.Drawing.Size(209, 25);
            this.SifreGiris.TabIndex = 4;
            this.SifreGiris.Text = "Şifre";
            this.SifreGiris.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(92, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 2);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(200)))), ((int)(((byte)(58)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(124, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giriş";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.BackColor = System.Drawing.Color.Transparent;
            this.linkGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkGithub.Location = new System.Drawing.Point(97, 407);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(184, 20);
            this.linkGithub.TabIndex = 7;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "Kaynak Kodu Görüntüle";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(200)))), ((int)(((byte)(58)))));
            this.btnKayıtOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayıtOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayıtOl.Font = new System.Drawing.Font("Arial Black", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.Location = new System.Drawing.Point(246, 365);
            this.btnKayıtOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(116, 40);
            this.btnKayıtOl.TabIndex = 8;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKayıtOl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKayıtOl.UseVisualStyleBackColor = false;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // FormGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::MIS.Properties.Resources.loginImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 618);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SifreGiris);
            this.Controls.Add(this.KullaniciNoGiris);
            this.Controls.Add(this.pictureBoxMISLogo);
            this.Controls.Add(this.pictureBoxKucukResim2);
            this.Controls.Add(this.pictureBoxKucukResim1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(499, 665);
            this.MinimumSize = new System.Drawing.Size(499, 665);
            this.Name = "FormGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucukResim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKucukResim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMISLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKucukResim1;
        private System.Windows.Forms.PictureBox pictureBoxKucukResim2;
        private System.Windows.Forms.PictureBox pictureBoxMISLogo;
        private System.Windows.Forms.TextBox KullaniciNoGiris;
        private System.Windows.Forms.TextBox SifreGiris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Button btnKayıtOl;
    }
}

