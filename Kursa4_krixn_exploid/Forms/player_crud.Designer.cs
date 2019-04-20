namespace Kursa4_krixn_exploid.Forms
{
    partial class player_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player_crud));
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logoPreview = new System.Windows.Forms.PictureBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtid_player = new System.Windows.Forms.TextBox();
            this.lblId_team = new System.Windows.Forms.Label();
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblJersey = new System.Windows.Forms.Label();
            this.txtJersey = new System.Windows.Forms.TextBox();
            this.lblPositon = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).BeginInit();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirthday
            // 
            this.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBirthday.Location = new System.Drawing.Point(157, 233);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(355, 20);
            this.txtBirthday.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
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
            this.btnCancel.Location = new System.Drawing.Point(276, 354);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 47);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ActiveBorderThickness = 1;
            this.btnOk.ActiveCornerRadius = 20;
            this.btnOk.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.ActiveForecolor = System.Drawing.Color.White;
            this.btnOk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleCornerRadius = 20;
            this.btnOk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnOk.IdleForecolor = System.Drawing.Color.White;
            this.btnOk.IdleLineColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(157, 354);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 18;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // logoPreview
            // 
            this.logoPreview.Image = global::Kursa4_krixn_exploid.Properties.Resources.avata_player;
            this.logoPreview.Location = new System.Drawing.Point(577, 80);
            this.logoPreview.Name = "logoPreview";
            this.logoPreview.Size = new System.Drawing.Size(250, 248);
            this.logoPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPreview.TabIndex = 16;
            this.logoPreview.TabStop = false;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBirthday.Location = new System.Drawing.Point(30, 232);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(121, 21);
            this.lblBirthday.TabIndex = 7;
            this.lblBirthday.Text = "Дата Рождения";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(157, 195);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(356, 20);
            this.txtCountry.TabIndex = 12;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCountry.Location = new System.Drawing.Point(90, 194);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 21);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Страна";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(157, 156);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(356, 20);
            this.txtLastname.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(76, 156);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(75, 21);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "Фамилия";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(157, 118);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(356, 20);
            this.txtFirstname.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(110, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 21);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Имя";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid_player
            // 
            this.txtid_player.BackColor = System.Drawing.SystemColors.Info;
            this.txtid_player.Location = new System.Drawing.Point(157, 80);
            this.txtid_player.Name = "txtid_player";
            this.txtid_player.ReadOnly = true;
            this.txtid_player.Size = new System.Drawing.Size(356, 20);
            this.txtid_player.TabIndex = 15;
            // 
            // lblId_team
            // 
            this.lblId_team.AutoSize = true;
            this.lblId_team.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId_team.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId_team.Location = new System.Drawing.Point(78, 80);
            this.lblId_team.Name = "lblId_team";
            this.lblId_team.Size = new System.Drawing.Size(73, 21);
            this.lblId_team.TabIndex = 11;
            this.lblId_team.Text = "id_player";
            this.lblId_team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.pnlTOP.TabIndex = 6;
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
            this.lblFormName.Location = new System.Drawing.Point(311, 12);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(186, 30);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Player: Unchanged";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJersey
            // 
            this.lblJersey.AutoSize = true;
            this.lblJersey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJersey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJersey.Location = new System.Drawing.Point(37, 271);
            this.lblJersey.Name = "lblJersey";
            this.lblJersey.Size = new System.Drawing.Size(114, 21);
            this.lblJersey.TabIndex = 7;
            this.lblJersey.Text = "Номер Игрока";
            this.lblJersey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtJersey
            // 
            this.txtJersey.Location = new System.Drawing.Point(157, 271);
            this.txtJersey.Name = "txtJersey";
            this.txtJersey.Size = new System.Drawing.Size(355, 20);
            this.txtJersey.TabIndex = 12;
            // 
            // lblPositon
            // 
            this.lblPositon.AutoSize = true;
            this.lblPositon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPositon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPositon.Location = new System.Drawing.Point(78, 307);
            this.lblPositon.Name = "lblPositon";
            this.lblPositon.Size = new System.Drawing.Size(73, 21);
            this.lblPositon.TabIndex = 7;
            this.lblPositon.Text = "Позиция";
            this.lblPositon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "Forward",
            "Defenseman",
            "Goalie"});
            this.cmbPosition.Location = new System.Drawing.Point(157, 307);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(355, 21);
            this.cmbPosition.TabIndex = 21;
            // 
            // player_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(864, 416);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.logoPreview);
            this.Controls.Add(this.lblPositon);
            this.Controls.Add(this.lblJersey);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.txtJersey);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtid_player);
            this.Controls.Add(this.lblId_team);
            this.Controls.Add(this.pnlTOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "player_crud";
            this.Text = "player_crud";
            ((System.ComponentModel.ISupportInitialize)(this.logoPreview)).EndInit();
            this.pnlTOP.ResumeLayout(false);
            this.pnlTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker txtBirthday;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        public System.Windows.Forms.PictureBox logoPreview;
        private System.Windows.Forms.Label lblBirthday;
        public System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtid_player;
        private System.Windows.Forms.Panel pnlTOP;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        public System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblJersey;
        public System.Windows.Forms.TextBox txtJersey;
        private System.Windows.Forms.Label lblPositon;
        public System.Windows.Forms.ComboBox cmbPosition;
        public System.Windows.Forms.Label lblId_team;
    }
}