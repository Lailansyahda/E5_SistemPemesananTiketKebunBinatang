namespace KebunBinatangADO.Forms
{
    partial class FormKelolaTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaTiket));
            this.lblKelolaTiket = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTiket = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblKuota = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTiket = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numKuota = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvKelolaTiket = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelolaTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKelolaTiket
            // 
            this.lblKelolaTiket.AutoSize = true;
            this.lblKelolaTiket.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblKelolaTiket.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelolaTiket.ForeColor = System.Drawing.Color.Transparent;
            this.lblKelolaTiket.Location = new System.Drawing.Point(327, 35);
            this.lblKelolaTiket.Name = "lblKelolaTiket";
            this.lblKelolaTiket.Size = new System.Drawing.Size(149, 31);
            this.lblKelolaTiket.TabIndex = 0;
            this.lblKelolaTiket.Text = "Kelola Tiket";
            this.lblKelolaTiket.Click += new System.EventHandler(this.lblKelolaTiket_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(77, 98);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(113, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID Pengunjung : ";
            // 
            // lblTiket
            // 
            this.lblTiket.AutoSize = true;
            this.lblTiket.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiket.ForeColor = System.Drawing.Color.White;
            this.lblTiket.Location = new System.Drawing.Point(77, 147);
            this.lblTiket.Name = "lblTiket";
            this.lblTiket.Size = new System.Drawing.Size(49, 15);
            this.lblTiket.TabIndex = 2;
            this.lblTiket.Text = "Tiket :";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.White;
            this.lblHarga.Location = new System.Drawing.Point(79, 197);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(55, 15);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.Text = "Harga :";
            // 
            // lblKuota
            // 
            this.lblKuota.AutoSize = true;
            this.lblKuota.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuota.ForeColor = System.Drawing.Color.White;
            this.lblKuota.Location = new System.Drawing.Point(80, 246);
            this.lblKuota.Name = "lblKuota";
            this.lblKuota.Size = new System.Drawing.Size(56, 15);
            this.lblKuota.TabIndex = 4;
            this.lblKuota.Text = "Kuota : ";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(211, 96);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 23);
            this.txtID.TabIndex = 5;
            // 
            // txtTiket
            // 
            this.txtTiket.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiket.Location = new System.Drawing.Point(211, 145);
            this.txtTiket.Name = "txtTiket";
            this.txtTiket.Size = new System.Drawing.Size(171, 23);
            this.txtTiket.TabIndex = 6;
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(211, 194);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(171, 23);
            this.txtHarga.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAdd.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(525, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Tambah Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEdit.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(524, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 36);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Data";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLoad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(525, 189);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(158, 33);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Tampilkan Data";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(524, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Hapus Data";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numKuota
            // 
            this.numKuota.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKuota.Location = new System.Drawing.Point(211, 243);
            this.numKuota.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKuota.Name = "numKuota";
            this.numKuota.Size = new System.Drawing.Size(120, 23);
            this.numKuota.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvKelolaTiket
            // 
            this.dgvKelolaTiket.AllowUserToAddRows = false;
            this.dgvKelolaTiket.AllowUserToDeleteRows = false;
            this.dgvKelolaTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKelolaTiket.Location = new System.Drawing.Point(83, 288);
            this.dgvKelolaTiket.Name = "dgvKelolaTiket";
            this.dgvKelolaTiket.ReadOnly = true;
            this.dgvKelolaTiket.Size = new System.Drawing.Size(600, 150);
            this.dgvKelolaTiket.TabIndex = 16;
            this.dgvKelolaTiket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKelolaTiket_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(699, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormKelolaTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvKelolaTiket);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numKuota);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtTiket);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblKuota);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblTiket);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblKelolaTiket);
            this.Name = "FormKelolaTiket";
            this.Text = "FormKelolaTiket";
            ((System.ComponentModel.ISupportInitialize)(this.numKuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelolaTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKelolaTiket;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTiket;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblKuota;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTiket;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.NumericUpDown numKuota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvKelolaTiket;
        private System.Windows.Forms.Button btnBack;
    }
}