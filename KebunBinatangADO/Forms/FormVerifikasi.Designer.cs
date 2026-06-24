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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerifikasi));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPilihTanggalVerif = new System.Windows.Forms.Label();
            this.txtCariKode = new System.Windows.Forms.TextBox();
            this.btnTampildata = new System.Windows.Forms.Button();
            this.btnVerifikasi = new System.Windows.Forms.Button();
            this.dgvVerifikasi = new System.Windows.Forms.DataGridView();
            this.iDBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBookingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPengunjungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAdminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTiketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalKunjunganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiketDewasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiketPelajarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiketAnakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailTiketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBKebunBinatangADODataSet = new KebunBinatangADO.DBKebunBinatangADODataSet();
            this.btnBack = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new KebunBinatangADO.DBKebunBinatangADODataSetTableAdapters.AdminTableAdapter();
            this.pengunjungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengunjungTableAdapter = new KebunBinatangADO.DBKebunBinatangADODataSetTableAdapters.PengunjungTableAdapter();
            this.bookingTableAdapter = new KebunBinatangADO.DBKebunBinatangADODataSetTableAdapters.BookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerifikasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKebunBinatangADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengunjungBindingSource)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
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
            this.btnTampildata.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnVerifikasi
            // 
            this.btnVerifikasi.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVerifikasi.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifikasi.ForeColor = System.Drawing.Color.White;
            this.btnVerifikasi.Location = new System.Drawing.Point(619, 104);
            this.btnVerifikasi.Name = "btnVerifikasi";
            this.btnVerifikasi.Size = new System.Drawing.Size(105, 35);
            this.btnVerifikasi.TabIndex = 21;
            this.btnVerifikasi.Text = "Verifikasi";
            this.btnVerifikasi.UseVisualStyleBackColor = false;
            this.btnVerifikasi.Click += new System.EventHandler(this.btnVerifikasi_Click);
            // 
            // dgvVerifikasi
            // 
            this.dgvVerifikasi.AllowUserToAddRows = false;
            this.dgvVerifikasi.AllowUserToDeleteRows = false;
            this.dgvVerifikasi.AutoGenerateColumns = false;
            this.dgvVerifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerifikasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBookingDataGridViewTextBoxColumn,
            this.kodeBookingDataGridViewTextBoxColumn,
            this.iDPengunjungDataGridViewTextBoxColumn,
            this.iDAdminDataGridViewTextBoxColumn,
            this.iDTiketDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.noHpDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.tanggalKunjunganDataGridViewTextBoxColumn,
            this.tiketDewasaDataGridViewTextBoxColumn,
            this.tiketPelajarDataGridViewTextBoxColumn,
            this.tiketAnakDataGridViewTextBoxColumn,
            this.detailTiketDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.statusPembayaranDataGridViewTextBoxColumn});
            this.dgvVerifikasi.DataSource = this.bookingBindingSource;
            this.dgvVerifikasi.Location = new System.Drawing.Point(78, 172);
            this.dgvVerifikasi.Name = "dgvVerifikasi";
            this.dgvVerifikasi.ReadOnly = true;
            this.dgvVerifikasi.Size = new System.Drawing.Size(660, 150);
            this.dgvVerifikasi.TabIndex = 22;
            // 
            // iDBookingDataGridViewTextBoxColumn
            // 
            this.iDBookingDataGridViewTextBoxColumn.DataPropertyName = "IDBooking";
            this.iDBookingDataGridViewTextBoxColumn.HeaderText = "IDBooking";
            this.iDBookingDataGridViewTextBoxColumn.Name = "iDBookingDataGridViewTextBoxColumn";
            this.iDBookingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodeBookingDataGridViewTextBoxColumn
            // 
            this.kodeBookingDataGridViewTextBoxColumn.DataPropertyName = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.HeaderText = "KodeBooking";
            this.kodeBookingDataGridViewTextBoxColumn.Name = "kodeBookingDataGridViewTextBoxColumn";
            this.kodeBookingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDPengunjungDataGridViewTextBoxColumn
            // 
            this.iDPengunjungDataGridViewTextBoxColumn.DataPropertyName = "IDPengunjung";
            this.iDPengunjungDataGridViewTextBoxColumn.HeaderText = "IDPengunjung";
            this.iDPengunjungDataGridViewTextBoxColumn.Name = "iDPengunjungDataGridViewTextBoxColumn";
            this.iDPengunjungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDAdminDataGridViewTextBoxColumn
            // 
            this.iDAdminDataGridViewTextBoxColumn.DataPropertyName = "IDAdmin";
            this.iDAdminDataGridViewTextBoxColumn.HeaderText = "IDAdmin";
            this.iDAdminDataGridViewTextBoxColumn.Name = "iDAdminDataGridViewTextBoxColumn";
            this.iDAdminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTiketDataGridViewTextBoxColumn
            // 
            this.iDTiketDataGridViewTextBoxColumn.DataPropertyName = "IDTiket";
            this.iDTiketDataGridViewTextBoxColumn.HeaderText = "IDTiket";
            this.iDTiketDataGridViewTextBoxColumn.Name = "iDTiketDataGridViewTextBoxColumn";
            this.iDTiketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noHpDataGridViewTextBoxColumn
            // 
            this.noHpDataGridViewTextBoxColumn.DataPropertyName = "NoHp";
            this.noHpDataGridViewTextBoxColumn.HeaderText = "NoHp";
            this.noHpDataGridViewTextBoxColumn.Name = "noHpDataGridViewTextBoxColumn";
            this.noHpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalKunjunganDataGridViewTextBoxColumn
            // 
            this.tanggalKunjunganDataGridViewTextBoxColumn.DataPropertyName = "TanggalKunjungan";
            this.tanggalKunjunganDataGridViewTextBoxColumn.HeaderText = "TanggalKunjungan";
            this.tanggalKunjunganDataGridViewTextBoxColumn.Name = "tanggalKunjunganDataGridViewTextBoxColumn";
            this.tanggalKunjunganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiketDewasaDataGridViewTextBoxColumn
            // 
            this.tiketDewasaDataGridViewTextBoxColumn.DataPropertyName = "TiketDewasa";
            this.tiketDewasaDataGridViewTextBoxColumn.HeaderText = "TiketDewasa";
            this.tiketDewasaDataGridViewTextBoxColumn.Name = "tiketDewasaDataGridViewTextBoxColumn";
            this.tiketDewasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiketPelajarDataGridViewTextBoxColumn
            // 
            this.tiketPelajarDataGridViewTextBoxColumn.DataPropertyName = "TiketPelajar";
            this.tiketPelajarDataGridViewTextBoxColumn.HeaderText = "TiketPelajar";
            this.tiketPelajarDataGridViewTextBoxColumn.Name = "tiketPelajarDataGridViewTextBoxColumn";
            this.tiketPelajarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiketAnakDataGridViewTextBoxColumn
            // 
            this.tiketAnakDataGridViewTextBoxColumn.DataPropertyName = "TiketAnak";
            this.tiketAnakDataGridViewTextBoxColumn.HeaderText = "TiketAnak";
            this.tiketAnakDataGridViewTextBoxColumn.Name = "tiketAnakDataGridViewTextBoxColumn";
            this.tiketAnakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailTiketDataGridViewTextBoxColumn
            // 
            this.detailTiketDataGridViewTextBoxColumn.DataPropertyName = "DetailTiket";
            this.detailTiketDataGridViewTextBoxColumn.HeaderText = "DetailTiket";
            this.detailTiketDataGridViewTextBoxColumn.Name = "detailTiketDataGridViewTextBoxColumn";
            this.detailTiketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPembayaranDataGridViewTextBoxColumn
            // 
            this.statusPembayaranDataGridViewTextBoxColumn.DataPropertyName = "StatusPembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.HeaderText = "StatusPembayaran";
            this.statusPembayaranDataGridViewTextBoxColumn.Name = "statusPembayaranDataGridViewTextBoxColumn";
            this.statusPembayaranDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.dBKebunBinatangADODataSet;
            // 
            // dBKebunBinatangADODataSet
            // 
            this.dBKebunBinatangADODataSet.DataSetName = "DBKebunBinatangADODataSet";
            this.dBKebunBinatangADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bookingBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.dBKebunBinatangADODataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // pengunjungBindingSource
            // 
            this.pengunjungBindingSource.DataMember = "Pengunjung";
            this.pengunjungBindingSource.DataSource = this.dBKebunBinatangADODataSet;
            // 
            // pengunjungTableAdapter
            // 
            this.pengunjungTableAdapter.ClearBeforeFill = true;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // FormVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvVerifikasi);
            this.Controls.Add(this.btnVerifikasi);
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
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBKebunBinatangADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengunjungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPilihTanggalVerif;
        private System.Windows.Forms.TextBox txtCariKode;
        private System.Windows.Forms.Button btnTampildata;
        private System.Windows.Forms.Button btnVerifikasi;
        private System.Windows.Forms.DataGridView dgvVerifikasi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DBKebunBinatangADODataSet dBKebunBinatangADODataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private DBKebunBinatangADODataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.BindingSource pengunjungBindingSource;
        private DBKebunBinatangADODataSetTableAdapters.PengunjungTableAdapter pengunjungTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private DBKebunBinatangADODataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBookingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPengunjungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAdminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTiketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKunjunganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiketDewasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiketPelajarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiketAnakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailTiketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPembayaranDataGridViewTextBoxColumn;
    }
}