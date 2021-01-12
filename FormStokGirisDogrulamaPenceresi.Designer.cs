namespace MIS
{
    partial class FormStokGirisDogrulamaPenceresi
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDGiris = new System.Windows.Forms.TextBox();
            this.textBoxSifreGiris = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre Giriş";
            // 
            // textBoxIDGiris
            // 
            this.textBoxIDGiris.Location = new System.Drawing.Point(178, 39);
            this.textBoxIDGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIDGiris.Name = "textBoxIDGiris";
            this.textBoxIDGiris.Size = new System.Drawing.Size(116, 20);
            this.textBoxIDGiris.TabIndex = 2;
            // 
            // textBoxSifreGiris
            // 
            this.textBoxSifreGiris.Location = new System.Drawing.Point(178, 76);
            this.textBoxSifreGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSifreGiris.Name = "textBoxSifreGiris";
            this.textBoxSifreGiris.Size = new System.Drawing.Size(116, 20);
            this.textBoxSifreGiris.TabIndex = 3;
            // 
            // FormStokGirisDogrulamaPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(305, 177);
            this.Controls.Add(this.textBoxSifreGiris);
            this.Controls.Add(this.textBoxIDGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(305, 177);
            this.MinimumSize = new System.Drawing.Size(305, 177);
            this.Name = "FormStokGirisDogrulamaPenceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStokGirisDogrulamaPenceresi";
            this.Load += new System.EventHandler(this.FormStokGirisDogrulamaPenceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDGiris;
        private System.Windows.Forms.TextBox textBoxSifreGiris;
    }
}