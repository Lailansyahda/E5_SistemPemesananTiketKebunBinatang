namespace KebunBinatangADO.Forms
{
    partial class FormLoginPengunjung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginPengunjung));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLoginPengunjung = new System.Windows.Forms.Label();
            this.lblKebunBinatang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernamePengunjung = new System.Windows.Forms.TextBox();
            this.txtPasswordPengunjung = new System.Windows.Forms.TextBox();
            this.btnLoginPengunjung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(161, -45);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(468, 285);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblLoginPengunjung
            // 
            this.lblLoginPengunjung.AutoSize = true;
            this.lblLoginPengunjung.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPengunjung.Location = new System.Drawing.Point(323, 250);
            this.lblLoginPengunjung.Name = "lblLoginPengunjung";
            this.lblLoginPengunjung.Size = new System.Drawing.Size(154, 19);
            this.lblLoginPengunjung.TabIndex = 2;
            this.lblLoginPengunjung.Text = "Login Pengunjung";
            // 
            // lblKebunBinatang
            // 
            this.lblKebunBinatang.AutoSize = true;
            this.lblKebunBinatang.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKebunBinatang.Location = new System.Drawing.Point(284, 204);
            this.lblKebunBinatang.Name = "lblKebunBinatang";
            this.lblKebunBinatang.Size = new System.Drawing.Size(241, 27);
            this.lblKebunBinatang.TabIndex = 3;
            this.lblKebunBinatang.Text = "KEBUN BINATANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password :";
            // 
            // txtUsernamePengunjung
            // 
            this.txtUsernamePengunjung.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernamePengunjung.Location = new System.Drawing.Point(313, 296);
            this.txtUsernamePengunjung.Name = "txtUsernamePengunjung";
            this.txtUsernamePengunjung.Size = new System.Drawing.Size(231, 23);
            this.txtUsernamePengunjung.TabIndex = 6;
            // 
            // txtPasswordPengunjung
            // 
            this.txtPasswordPengunjung.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordPengunjung.Location = new System.Drawing.Point(313, 347);
            this.txtPasswordPengunjung.Name = "txtPasswordPengunjung";
            this.txtPasswordPengunjung.Size = new System.Drawing.Size(231, 23);
            this.txtPasswordPengunjung.TabIndex = 7;
            // 
            // btnLoginPengunjung
            // 
            this.btnLoginPengunjung.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPengunjung.Location = new System.Drawing.Point(362, 397);
            this.btnLoginPengunjung.Name = "btnLoginPengunjung";
            this.btnLoginPengunjung.Size = new System.Drawing.Size(75, 23);
            this.btnLoginPengunjung.TabIndex = 8;
            this.btnLoginPengunjung.Text = "LOGIN";
            this.btnLoginPengunjung.UseVisualStyleBackColor = true;
            this.btnLoginPengunjung.Click += new System.EventHandler(this.btnLoginPengunjung_Click);
            // 
            // FormLoginPengunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginPengunjung);
            this.Controls.Add(this.txtPasswordPengunjung);
            this.Controls.Add(this.txtUsernamePengunjung);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKebunBinatang);
            this.Controls.Add(this.lblLoginPengunjung);
            this.Controls.Add(this.picLogo);
            this.Name = "FormLoginPengunjung";
            this.Text = "FormLoginPengunjung";
            this.Load += new System.EventHandler(this.FormLoginPengunjung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLoginPengunjung;
        private System.Windows.Forms.Label lblKebunBinatang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernamePengunjung;
        private System.Windows.Forms.TextBox txtPasswordPengunjung;
        private System.Windows.Forms.Button btnLoginPengunjung;
    }
}