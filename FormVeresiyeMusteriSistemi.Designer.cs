﻿
namespace MIS
{
    partial class FormVeresiyeMusteriSistemi
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
            this.VeresiyeListesiCb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veresiye Müşteri Listesi";
            // 
            // VeresiyeListesiCb
            // 
            this.VeresiyeListesiCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VeresiyeListesiCb.Font = new System.Drawing.Font("Arial", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeresiyeListesiCb.FormattingEnabled = true;
            this.VeresiyeListesiCb.Items.AddRange(new object[] {
            "+Enes DÖVEÇ",
            "+Enes KORKMAZ",
            "+Baran EFE",
            "+Batuhan TUNÇ"});
            this.VeresiyeListesiCb.Location = new System.Drawing.Point(5, 37);
            this.VeresiyeListesiCb.Name = "VeresiyeListesiCb";
            this.VeresiyeListesiCb.Size = new System.Drawing.Size(225, 32);
            this.VeresiyeListesiCb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(5, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Veresiye Müşteri Kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormVeresiyeMusteriSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VeresiyeListesiCb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeresiyeMusteriSistemi";
            this.Text = "FormVeresiyeMusteriSistemi";
            this.Load += new System.EventHandler(this.FormVeresiyeMusteriSistemi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VeresiyeListesiCb;
        private System.Windows.Forms.Button button1;
    }
}