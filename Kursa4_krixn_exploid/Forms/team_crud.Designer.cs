namespace Kursa4_krixn_exploid.Forms
{
    partial class team_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(team_crud));
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblId_team = new System.Windows.Forms.Label();
            this.txtid_team = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.txtCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.chooseImage = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logoPreview = new System.Windows.Forms.PictureBox();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTOP
            // 
            this.pnlTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.pnlTOP.Controls.Add(this.btnClose);
            this.pnlTOP.Controls.Add(this.btnMin);
            this.pnlTOP.Controls.Add(this.lblFormName);
            this.pnlTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTOP.Location = new System.Drawing.Point(0, 0);
            this.pnlTOP.Name = "pnlTOP";
            this.pnlTOP.Size = new System.Drawing.Size(864, 55);
            this.pnlTOP.TabIndex = 0;
            this.pnlTOP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTOP_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(822, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = global::Kursa4_krixn_exploid.Properties.Resources.icons8_minus_48;
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(790, 17);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 38);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormName.Location = new System.Drawing.Point(333, 12);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(140, 30);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Team: Update";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblId_team
            // 
            this.lblId_team.AutoSize = true;
            this.lblId_team.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId_team.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId_team.Location = new System.Drawing.Point(86, 72);
            this.lblId_team.Name = "lblId_team";
            this.lblId_team.Size = new System.Drawing.Size(65, 21);
            this.lblId_team.TabIndex = 1;
            this.lblId_team.Text = "id_team";
            this.lblId_team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid_team
            // 
            this.txtid_team.BackColor = System.Drawing.SystemColors.Info;
            this.txtid_team.Location = new System.Drawing.Point(157, 72);
            this.txtid_team.Name = "txtid_team";
            this.txtid_team.ReadOnly = true;
            this.txtid_team.Size = new System.Drawing.Size(356, 20);
            this.txtid_team.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(72, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(356, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(96, 153);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(54, 21);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Город";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(156, 154);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(356, 20);
            this.txtCity.TabIndex = 2;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(90, 194);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 21);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Страна";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(156, 195);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(356, 20);
            this.txtCountry.TabIndex = 2;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCreatedAt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCreatedAt.Location = new System.Drawing.Point(27, 235);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(124, 21);
            this.lblCreatedAt.TabIndex = 1;
            this.lblCreatedAt.Text = "Дата основания";
            this.lblCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCreatedAt
            // 
            this.txtCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCreatedAt.Location = new System.Drawing.Point(157, 236);
            this.txtCreatedAt.Name = "txtCreatedAt";
            this.txtCreatedAt.Size = new System.Drawing.Size(355, 20);
            this.txtCreatedAt.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Отмена";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(275, 272);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 47);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ActiveBorderThickness = 1;
            this.btnOk.ActiveCornerRadius = 20;
            this.btnOk.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.ActiveForecolor = System.Drawing.Color.White;
            this.btnOk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.ButtonText = "ОК";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleCornerRadius = 20;
            this.btnOk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.IdleForecolor = System.Drawing.Color.White;
            this.btnOk.IdleLineColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(156, 272);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 4;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // chooseImage
            // 
            this.chooseImage.ActiveBorderThickness = 1;
            this.chooseImage.ActiveCornerRadius = 20;
            this.chooseImage.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chooseImage.ActiveForecolor = System.Drawing.Color.White;
            this.chooseImage.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chooseImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseImage.BackgroundImage")));
            this.chooseImage.ButtonText = "Choose Image";
            this.chooseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseImage.ForeColor = System.Drawing.Color.White;
            this.chooseImage.IdleBorderThickness = 1;
            this.chooseImage.IdleCornerRadius = 20;
            this.chooseImage.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.chooseImage.IdleForecolor = System.Drawing.Color.White;
            this.chooseImage.IdleLineColor = System.Drawing.Color.White;
            this.chooseImage.Location = new System.Drawing.Point(615, 246);
            this.chooseImage.Margin = new System.Windows.Forms.Padding(6);
            this.chooseImage.Name = "chooseImage";
            this.chooseImage.Size = new System.Drawing.Size(176, 45);
            this.chooseImage.TabIndex = 4;
            this.chooseImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chooseImage.Visible = false;
            this.chooseImage.Click += new System.EventHandler(this.chooseImage_Click);
            // 
            // logoPreview
            // 
            this.logoPreview.Location = new System.Drawing.Point(615, 72);
            this.logoPreview.Name = "logoPreview";
            this.logoPreview.Size = new System.Drawing.Size(176, 165);
            this.logoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPreview.TabIndex = 3;
            this.logoPreview.TabStop = false;
            // 
            // team_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(864, 334);
            this.Controls.Add(this.txtCreatedAt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chooseImage);
            this.Controls.Add(this.logoPreview);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtid_team);
            this.Controls.Add(this.lblId_team);
            this.Controls.Add(this.pnlTOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "team_crud";
            this.Text = "Team CRUD";
            this.pnlTOP.ResumeLayout(false);
            this.pnlTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTOP;
        public System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCreatedAt;
        private Bunifu.Framework.UI.BunifuThinButton2 chooseImage;
        public System.Windows.Forms.TextBox txtid_team;
        public System.Windows.Forms.PictureBox logoPreview;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtCountry;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        public System.Windows.Forms.DateTimePicker txtCreatedAt;
        public System.Windows.Forms.Label lblId_team;
    }
}