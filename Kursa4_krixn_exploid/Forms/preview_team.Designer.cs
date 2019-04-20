namespace Kursa4_krixn_exploid.Forms
{
    partial class preview_team
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preview_team));
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnLineup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNameTeam = new System.Windows.Forms.Label();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ptcBox = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panelLeft1 = new Kursa4_krixn_exploid.Forms.panelLeft();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pnlRight.Controls.Add(this.lblID);
            this.pnlRight.Controls.Add(this.btnLineup);
            this.pnlRight.Controls.Add(this.btnClose);
            this.pnlRight.Controls.Add(this.lblCreated);
            this.pnlRight.Controls.Add(this.lblCountry);
            this.pnlRight.Controls.Add(this.lblCity);
            this.pnlRight.Controls.Add(this.lblNameTeam);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(465, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(470, 361);
            this.pnlRight.TabIndex = 0;
            this.pnlRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlRight_MouseMove);
            // 
            // btnLineup
            // 
            this.btnLineup.ActiveBorderThickness = 1;
            this.btnLineup.ActiveCornerRadius = 20;
            this.btnLineup.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnLineup.ActiveForecolor = System.Drawing.Color.White;
            this.btnLineup.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnLineup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnLineup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLineup.BackgroundImage")));
            this.btnLineup.ButtonText = "Состав команды";
            this.btnLineup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLineup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineup.ForeColor = System.Drawing.Color.White;
            this.btnLineup.IdleBorderThickness = 1;
            this.btnLineup.IdleCornerRadius = 20;
            this.btnLineup.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnLineup.IdleForecolor = System.Drawing.Color.White;
            this.btnLineup.IdleLineColor = System.Drawing.Color.White;
            this.btnLineup.Location = new System.Drawing.Point(114, 299);
            this.btnLineup.Margin = new System.Windows.Forms.Padding(6);
            this.btnLineup.Name = "btnLineup";
            this.btnLineup.Size = new System.Drawing.Size(241, 47);
            this.btnLineup.TabIndex = 5;
            this.btnLineup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLineup.Click += new System.EventHandler(this.btnLineup_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(430, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreated.ForeColor = System.Drawing.Color.White;
            this.lblCreated.Location = new System.Drawing.Point(34, 236);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(215, 27);
            this.lblCreated.TabIndex = 0;
            this.lblCreated.Text = "ДАТА СОЗДАНИЯ:";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(34, 184);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(110, 27);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "СТРАНА:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(34, 132);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(99, 27);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "ГОРОД:";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameTeam
            // 
            this.lblNameTeam.AutoSize = true;
            this.lblNameTeam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameTeam.ForeColor = System.Drawing.Color.White;
            this.lblNameTeam.Location = new System.Drawing.Point(34, 80);
            this.lblNameTeam.Name = "lblNameTeam";
            this.lblNameTeam.Size = new System.Drawing.Size(146, 27);
            this.lblNameTeam.TabIndex = 0;
            this.lblNameTeam.Text = "НАЗВАНИЕ:";
            this.lblNameTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // ptcBox
            // 
            this.ptcBox.Location = new System.Drawing.Point(88, 66);
            this.ptcBox.Name = "ptcBox";
            this.ptcBox.Size = new System.Drawing.Size(280, 212);
            this.ptcBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptcBox.TabIndex = 2;
            this.ptcBox.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Visible = false;
            // 
            // panelLeft1
            // 
            this.panelLeft1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.panelLeft1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.panelLeft1.Location = new System.Drawing.Point(-5, 100);
            this.panelLeft1.Name = "panelLeft1";
            this.panelLeft1.Size = new System.Drawing.Size(26, 147);
            this.panelLeft1.TabIndex = 3;
            // 
            // preview_team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(935, 361);
            this.Controls.Add(this.panelLeft1);
            this.Controls.Add(this.ptcBox);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "preview_team";
            this.Text = "preview_team";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.preview_team_MouseMove);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRight;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private panelLeft panelLeft1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        public System.Windows.Forms.PictureBox ptcBox;
        public System.Windows.Forms.Label lblCreated;
        public System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblNameTeam;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLineup;
        public System.Windows.Forms.Label lblID;
    }
}