namespace Ödev21_12
{
    partial class Form2
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
            this.btnDukkanIslemleri = new System.Windows.Forms.Button();
            this.btnSatisIslemleri = new System.Windows.Forms.Button();
            this.btnOnceki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDukkanIslemleri
            // 
            this.btnDukkanIslemleri.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDukkanIslemleri.Location = new System.Drawing.Point(187, 116);
            this.btnDukkanIslemleri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDukkanIslemleri.Name = "btnDukkanIslemleri";
            this.btnDukkanIslemleri.Size = new System.Drawing.Size(135, 64);
            this.btnDukkanIslemleri.TabIndex = 11;
            this.btnDukkanIslemleri.Text = "Dükkan İşlemleri";
            this.btnDukkanIslemleri.UseVisualStyleBackColor = true;
            this.btnDukkanIslemleri.Click += new System.EventHandler(this.btnDukkanIslemleri_Click);
            // 
            // btnSatisIslemleri
            // 
            this.btnSatisIslemleri.Font = new System.Drawing.Font("Garamond", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisIslemleri.Location = new System.Drawing.Point(56, 116);
            this.btnSatisIslemleri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSatisIslemleri.Name = "btnSatisIslemleri";
            this.btnSatisIslemleri.Size = new System.Drawing.Size(120, 64);
            this.btnSatisIslemleri.TabIndex = 10;
            this.btnSatisIslemleri.Text = "Satış İşlemleri";
            this.btnSatisIslemleri.UseVisualStyleBackColor = true;
            this.btnSatisIslemleri.Click += new System.EventHandler(this.btnSatisIslemleri_Click);
            // 
            // btnOnceki
            // 
            this.btnOnceki.Location = new System.Drawing.Point(56, 188);
            this.btnOnceki.Name = "btnOnceki";
            this.btnOnceki.Size = new System.Drawing.Size(120, 43);
            this.btnOnceki.TabIndex = 12;
            this.btnOnceki.Text = "Önceki Sayfa";
            this.btnOnceki.UseVisualStyleBackColor = true;
            this.btnOnceki.Click += new System.EventHandler(this.btnOnceki_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.btnOnceki);
            this.Controls.Add(this.btnDukkanIslemleri);
            this.Controls.Add(this.btnSatisIslemleri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "İŞLEM SEÇİNİZ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDukkanIslemleri;
        private System.Windows.Forms.Button btnSatisIslemleri;
        private System.Windows.Forms.Button btnOnceki;
    }
}