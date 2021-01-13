
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
            this.txtBTotalBorc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veresiye Müşteri Listesi";
            // 
            // cbBorcluMustList
            // 
            this.cbBorcluMustList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbBorcluMustList.FormattingEnabled = true;
            this.cbBorcluMustList.Items.AddRange(new object[] {
            "18061256",
            "18061277",
            "18061263"});
            this.cbBorcluMustList.Location = new System.Drawing.Point(703, 58);
            this.cbBorcluMustList.Name = "cbBorcluMustList";
            this.cbBorcluMustList.Size = new System.Drawing.Size(231, 21);
            this.cbBorcluMustList.TabIndex = 1;
            // 
            // btnBorcSorgula
            // 
            this.btnBorcSorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorcSorgula.Font = new System.Drawing.Font("Arial", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBorcSorgula.Location = new System.Drawing.Point(703, 100);
            this.btnBorcSorgula.Name = "btnBorcSorgula";
            this.btnBorcSorgula.Size = new System.Drawing.Size(231, 40);
            this.btnBorcSorgula.TabIndex = 2;
            this.btnBorcSorgula.Text = "BORÇ SORGULA";
            this.btnBorcSorgula.UseVisualStyleBackColor = false;
            this.btnBorcSorgula.Click += new System.EventHandler(this.btnBorcSorgula_Click);
            // 
            // txtBTotalBorc
            // 
            this.txtBTotalBorc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBTotalBorc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBTotalBorc.Location = new System.Drawing.Point(703, 337);
            this.txtBTotalBorc.Name = "txtBTotalBorc";
            this.txtBTotalBorc.Size = new System.Drawing.Size(175, 27);
            this.txtBTotalBorc.TabIndex = 5;
            this.txtBTotalBorc.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(699, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL BORÇ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(699, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "ÖDEMEK İSTEDİĞİNİZ TUTAR";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(703, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(703, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 83);
            this.button1.TabIndex = 7;
            this.button1.Text = "ÖDEMEYİ GERÇEKLEŞTİR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(664, 599);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormBorcOdemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(957, 725);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBTotalBorc);
            this.Controls.Add(this.btnBorcSorgula);
            this.Controls.Add(this.cbBorcluMustList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBorcOdemeEkranı";
            this.Text = "FormBorcOdemeEkranı";
            this.Load += new System.EventHandler(this.FormBorcOdemeEkranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBorcluMustList;
        private System.Windows.Forms.Button btnBorcSorgula;
        private System.Windows.Forms.TextBox txtBTotalBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}