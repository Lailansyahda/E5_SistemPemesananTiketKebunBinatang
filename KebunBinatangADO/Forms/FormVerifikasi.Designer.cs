namespace KebunBinatangADO.Forms
{
    partial class FormVerifikasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerifikasi));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPilihTanggalVerif = new System.Windows.Forms.Label();
            this.txtCariKode = new System.Windows.Forms.TextBox();
            this.btnTampildata = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVerifikasi = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifikasi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verifikasi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblPilihTanggalVerif
            // 
            this.lblPilihTanggalVerif.AutoSize = true;
            this.lblPilihTanggalVerif.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPilihTanggalVerif.ForeColor = System.Drawing.Color.White;
            this.lblPilihTanggalVerif.Location = new System.Drawing.Point(75, 113);
            this.lblPilihTanggalVerif.Name = "lblPilihTanggalVerif";
            this.lblPilihTanggalVerif.Size = new System.Drawing.Size(134, 15);
            this.lblPilihTanggalVerif.TabIndex = 17;
            this.lblPilihTanggalVerif.Text = "Cari Kode Booking :";
            // 
            // txtCariKode
            // 
            this.txtCariKode.Location = new System.Drawing.Point(215, 111);
            this.txtCariKode.Name = "txtCariKode";
            this.txtCariKode.Size = new System.Drawing.Size(249, 20);
            this.txtCariKode.TabIndex = 18;
            // 
            // btnTampildata
            // 
            this.btnTampildata.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTampildata.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampildata.ForeColor = System.Drawing.Color.White;
            this.btnTampildata.Location = new System.Drawing.Point(488, 101);
            this.btnTampildata.Name = "btnTampildata";
            this.btnTampildata.Size = new System.Drawing.Size(112, 38);
            this.btnTampildata.TabIndex = 19;
            this.btnTampildata.Text = "Tampilkan Data";
            this.btnTampildata.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(619, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Verifikasi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvVerifikasi
            // 
            this.dgvVerifikasi.AllowUserToAddRows = false;
            this.dgvVerifikasi.AllowUserToDeleteRows = false;
            this.dgvVerifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerifikasi.Location = new System.Drawing.Point(78, 179);
            this.dgvVerifikasi.Name = "dgvVerifikasi";
            this.dgvVerifikasi.ReadOnly = true;
            this.dgvVerifikasi.Size = new System.Drawing.Size(660, 150);
            this.dgvVerifikasi.TabIndex = 22;
            this.dgvVerifikasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVerifikasi_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(693, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvVerifikasi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTampildata);
            this.Controls.Add(this.txtCariKode);
            this.Controls.Add(this.lblPilihTanggalVerif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormVerifikasi";
            this.Text = "FormVerifikasi";
            this.Load += new System.EventHandler(this.btnLoadData_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifikasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPilihTanggalVerif;
        private System.Windows.Forms.TextBox txtCariKode;
        private System.Windows.Forms.Button btnTampildata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvVerifikasi;
        private System.Windows.Forms.Button btnBack;
    }
}