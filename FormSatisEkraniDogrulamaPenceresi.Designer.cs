
namespace MIS
{
    partial class FormSatisEkraniDogrulamaPenceresi
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
            this.Giriş = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.KullanıcıNo = new System.Windows.Forms.TextBox();
            this.Şifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Giriş
            // 
            this.Giriş.BackColor = System.Drawing.Color.White;
            this.Giriş.Location = new System.Drawing.Point(163, 160);
            this.Giriş.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Giriş.Name = "Giriş";
            this.Giriş.Size = new System.Drawing.Size(100, 28);
            this.Giriş.TabIndex = 0;
            this.Giriş.Text = "Giriş";
            this.Giriş.UseVisualStyleBackColor = false;
            this.Giriş.Click += new System.EventHandler(this.Giriş_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MIS.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(29, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MIS.Properties.Resources.password_Image;
            this.pictureBox2.Location = new System.Drawing.Point(29, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KullanıcıNo
            // 
            this.KullanıcıNo.Location = new System.Drawing.Point(121, 28);
            this.KullanıcıNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KullanıcıNo.Name = "KullanıcıNo";
            this.KullanıcıNo.Size = new System.Drawing.Size(187, 22);
            this.KullanıcıNo.TabIndex = 2;
            this.KullanıcıNo.Text = "Kullanıcı No";
            // 
            // Şifre
            // 
            this.Şifre.Location = new System.Drawing.Point(121, 108);
            this.Şifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(187, 22);
            this.Şifre.TabIndex = 2;
            this.Şifre.Text = "Şifre";
            // 
            // FormSatisEkraniDogrulamaPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(364, 219);
            this.Controls.Add(this.Şifre);
            this.Controls.Add(this.KullanıcıNo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Giriş);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSatisEkraniDogrulamaPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSatisEkraniDogrulamaPenceresi";
            this.Load += new System.EventHandler(this.FormSatisEkraniDogrulamaPenceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Giriş;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox KullanıcıNo;
        private System.Windows.Forms.TextBox Şifre;
    }
}