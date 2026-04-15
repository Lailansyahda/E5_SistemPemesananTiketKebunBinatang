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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataBooking = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcaridata = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.dgvDataBooking = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBooking)).BeginInit();
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
            this.dgvDataBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBooking.Location = new System.Drawing.Point(116, 182);
            this.dgvDataBooking.Name = "dgvDataBooking";
            this.dgvDataBooking.ReadOnly = true;
            this.dgvDataBooking.Size = new System.Drawing.Size(582, 150);
            this.dgvDataBooking.TabIndex = 20;
            this.dgvDataBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBooking_CellClick);
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
            // FormDataBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}