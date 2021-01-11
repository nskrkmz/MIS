
namespace MIS
{
    partial class FormVeresiyeMüşteriKayit
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
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lblIslemTrh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusAdSoy = new System.Windows.Forms.Label();
            this.txtIslemTarih = new System.Windows.Forms.TextBox();
            this.txtMusteriTelNo = new System.Windows.Forms.TextBox();
            this.txtMusAdSoy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(63, 279);
            this.btnKayitOl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(171, 48);
            this.btnKayitOl.TabIndex = 9;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // lblIslemTrh
            // 
            this.lblIslemTrh.AutoSize = true;
            this.lblIslemTrh.Location = new System.Drawing.Point(59, 201);
            this.lblIslemTrh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIslemTrh.Name = "lblIslemTrh";
            this.lblIslemTrh.Size = new System.Drawing.Size(80, 17);
            this.lblIslemTrh.TabIndex = 6;
            this.lblIslemTrh.Text = "İşlem Tarihi";
            this.lblIslemTrh.Click += new System.EventHandler(this.lblIslemTrh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon Numarasi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMusAdSoy
            // 
            this.lblMusAdSoy.AutoSize = true;
            this.lblMusAdSoy.Location = new System.Drawing.Point(59, 68);
            this.lblMusAdSoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusAdSoy.Name = "lblMusAdSoy";
            this.lblMusAdSoy.Size = new System.Drawing.Size(119, 17);
            this.lblMusAdSoy.TabIndex = 8;
            this.lblMusAdSoy.Text = "Müşteri Ad Soyad";
            this.lblMusAdSoy.Click += new System.EventHandler(this.lblMusAdSoy_Click);
            // 
            // txtIslemTarih
            // 
            this.txtIslemTarih.Location = new System.Drawing.Point(63, 223);
            this.txtIslemTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtIslemTarih.Name = "txtIslemTarih";
            this.txtIslemTarih.Size = new System.Drawing.Size(169, 22);
            this.txtIslemTarih.TabIndex = 3;
            this.txtIslemTarih.TextChanged += new System.EventHandler(this.txtIslemTarih_TextChanged);
            // 
            // txtMusteriTelNo
            // 
            this.txtMusteriTelNo.Location = new System.Drawing.Point(63, 154);
            this.txtMusteriTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriTelNo.Name = "txtMusteriTelNo";
            this.txtMusteriTelNo.Size = new System.Drawing.Size(169, 22);
            this.txtMusteriTelNo.TabIndex = 4;
            this.txtMusteriTelNo.TextChanged += new System.EventHandler(this.txtMusteriTelNo_TextChanged);
            // 
            // txtMusAdSoy
            // 
            this.txtMusAdSoy.Location = new System.Drawing.Point(63, 90);
            this.txtMusAdSoy.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusAdSoy.Name = "txtMusAdSoy";
            this.txtMusAdSoy.Size = new System.Drawing.Size(169, 22);
            this.txtMusAdSoy.TabIndex = 5;
            this.txtMusAdSoy.TextChanged += new System.EventHandler(this.txtMusAdSoy_TextChanged);
            // 
            // FormVeresiyeMüşteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 496);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.lblIslemTrh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMusAdSoy);
            this.Controls.Add(this.txtIslemTarih);
            this.Controls.Add(this.txtMusteriTelNo);
            this.Controls.Add(this.txtMusAdSoy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVeresiyeMüşteriKayit";
            this.Text = "FormVeresiyeMüşteriKayit";
            this.Load += new System.EventHandler(this.FormVeresiyeMüşteriKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Label lblIslemTrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusAdSoy;
        private System.Windows.Forms.TextBox txtIslemTarih;
        private System.Windows.Forms.TextBox txtMusteriTelNo;
        private System.Windows.Forms.TextBox txtMusAdSoy;
    }
}