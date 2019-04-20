namespace Kursa4_krixn_exploid
{
    partial class preview_coach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preview_coach));
            this.panelLeft1 = new Kursa4_krixn_exploid.Forms.panelLeft();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblexp = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.ptcBox = new System.Windows.Forms.PictureBox();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft1
            // 
            this.panelLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelLeft1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panelLeft1.Location = new System.Drawing.Point(-9, 100);
            this.panelLeft1.Name = "panelLeft1";
            this.panelLeft1.Size = new System.Drawing.Size(26, 147);
            this.panelLeft1.TabIndex = 9;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pnlRight.Controls.Add(this.lblbirthday);
            this.pnlRight.Controls.Add(this.lblCountry);
            this.pnlRight.Controls.Add(this.lblexp);
            this.pnlRight.Controls.Add(this.lblLastName);
            this.pnlRight.Controls.Add(this.lblFirstName);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(417, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(467, 361);
            this.pnlRight.TabIndex = 7;
            this.pnlRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRight_MouseMove);
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbirthday.ForeColor = System.Drawing.Color.White;
            this.lblbirthday.Location = new System.Drawing.Point(27, 232);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(221, 27);
            this.lblbirthday.TabIndex = 4;
            this.lblbirthday.Text = "ДАТА РОЖДЕНИЯ:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(27, 196);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(110, 27);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "СТРАНА:";
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblexp.ForeColor = System.Drawing.Color.White;
            this.lblexp.Location = new System.Drawing.Point(27, 160);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(90, 27);
            this.lblexp.TabIndex = 6;
            this.lblexp.Text = "ОПЫТ:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(27, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(137, 27);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "ФАМИЛИЯ:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(27, 88);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 27);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "ИМЯ:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(425, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptcBox
            // 
            this.ptcBox.Image = global::Kursa4_krixn_exploid.Properties.Resources.avata_player;
            this.ptcBox.Location = new System.Drawing.Point(66, 66);
            this.ptcBox.Name = "ptcBox";
            this.ptcBox.Size = new System.Drawing.Size(281, 212);
            this.ptcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcBox.TabIndex = 8;
            this.ptcBox.TabStop = false;
            // 
            // preview_coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.panelLeft1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.ptcBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "preview_coach";
            this.Text = "preview_coach";
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.panelLeft panelLeft1;
        private System.Windows.Forms.Panel pnlRight;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox ptcBox;
        public System.Windows.Forms.Label lblbirthday;
        public System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.Label lblexp;
        public System.Windows.Forms.Label lblLastName;
        public System.Windows.Forms.Label lblFirstName;
    }
}