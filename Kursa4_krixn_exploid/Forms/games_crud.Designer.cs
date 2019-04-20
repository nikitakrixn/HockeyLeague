namespace Kursa4_krixn_exploid.Forms
{
    partial class games_crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(games_crud));
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtid_game = new System.Windows.Forms.TextBox();
            this.lblId_team = new System.Windows.Forms.Label();
            this.cmbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cmbAwayTeam = new System.Windows.Forms.ComboBox();
            this.cmbArena = new System.Windows.Forms.ComboBox();
            this.pnlTOP = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFormName = new System.Windows.Forms.Label();
            this.txtHomeScore = new System.Windows.Forms.NumericUpDown();
            this.txtAwayScore = new System.Windows.Forms.NumericUpDown();
            this.lblArena = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbStatusGame = new System.Windows.Forms.ComboBox();
            this.lblStatusGame = new System.Windows.Forms.Label();
            this.pnlTOP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwayScore)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(243, 233);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(355, 20);
            this.txtDate.TabIndex = 54;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(101, 232);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(136, 21);
            this.lblDate.TabIndex = 41;
            this.lblDate.Text = "Дата Проведения";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAwayTeam
            // 
            this.lblAwayTeam.AutoSize = true;
            this.lblAwayTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAwayTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAwayTeam.Location = new System.Drawing.Point(185, 193);
            this.lblAwayTeam.Name = "lblAwayTeam";
            this.lblAwayTeam.Size = new System.Drawing.Size(50, 21);
            this.lblAwayTeam.TabIndex = 42;
            this.lblAwayTeam.Text = "Гости";
            this.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHomeTeam
            // 
            this.lblHomeTeam.AutoSize = true;
            this.lblHomeTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHomeTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomeTeam.Location = new System.Drawing.Point(168, 157);
            this.lblHomeTeam.Name = "lblHomeTeam";
            this.lblHomeTeam.Size = new System.Drawing.Size(67, 21);
            this.lblHomeTeam.TabIndex = 43;
            this.lblHomeTeam.Text = "Хозяева";
            this.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(243, 126);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(356, 20);
            this.txtCity.TabIndex = 49;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(91, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 21);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Место провидения";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid_game
            // 
            this.txtid_game.BackColor = System.Drawing.SystemColors.Info;
            this.txtid_game.Location = new System.Drawing.Point(244, 89);
            this.txtid_game.Name = "txtid_game";
            this.txtid_game.ReadOnly = true;
            this.txtid_game.Size = new System.Drawing.Size(356, 20);
            this.txtid_game.TabIndex = 50;
            // 
            // lblId_team
            // 
            this.lblId_team.AutoSize = true;
            this.lblId_team.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId_team.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId_team.Location = new System.Drawing.Point(168, 88);
            this.lblId_team.Name = "lblId_team";
            this.lblId_team.Size = new System.Drawing.Size(69, 21);
            this.lblId_team.TabIndex = 45;
            this.lblId_team.Text = "id_game";
            this.lblId_team.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbHomeTeam
            // 
            this.cmbHomeTeam.FormattingEnabled = true;
            this.cmbHomeTeam.Location = new System.Drawing.Point(243, 160);
            this.cmbHomeTeam.Name = "cmbHomeTeam";
            this.cmbHomeTeam.Size = new System.Drawing.Size(355, 21);
            this.cmbHomeTeam.TabIndex = 55;
            // 
            // cmbAwayTeam
            // 
            this.cmbAwayTeam.FormattingEnabled = true;
            this.cmbAwayTeam.Location = new System.Drawing.Point(243, 196);
            this.cmbAwayTeam.Name = "cmbAwayTeam";
            this.cmbAwayTeam.Size = new System.Drawing.Size(355, 21);
            this.cmbAwayTeam.TabIndex = 55;
            // 
            // cmbArena
            // 
            this.cmbArena.FormattingEnabled = true;
            this.cmbArena.Location = new System.Drawing.Point(243, 275);
            this.cmbArena.Name = "cmbArena";
            this.cmbArena.Size = new System.Drawing.Size(355, 21);
            this.cmbArena.TabIndex = 57;
            // 
            // pnlTOP
            // 
            this.pnlTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.pnlTOP.Controls.Add(this.btnClose);
            this.pnlTOP.Controls.Add(this.btnMin);
            this.pnlTOP.Controls.Add(this.lblFormName);
            this.pnlTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTOP.Location = new System.Drawing.Point(0, 0);
            this.pnlTOP.Name = "pnlTOP";
            this.pnlTOP.Size = new System.Drawing.Size(870, 55);
            this.pnlTOP.TabIndex = 58;
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
            this.lblFormName.Size = new System.Drawing.Size(184, 30);
            this.lblFormName.TabIndex = 0;
            this.lblFormName.Text = "Game: Unchanged";
            this.lblFormName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHomeScore
            // 
            this.txtHomeScore.Location = new System.Drawing.Point(639, 189);
            this.txtHomeScore.Name = "txtHomeScore";
            this.txtHomeScore.Size = new System.Drawing.Size(70, 20);
            this.txtHomeScore.TabIndex = 59;
            // 
            // txtAwayScore
            // 
            this.txtAwayScore.Location = new System.Drawing.Point(757, 189);
            this.txtAwayScore.Name = "txtAwayScore";
            this.txtAwayScore.Size = new System.Drawing.Size(70, 20);
            this.txtAwayScore.TabIndex = 59;
            // 
            // lblArena
            // 
            this.lblArena.AutoSize = true;
            this.lblArena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblArena.Location = new System.Drawing.Point(181, 275);
            this.lblArena.Name = "lblArena";
            this.lblArena.Size = new System.Drawing.Size(54, 21);
            this.lblArena.TabIndex = 41;
            this.lblArena.Text = "Арена";
            this.lblArena.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHomeScore
            // 
            this.lblHomeScore.AutoSize = true;
            this.lblHomeScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHomeScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHomeScore.Location = new System.Drawing.Point(626, 145);
            this.lblHomeScore.Name = "lblHomeScore";
            this.lblHomeScore.Size = new System.Drawing.Size(102, 21);
            this.lblHomeScore.TabIndex = 41;
            this.lblHomeScore.Text = "Хозяева счёт";
            this.lblHomeScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAwayScore
            // 
            this.lblAwayScore.AutoSize = true;
            this.lblAwayScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAwayScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAwayScore.Location = new System.Drawing.Point(753, 145);
            this.lblAwayScore.Name = "lblAwayScore";
            this.lblAwayScore.Size = new System.Drawing.Size(85, 21);
            this.lblAwayScore.TabIndex = 41;
            this.lblAwayScore.Text = "Гости счёт";
            this.lblAwayScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Отмена";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnCancel.IdleForecolor = System.Drawing.Color.White;
            this.btnCancel.IdleLineColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(384, 343);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 47);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ActiveBorderThickness = 1;
            this.btnOk.ActiveCornerRadius = 20;
            this.btnOk.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOk.ActiveForecolor = System.Drawing.Color.White;
            this.btnOk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleCornerRadius = 20;
            this.btnOk.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnOk.IdleForecolor = System.Drawing.Color.White;
            this.btnOk.IdleLineColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(265, 343);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 47);
            this.btnOk.TabIndex = 61;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbStatusGame
            // 
            this.cmbStatusGame.FormattingEnabled = true;
            this.cmbStatusGame.Items.AddRange(new object[] {
            "Матч состоялся",
            "Матч не состоялся"});
            this.cmbStatusGame.Location = new System.Drawing.Point(243, 313);
            this.cmbStatusGame.Name = "cmbStatusGame";
            this.cmbStatusGame.Size = new System.Drawing.Size(355, 21);
            this.cmbStatusGame.TabIndex = 57;
            // 
            // lblStatusGame
            // 
            this.lblStatusGame.AutoSize = true;
            this.lblStatusGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatusGame.Location = new System.Drawing.Point(128, 313);
            this.lblStatusGame.Name = "lblStatusGame";
            this.lblStatusGame.Size = new System.Drawing.Size(107, 21);
            this.lblStatusGame.TabIndex = 41;
            this.lblStatusGame.Text = "Статус Матча";
            this.lblStatusGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // games_crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(870, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAwayScore);
            this.Controls.Add(this.txtHomeScore);
            this.Controls.Add(this.pnlTOP);
            this.Controls.Add(this.cmbStatusGame);
            this.Controls.Add(this.cmbArena);
            this.Controls.Add(this.cmbAwayTeam);
            this.Controls.Add(this.cmbHomeTeam);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblAwayScore);
            this.Controls.Add(this.lblHomeScore);
            this.Controls.Add(this.lblStatusGame);
            this.Controls.Add(this.lblArena);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtid_game);
            this.Controls.Add(this.lblId_team);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "games_crud";
            this.Text = "games_crud";
            this.Load += new System.EventHandler(this.games_crud_Load);
            this.pnlTOP.ResumeLayout(false);
            this.pnlTOP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwayScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblHomeTeam;
        public System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.TextBox txtid_game;
        private System.Windows.Forms.Panel pnlTOP;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        public System.Windows.Forms.Label lblFormName;
        public System.Windows.Forms.Label lblId_team;
        public System.Windows.Forms.NumericUpDown txtHomeScore;
        public System.Windows.Forms.NumericUpDown txtAwayScore;
        private System.Windows.Forms.Label lblArena;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        public System.Windows.Forms.Label lblHomeScore;
        public System.Windows.Forms.Label lblAwayScore;
        public System.Windows.Forms.ComboBox cmbHomeTeam;
        public System.Windows.Forms.ComboBox cmbAwayTeam;
        public System.Windows.Forms.ComboBox cmbArena;
        public System.Windows.Forms.ComboBox cmbStatusGame;
        public System.Windows.Forms.Label lblStatusGame;
    }
}