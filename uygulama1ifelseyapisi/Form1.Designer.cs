namespace uygulama1ifelseyapisi
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
            this.btnTikla = new System.Windows.Forms.Button();
            this.lblYaz = new System.Windows.Forms.Label();
            this.cbMavi = new System.Windows.Forms.RadioButton();
            this.cbSari = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnTikla
            // 
            this.btnTikla.Location = new System.Drawing.Point(25, 40);
            this.btnTikla.Name = "btnTikla";
            this.btnTikla.Size = new System.Drawing.Size(138, 44);
            this.btnTikla.TabIndex = 0;
            this.btnTikla.Text = "tıkla";
            this.btnTikla.UseVisualStyleBackColor = true;
            this.btnTikla.Click += new System.EventHandler(this.btnTikla_Click);
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.Location = new System.Drawing.Point(26, 98);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(46, 25);
            this.lblYaz.TabIndex = 1;
            this.lblYaz.Text = "yaz";
            // 
            // cbMavi
            // 
            this.cbMavi.AutoSize = true;
            this.cbMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMavi.Location = new System.Drawing.Point(25, 150);
            this.cbMavi.Name = "cbMavi";
            this.cbMavi.Size = new System.Drawing.Size(75, 29);
            this.cbMavi.TabIndex = 2;
            this.cbMavi.TabStop = true;
            this.cbMavi.Text = "mavi";
            this.cbMavi.UseVisualStyleBackColor = true;
            // 
            // cbSari
            // 
            this.cbSari.AutoSize = true;
            this.cbSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSari.Location = new System.Drawing.Point(25, 197);
            this.cbSari.Name = "cbSari";
            this.cbSari.Size = new System.Drawing.Size(65, 29);
            this.cbSari.TabIndex = 3;
            this.cbSari.TabStop = true;
            this.cbSari.Text = "sari";
            this.cbSari.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSari);
            this.Controls.Add(this.cbMavi);
            this.Controls.Add(this.lblYaz);
            this.Controls.Add(this.btnTikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTikla;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.RadioButton cbMavi;
        private System.Windows.Forms.RadioButton cbSari;
    }
}

