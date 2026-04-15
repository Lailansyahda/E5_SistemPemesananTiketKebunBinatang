namespace KebunBinatangADO.Forms
{
    partial class FormDashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardAdmin));
            this.btnKelolaTiket = new System.Windows.Forms.Button();
            this.btnDataBooking = new System.Windows.Forms.Button();
            this.lblDashAdmin = new System.Windows.Forms.Label();
            this.btnVerifikasi = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKelolaTiket
            // 
            this.btnKelolaTiket.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnKelolaTiket.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaTiket.ForeColor = System.Drawing.Color.White;
            this.btnKelolaTiket.Location = new System.Drawing.Point(52, 230);
            this.btnKelolaTiket.Name = "btnKelolaTiket";
            this.btnKelolaTiket.Size = new System.Drawing.Size(149, 86);
            this.btnKelolaTiket.TabIndex = 1;
            this.btnKelolaTiket.Text = "Kelola Tiket";
            this.btnKelolaTiket.UseVisualStyleBackColor = false;
            this.btnKelolaTiket.Click += new System.EventHandler(this.btnKelolaTiket_Click);
            // 
            // btnDataBooking
            // 
            this.btnDataBooking.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDataBooking.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataBooking.ForeColor = System.Drawing.Color.White;
            this.btnDataBooking.Location = new System.Drawing.Point(233, 230);
            this.btnDataBooking.Name = "btnDataBooking";
            this.btnDataBooking.Size = new System.Drawing.Size(152, 86);
            this.btnDataBooking.TabIndex = 2;
            this.btnDataBooking.Text = "Data Booking";
            this.btnDataBooking.UseVisualStyleBackColor = false;
            this.btnDataBooking.Click += new System.EventHandler(this.btnDataBook_Click);
            // 
            // lblDashAdmin
            // 
            this.lblDashAdmin.AutoSize = true;
            this.lblDashAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblDashAdmin.Font = new System.Drawing.Font("Geometr415 Blk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(51)))), ((int)(((byte)(34)))));
            this.lblDashAdmin.Location = new System.Drawing.Point(231, 173);
            this.lblDashAdmin.Name = "lblDashAdmin";
            this.lblDashAdmin.Size = new System.Drawing.Size(306, 32);
            this.lblDashAdmin.TabIndex = 0;
            this.lblDashAdmin.Text = "Selamat Datang Admin!";
            // 
            // btnVerifikasi
            // 
            this.btnVerifikasi.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVerifikasi.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifikasi.ForeColor = System.Drawing.Color.White;
            this.btnVerifikasi.Location = new System.Drawing.Point(420, 230);
            this.btnVerifikasi.Name = "btnVerifikasi";
            this.btnVerifikasi.Size = new System.Drawing.Size(145, 86);
            this.btnVerifikasi.TabIndex = 3;
            this.btnVerifikasi.Text = "Verifikasi";
            this.btnVerifikasi.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(219, -20);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(328, 190);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLaporan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(593, 230);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(152, 86);
            this.btnLaporan.TabIndex = 5;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Chocolate;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(683, 399);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 38);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnVerifikasi);
            this.Controls.Add(this.lblDashAdmin);
            this.Controls.Add(this.btnDataBooking);
            this.Controls.Add(this.btnKelolaTiket);
            this.Name = "FormDashboardAdmin";
            this.Text = "FormDashboardAdmin";
            this.Click += new System.EventHandler(this.btnVerfikasi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKelolaTiket;
        private System.Windows.Forms.Button btnDataBooking;
        private System.Windows.Forms.Label lblDashAdmin;
        private System.Windows.Forms.Button btnVerifikasi;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLogout;
    }
}