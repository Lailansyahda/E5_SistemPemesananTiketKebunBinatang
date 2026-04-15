namespace KebunBinatangADO.Forms
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblhome = new System.Windows.Forms.Label();
            this.btnpengunjung = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(158, -46);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(468, 285);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblhome
            // 
            this.lblhome.AutoSize = true;
            this.lblhome.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.Location = new System.Drawing.Point(270, 202);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(280, 37);
            this.lblhome.TabIndex = 2;
            this.lblhome.Text = "SELAMAT DATANG";
            // 
            // btnpengunjung
            // 
            this.btnpengunjung.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnpengunjung.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpengunjung.ForeColor = System.Drawing.Color.White;
            this.btnpengunjung.Location = new System.Drawing.Point(158, 286);
            this.btnpengunjung.Name = "btnpengunjung";
            this.btnpengunjung.Size = new System.Drawing.Size(155, 89);
            this.btnpengunjung.TabIndex = 3;
            this.btnpengunjung.Text = "PENGUNJUNG";
            this.btnpengunjung.UseVisualStyleBackColor = false;
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnadmin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.Color.White;
            this.btnadmin.Location = new System.Drawing.Point(478, 287);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(148, 88);
            this.btnadmin.TabIndex = 4;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.UseVisualStyleBackColor = false;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnpengunjung);
            this.Controls.Add(this.lblhome);
            this.Controls.Add(this.picLogo);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.Button btnpengunjung;
        private System.Windows.Forms.Button btnadmin;
    }
}