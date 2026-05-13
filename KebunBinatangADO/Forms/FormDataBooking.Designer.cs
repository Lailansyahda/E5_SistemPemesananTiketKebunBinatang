namespace KebunBinatangADO.Forms
{
    partial class FormDataBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataBooking = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcaridata = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.dgvDataBooking = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dBKebunBinatangADODataSet = new KebunBinatangADO.DBKebunBinatangADODataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new KebunBinatangADO.DBKebunBinatangADODataSetTableAdapters.BookingTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBKebunBinatangADODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblDataBooking
            // 
            this.lblDataBooking.AutoSize = true;
            this.lblDataBooking.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblDataBooking.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBooking.ForeColor = System.Drawing.Color.White;
            this.lblDataBooking.Location = new System.Drawing.Point(315, 44);
            this.lblDataBooking.Name = "lblDataBooking";
            this.lblDataBooking.Size = new System.Drawing.Size(156, 31);
            this.lblDataBooking.TabIndex = 1;
            this.lblDataBooking.Text = "Data Booking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblcaridata
            // 
            this.lblcaridata.AutoSize = true;
            this.lblcaridata.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaridata.ForeColor = System.Drawing.Color.White;
            this.lblcaridata.Location = new System.Drawing.Point(113, 133);
            this.lblcaridata.Name = "lblcaridata";
            this.lblcaridata.Size = new System.Drawing.Size(128, 15);
            this.lblcaridata.TabIndex = 17;
            this.lblcaridata.Text = "Cari Kode/Nama : ";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookingBindingSource, "KodeBooking", true));
            this.textBox1.Location = new System.Drawing.Point(264, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 27);
            this.textBox1.TabIndex = 18;
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnTampil.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(569, 121);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(129, 40);
            this.btnTampil.TabIndex = 19;
            this.btnTampil.Text = "Tampilkan Data";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // dgvDataBooking
            // 
            this.dgvDataBooking.AllowUserToAddRows = false;
            this.dgvDataBooking.AllowUserToDeleteRows = false;
            this.dgvDataBooking.AutoGenerateColumns = false;
            this.dgvDataBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvDataBooking.DataSource = this.bookingBindingSource;
            this.dgvDataBooking.Location = new System.Drawing.Point(27, 182);
            this.dgvDataBooking.Name = "dgvDataBooking";
            this.dgvDataBooking.ReadOnly = true;
            this.dgvDataBooking.Size = new System.Drawing.Size(761, 208);
            this.dgvDataBooking.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(683, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 28);
            this.btnBack.TabIndex = 21;
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
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dBKebunBinatangADODataSet
            // 
            this.dBKebunBinatangADODataSet.DataSetName = "DBKebunBinatangADODataSet";
            this.dBKebunBinatangADODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.dBKebunBinatangADODataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
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
            // FormDataBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDataBooking);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcaridata);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDataBooking);
            this.Controls.Add(this.label1);
            this.Name = "FormDataBooking";
            this.Text = "FormDataBooking";
            this.Load += new System.EventHandler(this.FormDataBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBKebunBinatangADODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDataBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcaridata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.DataGridView dgvDataBooking;
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