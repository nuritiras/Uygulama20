namespace Uygulama20
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.textNumara = new System.Windows.Forms.TextBox();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.textAlan = new System.Windows.Forms.TextBox();
            this.buttonBagla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alan";
            // 
            // textNumara
            // 
            this.textNumara.Location = new System.Drawing.Point(106, 20);
            this.textNumara.Name = "textNumara";
            this.textNumara.Size = new System.Drawing.Size(143, 20);
            this.textNumara.TabIndex = 3;
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(106, 46);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(143, 20);
            this.textAdSoyad.TabIndex = 4;
            // 
            // textAlan
            // 
            this.textAlan.Location = new System.Drawing.Point(106, 74);
            this.textAlan.Name = "textAlan";
            this.textAlan.Size = new System.Drawing.Size(143, 20);
            this.textAlan.TabIndex = 5;
            // 
            // buttonBagla
            // 
            this.buttonBagla.Location = new System.Drawing.Point(292, 48);
            this.buttonBagla.Name = "buttonBagla";
            this.buttonBagla.Size = new System.Drawing.Size(75, 23);
            this.buttonBagla.TabIndex = 6;
            this.buttonBagla.Text = "Veri Bağla";
            this.buttonBagla.UseVisualStyleBackColor = true;
            this.buttonBagla.Click += new System.EventHandler(this.buttonBagla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 127);
            this.Controls.Add(this.buttonBagla);
            this.Controls.Add(this.textAlan);
            this.Controls.Add(this.textAdSoyad);
            this.Controls.Add(this.textNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumara;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.TextBox textAlan;
        private System.Windows.Forms.Button buttonBagla;
    }
}

