namespace Kursa4_krixn_exploid.Forms
{
    partial class add_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_player));
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbPlayers = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtdateBy = new System.Windows.Forms.DateTimePicker();
            this.lbldateby = new System.Windows.Forms.Label();
            this.lbldatefrom = new System.Windows.Forms.Label();
            this.dtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlTOP.Size = new System.Drawing.Size(725, 55);
            this.pnlTOP.TabIndex = 7;
            this.pnlTOP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTOP_MouseMove);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormName.Location = new System.Drawing.Point(263, 12);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(181, 30);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Добавить Игрока";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(692, 12);
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
            this.btnMin.Location = new System.Drawing.Point(660, 17);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 38);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // cmbPlayers
            // 
            this.cmbPlayers.FormattingEnabled = true;
            this.cmbPlayers.Location = new System.Drawing.Point(179, 104);
            this.cmbPlayers.Name = "cmbPlayers";
            this.cmbPlayers.Size = new System.Drawing.Size(265, 21);
            this.cmbPlayers.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(481, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(119, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 21);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Игрок";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnCancel.Location = new System.Drawing.Point(298, 239);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 47);
            this.btnCancel.TabIndex = 19;
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
            this.btnOk.Location = new System.Drawing.Point(179, 239);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 20;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtdateBy
            // 
            this.dtdateBy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdateBy.Location = new System.Drawing.Point(179, 195);
            this.dtdateBy.Name = "dtdateBy";
            this.dtdateBy.Size = new System.Drawing.Size(265, 20);
            this.dtdateBy.TabIndex = 21;
            // 
            // lbldateby
            // 
            this.lbldateby.AutoSize = true;
            this.lbldateby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldateby.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldateby.Location = new System.Drawing.Point(73, 194);
            this.lbldateby.Name = "lbldateby";
            this.lbldateby.Size = new System.Drawing.Size(100, 21);
            this.lbldateby.TabIndex = 11;
            this.lbldateby.Text = "Контракт По";
            this.lbldateby.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbldatefrom
            // 
            this.lbldatefrom.AutoSize = true;
            this.lbldatefrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldatefrom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldatefrom.Location = new System.Drawing.Point(83, 150);
            this.lbldatefrom.Name = "lbldatefrom";
            this.lbldatefrom.Size = new System.Drawing.Size(90, 21);
            this.lbldatefrom.TabIndex = 11;
            this.lbldatefrom.Text = "Контракт С";
            this.lbldatefrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateFrom.Location = new System.Drawing.Point(179, 151);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Size = new System.Drawing.Size(265, 20);
            this.dtDateFrom.TabIndex = 21;
            // 
            // add_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(725, 328);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.dtdateBy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbldatefrom);
            this.Controls.Add(this.lbldateby);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbPlayers);
            this.Controls.Add(this.pnlTOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_player";
            this.Text = "add_player";
            this.pnlTOP.ResumeLayout(false);
            this.pnlTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTOP;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        public System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.ComboBox cmbPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        public System.Windows.Forms.DateTimePicker dtdateBy;
        private System.Windows.Forms.Label lbldateby;
        private System.Windows.Forms.Label lbldatefrom;
        public System.Windows.Forms.DateTimePicker dtDateFrom;
    }
}