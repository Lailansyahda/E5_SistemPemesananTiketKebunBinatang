namespace KebunBinatangADO.Forms
{
    partial class FormBookingPengunjung
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpBoxDataTiket = new System.Windows.Forms.GroupBox();
            this.lblHargatktAnak = new System.Windows.Forms.Label();
            this.lblHargatktPelajar = new System.Windows.Forms.Label();
            this.lblHargatktDewasa = new System.Windows.Forms.Label();
            this.txtSisaKuota = new System.Windows.Forms.TextBox();
            this.btnPesan = new System.Windows.Forms.Button();
            this.lblSisaKuota = new System.Windows.Forms.Label();
            this.lblTiketAnak = new System.Windows.Forms.Label();
            this.lblTiketPelajar = new System.Windows.Forms.Label();
            this.numTiketAnak = new System.Windows.Forms.NumericUpDown();
            this.numTiketPelajar = new System.Windows.Forms.NumericUpDown();
            this.numTiketDewasa = new System.Windows.Forms.NumericUpDown();
            this.lblTiketDewasa = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.grpBoxRingkasan = new System.Windows.Forms.GroupBox();
            this.txtTanggalKunjungan = new System.Windows.Forms.TextBox();
            this.txtStatusPembayaran = new System.Windows.Forms.TextBox();
            this.txtKodeBook = new System.Windows.Forms.TextBox();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTanggalKunjungan = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKodeBooking = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpBoxDataTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketAnak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketPelajar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketDewasa)).BeginInit();
            this.grpBoxRingkasan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(13, 200);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(54, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama :";
            // 
            // lblNoHp
            // 
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Location = new System.Drawing.Point(12, 236);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.Size = new System.Drawing.Size(54, 15);
            this.lblNoHp.TabIndex = 1;
            this.lblNoHp.Text = "No HP :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 277);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(80, 200);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(284, 23);
            this.txtNama.TabIndex = 3;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(80, 236);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(284, 23);
            this.txtNoHP.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // grpBoxDataTiket
            // 
            this.grpBoxDataTiket.BackColor = System.Drawing.Color.SaddleBrown;
            this.grpBoxDataTiket.Controls.Add(this.lblHargatktAnak);
            this.grpBoxDataTiket.Controls.Add(this.lblHargatktPelajar);
            this.grpBoxDataTiket.Controls.Add(this.lblHargatktDewasa);
            this.grpBoxDataTiket.Controls.Add(this.txtSisaKuota);
            this.grpBoxDataTiket.Controls.Add(this.btnPesan);
            this.grpBoxDataTiket.Controls.Add(this.txtEmail);
            this.grpBoxDataTiket.Controls.Add(this.lblSisaKuota);
            this.grpBoxDataTiket.Controls.Add(this.lblEmail);
            this.grpBoxDataTiket.Controls.Add(this.txtNoHP);
            this.grpBoxDataTiket.Controls.Add(this.lblTiketAnak);
            this.grpBoxDataTiket.Controls.Add(this.txtNama);
            this.grpBoxDataTiket.Controls.Add(this.lblNoHp);
            this.grpBoxDataTiket.Controls.Add(this.lblTiketPelajar);
            this.grpBoxDataTiket.Controls.Add(this.numTiketAnak);
            this.grpBoxDataTiket.Controls.Add(this.numTiketPelajar);
            this.grpBoxDataTiket.Controls.Add(this.lblNama);
            this.grpBoxDataTiket.Controls.Add(this.numTiketDewasa);
            this.grpBoxDataTiket.Controls.Add(this.lblTiketDewasa);
            this.grpBoxDataTiket.Controls.Add(this.dateTimePicker1);
            this.grpBoxDataTiket.Controls.Add(this.lblTanggal);
            this.grpBoxDataTiket.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDataTiket.ForeColor = System.Drawing.Color.White;
            this.grpBoxDataTiket.Location = new System.Drawing.Point(28, 12);
            this.grpBoxDataTiket.Name = "grpBoxDataTiket";
            this.grpBoxDataTiket.Size = new System.Drawing.Size(742, 316);
            this.grpBoxDataTiket.TabIndex = 1;
            this.grpBoxDataTiket.TabStop = false;
            this.grpBoxDataTiket.Text = "Data Tiket";
            // 
            // lblHargatktAnak
            // 
            this.lblHargatktAnak.AutoSize = true;
            this.lblHargatktAnak.Location = new System.Drawing.Point(279, 159);
            this.lblHargatktAnak.Name = "lblHargatktAnak";
            this.lblHargatktAnak.Size = new System.Drawing.Size(132, 15);
            this.lblHargatktAnak.TabIndex = 13;
            this.lblHargatktAnak.Text = "Rp. 30.000,- /Orang";
            // 
            // lblHargatktPelajar
            // 
            this.lblHargatktPelajar.AutoSize = true;
            this.lblHargatktPelajar.Location = new System.Drawing.Point(279, 126);
            this.lblHargatktPelajar.Name = "lblHargatktPelajar";
            this.lblHargatktPelajar.Size = new System.Drawing.Size(132, 15);
            this.lblHargatktPelajar.TabIndex = 12;
            this.lblHargatktPelajar.Text = "Rp. 50.000,- /Orang";
            // 
            // lblHargatktDewasa
            // 
            this.lblHargatktDewasa.AutoSize = true;
            this.lblHargatktDewasa.Location = new System.Drawing.Point(278, 92);
            this.lblHargatktDewasa.Name = "lblHargatktDewasa";
            this.lblHargatktDewasa.Size = new System.Drawing.Size(132, 15);
            this.lblHargatktDewasa.TabIndex = 11;
            this.lblHargatktDewasa.Text = "Rp. 70.000,- /Orang";
            // 
            // txtSisaKuota
            // 
            this.txtSisaKuota.Location = new System.Drawing.Point(123, 55);
            this.txtSisaKuota.Name = "txtSisaKuota";
            this.txtSisaKuota.Size = new System.Drawing.Size(100, 23);
            this.txtSisaKuota.TabIndex = 10;
            // 
            // btnPesan
            // 
            this.btnPesan.BackColor = System.Drawing.Color.Chocolate;
            this.btnPesan.Location = new System.Drawing.Point(580, 268);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(146, 34);
            this.btnPesan.TabIndex = 9;
            this.btnPesan.Text = "Pesan Tiket";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // lblSisaKuota
            // 
            this.lblSisaKuota.AutoSize = true;
            this.lblSisaKuota.Location = new System.Drawing.Point(9, 55);
            this.lblSisaKuota.Name = "lblSisaKuota";
            this.lblSisaKuota.Size = new System.Drawing.Size(83, 15);
            this.lblSisaKuota.TabIndex = 8;
            this.lblSisaKuota.Text = "Sisa Kuota :";
            // 
            // lblTiketAnak
            // 
            this.lblTiketAnak.AutoSize = true;
            this.lblTiketAnak.Location = new System.Drawing.Point(13, 157);
            this.lblTiketAnak.Name = "lblTiketAnak";
            this.lblTiketAnak.Size = new System.Drawing.Size(88, 15);
            this.lblTiketAnak.TabIndex = 7;
            this.lblTiketAnak.Text = "Tiket Anak : ";
            // 
            // lblTiketPelajar
            // 
            this.lblTiketPelajar.AutoSize = true;
            this.lblTiketPelajar.Location = new System.Drawing.Point(12, 125);
            this.lblTiketPelajar.Name = "lblTiketPelajar";
            this.lblTiketPelajar.Size = new System.Drawing.Size(103, 15);
            this.lblTiketPelajar.TabIndex = 6;
            this.lblTiketPelajar.Text = "Tiket Pelajar : ";
            // 
            // numTiketAnak
            // 
            this.numTiketAnak.Location = new System.Drawing.Point(123, 154);
            this.numTiketAnak.Name = "numTiketAnak";
            this.numTiketAnak.Size = new System.Drawing.Size(120, 23);
            this.numTiketAnak.TabIndex = 5;
            // 
            // numTiketPelajar
            // 
            this.numTiketPelajar.Location = new System.Drawing.Point(123, 122);
            this.numTiketPelajar.Name = "numTiketPelajar";
            this.numTiketPelajar.Size = new System.Drawing.Size(120, 23);
            this.numTiketPelajar.TabIndex = 4;
            // 
            // numTiketDewasa
            // 
            this.numTiketDewasa.Location = new System.Drawing.Point(123, 89);
            this.numTiketDewasa.Name = "numTiketDewasa";
            this.numTiketDewasa.Size = new System.Drawing.Size(120, 23);
            this.numTiketDewasa.TabIndex = 3;
            // 
            // lblTiketDewasa
            // 
            this.lblTiketDewasa.AutoSize = true;
            this.lblTiketDewasa.Location = new System.Drawing.Point(8, 95);
            this.lblTiketDewasa.Name = "lblTiketDewasa";
            this.lblTiketDewasa.Size = new System.Drawing.Size(109, 15);
            this.lblTiketDewasa.TabIndex = 2;
            this.lblTiketDewasa.Text = " Tiket Dewasa : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(6, 23);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(104, 15);
            this.lblTanggal.TabIndex = 0;
            this.lblTanggal.Text = "Pilih Tanggal :";
            // 
            // grpBoxRingkasan
            // 
            this.grpBoxRingkasan.BackColor = System.Drawing.Color.Chocolate;
            this.grpBoxRingkasan.Controls.Add(this.btnLogout);
            this.grpBoxRingkasan.Controls.Add(this.txtTanggalKunjungan);
            this.grpBoxRingkasan.Controls.Add(this.txtStatusPembayaran);
            this.grpBoxRingkasan.Controls.Add(this.txtKodeBook);
            this.grpBoxRingkasan.Controls.Add(this.txtTotalHarga);
            this.grpBoxRingkasan.Controls.Add(this.txtTotal);
            this.grpBoxRingkasan.Controls.Add(this.lblTanggalKunjungan);
            this.grpBoxRingkasan.Controls.Add(this.lblStatus);
            this.grpBoxRingkasan.Controls.Add(this.lblKodeBooking);
            this.grpBoxRingkasan.Controls.Add(this.lblTotalHarga);
            this.grpBoxRingkasan.Controls.Add(this.lblDetail);
            this.grpBoxRingkasan.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxRingkasan.ForeColor = System.Drawing.Color.White;
            this.grpBoxRingkasan.Location = new System.Drawing.Point(28, 341);
            this.grpBoxRingkasan.Name = "grpBoxRingkasan";
            this.grpBoxRingkasan.Size = new System.Drawing.Size(742, 175);
            this.grpBoxRingkasan.TabIndex = 2;
            this.grpBoxRingkasan.TabStop = false;
            this.grpBoxRingkasan.Text = "Ringkasan Pemesanan";
            // 
            // txtTanggalKunjungan
            // 
            this.txtTanggalKunjungan.Location = new System.Drawing.Point(520, 104);
            this.txtTanggalKunjungan.Name = "txtTanggalKunjungan";
            this.txtTanggalKunjungan.Size = new System.Drawing.Size(206, 23);
            this.txtTanggalKunjungan.TabIndex = 9;
            // 
            // txtStatusPembayaran
            // 
            this.txtStatusPembayaran.Location = new System.Drawing.Point(520, 66);
            this.txtStatusPembayaran.Name = "txtStatusPembayaran";
            this.txtStatusPembayaran.Size = new System.Drawing.Size(206, 23);
            this.txtStatusPembayaran.TabIndex = 8;
            // 
            // txtKodeBook
            // 
            this.txtKodeBook.Location = new System.Drawing.Point(520, 30);
            this.txtKodeBook.Name = "txtKodeBook";
            this.txtKodeBook.Size = new System.Drawing.Size(206, 23);
            this.txtKodeBook.TabIndex = 7;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Location = new System.Drawing.Point(124, 120);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(100, 23);
            this.txtTotalHarga.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 34);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 70);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTanggalKunjungan
            // 
            this.lblTanggalKunjungan.AutoSize = true;
            this.lblTanggalKunjungan.Location = new System.Drawing.Point(366, 106);
            this.lblTanggalKunjungan.Name = "lblTanggalKunjungan";
            this.lblTanggalKunjungan.Size = new System.Drawing.Size(143, 15);
            this.lblTanggalKunjungan.TabIndex = 4;
            this.lblTanggalKunjungan.Text = "Tanggal Kunjungan :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(366, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(141, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status Pembayaran :";
            // 
            // lblKodeBooking
            // 
            this.lblKodeBooking.AutoSize = true;
            this.lblKodeBooking.Location = new System.Drawing.Point(366, 31);
            this.lblKodeBooking.Name = "lblKodeBooking";
            this.lblKodeBooking.Size = new System.Drawing.Size(105, 15);
            this.lblKodeBooking.TabIndex = 2;
            this.lblKodeBooking.Text = "Kode Booking : ";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(28, 120);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(92, 15);
            this.lblTotalHarga.TabIndex = 1;
            this.lblTotalHarga.Text = "Total Harga :";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(28, 40);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(95, 15);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Detail Tiket : ";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Sienna;
            this.btnLogout.Location = new System.Drawing.Point(646, 143);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 26);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormBookingPengunjung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.grpBoxRingkasan);
            this.Controls.Add(this.grpBoxDataTiket);
            this.Name = "FormBookingPengunjung";
            this.Text = "FormBookingPengunjung";
            this.Load += new System.EventHandler(this.FormBookingPengunjung_Load);
            this.grpBoxDataTiket.ResumeLayout(false);
            this.grpBoxDataTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketAnak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketPelajar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiketDewasa)).EndInit();
            this.grpBoxRingkasan.ResumeLayout(false);
            this.grpBoxRingkasan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.GroupBox grpBoxDataTiket;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblTiketDewasa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTiketAnak;
        private System.Windows.Forms.Label lblTiketPelajar;
        private System.Windows.Forms.NumericUpDown numTiketAnak;
        private System.Windows.Forms.NumericUpDown numTiketPelajar;
        private System.Windows.Forms.NumericUpDown numTiketDewasa;
        private System.Windows.Forms.GroupBox grpBoxRingkasan;
        private System.Windows.Forms.Label lblSisaKuota;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Label lblTanggalKunjungan;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKodeBooking;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox txtSisaKuota;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTanggalKunjungan;
        private System.Windows.Forms.TextBox txtStatusPembayaran;
        private System.Windows.Forms.TextBox txtKodeBook;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label lblHargatktPelajar;
        private System.Windows.Forms.Label lblHargatktDewasa;
        private System.Windows.Forms.Label lblHargatktAnak;
        private System.Windows.Forms.Button btnLogout;
    }
}