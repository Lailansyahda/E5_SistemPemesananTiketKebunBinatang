namespace KebunBinatangADO.Forms
{
    partial class FormRegisterPengunjung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterPengunjung));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblKebunBinatang = new System.Windows.Forms.Label();
            this.lblRegistrasi = new System.Windows.Forms.Label();
            this.lblUsernameRegis = new System.Windows.Forms.Label();
            this.lblEmailRegis = new System.Windows.Forms.Label();
            this.lblPasswordRegis = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserRegis = new System.Windows.Forms.TextBox();
            this.txtPassRegis = new System.Windows.Forms.TextBox();
            this.btnRegis = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSudahPunyaAkun = new System.Windows.Forms.Label();
            this.btnLoginRegis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(173, -59);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(446, 260);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblKebunBinatang
            // 
            this.lblKebunBinatang.AutoSize = true;
            this.lblKebunBinatang.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKebunBinatang.Location = new System.Drawing.Point(286, 174);
            this.lblKebunBinatang.Name = "lblKebunBinatang";
            this.lblKebunBinatang.Size = new System.Drawing.Size(241, 27);
            this.lblKebunBinatang.TabIndex = 4;
            this.lblKebunBinatang.Text = "KEBUN BINATANG";
            // 
            // lblRegistrasi
            // 
            this.lblRegistrasi.AutoSize = true;
            this.lblRegistrasi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrasi.Location = new System.Drawing.Point(309, 226);
            this.lblRegistrasi.Name = "lblRegistrasi";
            this.lblRegistrasi.Size = new System.Drawing.Size(190, 19);
            this.lblRegistrasi.TabIndex = 5;
            this.lblRegistrasi.Text = "Registrasi Pengunjung";
            // 
            // lblUsernameRegis
            // 
            this.lblUsernameRegis.AutoSize = true;
            this.lblUsernameRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameRegis.Location = new System.Drawing.Point(211, 315);
            this.lblUsernameRegis.Name = "lblUsernameRegis";
            this.lblUsernameRegis.Size = new System.Drawing.Size(80, 15);
            this.lblUsernameRegis.TabIndex = 6;
            this.lblUsernameRegis.Text = "Username :";
            // 
            // lblEmailRegis
            // 
            this.lblEmailRegis.AutoSize = true;
            this.lblEmailRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegis.Location = new System.Drawing.Point(211, 281);
            this.lblEmailRegis.Name = "lblEmailRegis";
            this.lblEmailRegis.Size = new System.Drawing.Size(55, 15);
            this.lblEmailRegis.TabIndex = 7;
            this.lblEmailRegis.Text = "Email :";
            // 
            // lblPasswordRegis
            // 
            this.lblPasswordRegis.AutoSize = true;
            this.lblPasswordRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRegis.Location = new System.Drawing.Point(211, 350);
            this.lblPasswordRegis.Name = "lblPasswordRegis";
            this.lblPasswordRegis.Size = new System.Drawing.Size(81, 15);
            this.lblPasswordRegis.TabIndex = 8;
            this.lblPasswordRegis.Text = "Password : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(307, 279);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtUserRegis
            // 
            this.txtUserRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRegis.Location = new System.Drawing.Point(307, 315);
            this.txtUserRegis.Name = "txtUserRegis";
            this.txtUserRegis.Size = new System.Drawing.Size(213, 23);
            this.txtUserRegis.TabIndex = 10;
            // 
            // txtPassRegis
            // 
            this.txtPassRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassRegis.Location = new System.Drawing.Point(307, 350);
            this.txtPassRegis.Name = "txtPassRegis";
            this.txtPassRegis.Size = new System.Drawing.Size(213, 23);
            this.txtPassRegis.TabIndex = 11;
            // 
            // btnRegis
            // 
            this.btnRegis.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.Location = new System.Drawing.Point(335, 391);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(128, 23);
            this.btnRegis.TabIndex = 12;
            this.btnRegis.Text = "REGISTRASI";
            this.btnRegis.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSudahPunyaAkun
            // 
            this.lblSudahPunyaAkun.AutoSize = true;
            this.lblSudahPunyaAkun.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSudahPunyaAkun.Location = new System.Drawing.Point(598, 428);
            this.lblSudahPunyaAkun.Name = "lblSudahPunyaAkun";
            this.lblSudahPunyaAkun.Size = new System.Drawing.Size(120, 16);
            this.lblSudahPunyaAkun.TabIndex = 13;
            this.lblSudahPunyaAkun.Text = "Sudah Punya Akun?";
            // 
            // btnLoginRegis
            // 
            this.btnLoginRegis.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegis.Location = new System.Drawing.Point(721, 422);
            this.btnLoginRegis.Name = "btnLoginRegis";
            this.btnLoginRegis.Size = new System.Drawing.Size(68, 26);
            this.btnLoginRegis.TabIndex = 14;
            this.btnLoginRegis.Text = "Login";
            this.btnLoginRegis.UseVisualStyleBackColor = true;
            // 
            // FormRegisterPengunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginRegis);
            this.Controls.Add(this.lblSudahPunyaAkun);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtPassRegis);
            this.Controls.Add(this.txtUserRegis);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPasswordRegis);
            this.Controls.Add(this.lblEmailRegis);
            this.Controls.Add(this.lblUsernameRegis);
            this.Controls.Add(this.lblRegistrasi);
            this.Controls.Add(this.lblKebunBinatang);
            this.Controls.Add(this.picLogo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormRegisterPengunjung";
            this.Text = "FormRegisterPengunjung";
            this.Click += new System.EventHandler(this.btnRegis_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblKebunBinatang;
        private System.Windows.Forms.Label lblRegistrasi;
        private System.Windows.Forms.Label lblUsernameRegis;
        private System.Windows.Forms.Label lblEmailRegis;
        private System.Windows.Forms.Label lblPasswordRegis;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserRegis;
        private System.Windows.Forms.TextBox txtPassRegis;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSudahPunyaAkun;
        private System.Windows.Forms.Button btnLoginRegis;
    }
}