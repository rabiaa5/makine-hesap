namespace basit_hesap_makinesi
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSayi1.Location = new System.Drawing.Point(41, 72);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(134, 30);
            this.txtSayi1.TabIndex = 1;
            // 
            // txtSayi2
            // 
            this.txtSayi2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSayi2.Location = new System.Drawing.Point(206, 72);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(134, 30);
            this.txtSayi2.TabIndex = 2;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(44, 124);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(117, 39);
            this.lblsonuc.TabIndex = 2;
            this.lblsonuc.Text = "sonuc:";
            // 
            // btnCarp
            // 
            this.btnCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarp.Location = new System.Drawing.Point(51, 182);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(106, 73);
            this.btnCarp.TabIndex = 3;
            this.btnCarp.Text = "*";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBol.Location = new System.Drawing.Point(206, 182);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(111, 76);
            this.btnBol.TabIndex = 4;
            this.btnBol.Text = "/";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkar.Location = new System.Drawing.Point(206, 283);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(111, 73);
            this.btnCıkar.TabIndex = 5;
            this.btnCıkar.Text = "-";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.Location = new System.Drawing.Point(51, 283);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(106, 73);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 399);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnTopla;
    }
}

