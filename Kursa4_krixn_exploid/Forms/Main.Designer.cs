namespace Kursa4_krixn_exploid
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnFull = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNameProgramm = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMenuSlider = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStats = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGames = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCoachs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPlayers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTeams = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.games_fc1 = new Kursa4_krixn_exploid.games_fc();
            this.coachs_fc1 = new Kursa4_krixn_exploid.coachs_fc();
            this.teams_fs1 = new Kursa4_krixn_exploid.Forms.teams_fs();
            this.players_fc1 = new Kursa4_krixn_exploid.Forms.players_fc();
            this.stats_fc1 = new Kursa4_krixn_exploid.Stats_fc();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).BeginInit();
            this.pnlSideMenu.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.lblNameProgramm);
            this.pnlTop.Controls.Add(this.btnMenuSlider);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1311, 64);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnFull);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1187, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Kursa4_krixn_exploid.Properties.Resources.icons8_delete_50;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(83, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFull
            // 
            this.btnFull.BackColor = System.Drawing.Color.Transparent;
            this.btnFull.Image = global::Kursa4_krixn_exploid.Properties.Resources.icons8_full_screen_50__1_;
            this.btnFull.ImageActive = null;
            this.btnFull.Location = new System.Drawing.Point(45, 15);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(30, 30);
            this.btnFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFull.TabIndex = 3;
            this.btnFull.TabStop = false;
            this.btnFull.Zoom = 10;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Image = global::Kursa4_krixn_exploid.Properties.Resources.icons8_minus_48;
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(10, 20);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(26, 38);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 0;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblNameProgramm
            // 
            this.lblNameProgramm.AutoSize = true;
            this.lblNameProgramm.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblNameProgramm.ForeColor = System.Drawing.Color.White;
            this.lblNameProgramm.Location = new System.Drawing.Point(43, 15);
            this.lblNameProgramm.Name = "lblNameProgramm";
            this.lblNameProgramm.Size = new System.Drawing.Size(187, 28);
            this.lblNameProgramm.TabIndex = 2;
            this.lblNameProgramm.Text = "Хоккейный турнир";
            // 
            // btnMenuSlider
            // 
            this.btnMenuSlider.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSlider.Image = global::Kursa4_krixn_exploid.Properties.Resources.icons8_menu_52;
            this.btnMenuSlider.ImageActive = null;
            this.btnMenuSlider.Location = new System.Drawing.Point(15, 20);
            this.btnMenuSlider.Name = "btnMenuSlider";
            this.btnMenuSlider.Size = new System.Drawing.Size(22, 22);
            this.btnMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuSlider.TabIndex = 1;
            this.btnMenuSlider.TabStop = false;
            this.btnMenuSlider.Zoom = 10;
            this.btnMenuSlider.Click += new System.EventHandler(this.btnMenuSlider_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.pnlSideMenu.Controls.Add(this.pnlAdmin);
            this.pnlSideMenu.Controls.Add(this.btnStats);
            this.pnlSideMenu.Controls.Add(this.btnGames);
            this.pnlSideMenu.Controls.Add(this.btnCoachs);
            this.pnlSideMenu.Controls.Add(this.btnPlayers);
            this.pnlSideMenu.Controls.Add(this.btnTeams);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 64);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(290, 639);
            this.pnlSideMenu.TabIndex = 2;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(43)))));
            this.pnlAdmin.Controls.Add(this.lblAdmin);
            this.pnlAdmin.Controls.Add(this.pictureBox1);
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(293, 63);
            this.pnlAdmin.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdmin.Location = new System.Drawing.Point(84, 22);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(183, 23);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Менеджер статистики";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursa4_krixn_exploid.Properties.Resources.avata_player;
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStats
            // 
            this.btnStats.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStats.BorderRadius = 0;
            this.btnStats.ButtonText = "     Статистика";
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.DisabledColor = System.Drawing.Color.Gray;
            this.btnStats.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStats.Iconimage = global::Kursa4_krixn_exploid.Properties.Resources.icons8_leaderboard_filled_500;
            this.btnStats.Iconimage_right = null;
            this.btnStats.Iconimage_right_Selected = null;
            this.btnStats.Iconimage_Selected = null;
            this.btnStats.IconMarginLeft = 30;
            this.btnStats.IconMarginRight = 0;
            this.btnStats.IconRightVisible = true;
            this.btnStats.IconRightZoom = 0D;
            this.btnStats.IconVisible = true;
            this.btnStats.IconZoom = 50D;
            this.btnStats.IsTab = false;
            this.btnStats.Location = new System.Drawing.Point(0, 343);
            this.btnStats.Name = "btnStats";
            this.btnStats.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnStats.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnStats.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnStats.selected = false;
            this.btnStats.Size = new System.Drawing.Size(293, 65);
            this.btnStats.TabIndex = 0;
            this.btnStats.Text = "     Статистика";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Textcolor = System.Drawing.Color.White;
            this.btnStats.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnGames
            // 
            this.btnGames.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGames.BorderRadius = 0;
            this.btnGames.ButtonText = "     Игры";
            this.btnGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGames.DisabledColor = System.Drawing.Color.Gray;
            this.btnGames.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGames.Iconimage = global::Kursa4_krixn_exploid.Properties.Resources.icons8_puck_90;
            this.btnGames.Iconimage_right = null;
            this.btnGames.Iconimage_right_Selected = null;
            this.btnGames.Iconimage_Selected = null;
            this.btnGames.IconMarginLeft = 30;
            this.btnGames.IconMarginRight = 0;
            this.btnGames.IconRightVisible = true;
            this.btnGames.IconRightZoom = 0D;
            this.btnGames.IconVisible = true;
            this.btnGames.IconZoom = 50D;
            this.btnGames.IsTab = false;
            this.btnGames.Location = new System.Drawing.Point(0, 273);
            this.btnGames.Name = "btnGames";
            this.btnGames.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnGames.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnGames.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnGames.selected = false;
            this.btnGames.Size = new System.Drawing.Size(293, 65);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "     Игры";
            this.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.Textcolor = System.Drawing.Color.White;
            this.btnGames.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnCoachs
            // 
            this.btnCoachs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnCoachs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnCoachs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoachs.BorderRadius = 0;
            this.btnCoachs.ButtonText = "     Тренеры";
            this.btnCoachs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoachs.DisabledColor = System.Drawing.Color.Gray;
            this.btnCoachs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCoachs.Iconimage = global::Kursa4_krixn_exploid.Properties.Resources.icons8_personal_trainer_filled_500;
            this.btnCoachs.Iconimage_right = null;
            this.btnCoachs.Iconimage_right_Selected = null;
            this.btnCoachs.Iconimage_Selected = null;
            this.btnCoachs.IconMarginLeft = 30;
            this.btnCoachs.IconMarginRight = 0;
            this.btnCoachs.IconRightVisible = true;
            this.btnCoachs.IconRightZoom = 0D;
            this.btnCoachs.IconVisible = true;
            this.btnCoachs.IconZoom = 50D;
            this.btnCoachs.IsTab = false;
            this.btnCoachs.Location = new System.Drawing.Point(0, 203);
            this.btnCoachs.Name = "btnCoachs";
            this.btnCoachs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnCoachs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnCoachs.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnCoachs.selected = false;
            this.btnCoachs.Size = new System.Drawing.Size(293, 65);
            this.btnCoachs.TabIndex = 0;
            this.btnCoachs.Text = "     Тренеры";
            this.btnCoachs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoachs.Textcolor = System.Drawing.Color.White;
            this.btnCoachs.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoachs.Click += new System.EventHandler(this.btnCoachs_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnPlayers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayers.BorderRadius = 0;
            this.btnPlayers.ButtonText = "     Игроки";
            this.btnPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayers.DisabledColor = System.Drawing.Color.Gray;
            this.btnPlayers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPlayers.Iconimage = global::Kursa4_krixn_exploid.Properties.Resources.icons8_ice_hockey_90;
            this.btnPlayers.Iconimage_right = null;
            this.btnPlayers.Iconimage_right_Selected = null;
            this.btnPlayers.Iconimage_Selected = null;
            this.btnPlayers.IconMarginLeft = 30;
            this.btnPlayers.IconMarginRight = 0;
            this.btnPlayers.IconRightVisible = true;
            this.btnPlayers.IconRightZoom = 0D;
            this.btnPlayers.IconVisible = true;
            this.btnPlayers.IconZoom = 50D;
            this.btnPlayers.IsTab = false;
            this.btnPlayers.Location = new System.Drawing.Point(0, 133);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnPlayers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnPlayers.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnPlayers.selected = false;
            this.btnPlayers.Size = new System.Drawing.Size(293, 65);
            this.btnPlayers.TabIndex = 0;
            this.btnPlayers.Text = "     Игроки";
            this.btnPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayers.Textcolor = System.Drawing.Color.White;
            this.btnPlayers.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeams.BorderRadius = 0;
            this.btnTeams.ButtonText = "     Команды";
            this.btnTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeams.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeams.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeams.Iconimage = global::Kursa4_krixn_exploid.Properties.Resources.icons8_user_groups_filled_100;
            this.btnTeams.Iconimage_right = null;
            this.btnTeams.Iconimage_right_Selected = null;
            this.btnTeams.Iconimage_Selected = null;
            this.btnTeams.IconMarginLeft = 30;
            this.btnTeams.IconMarginRight = 0;
            this.btnTeams.IconRightVisible = true;
            this.btnTeams.IconRightZoom = 0D;
            this.btnTeams.IconVisible = true;
            this.btnTeams.IconZoom = 50D;
            this.btnTeams.IsTab = false;
            this.btnTeams.Location = new System.Drawing.Point(0, 63);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.btnTeams.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnTeams.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnTeams.selected = true;
            this.btnTeams.Size = new System.Drawing.Size(293, 65);
            this.btnTeams.TabIndex = 0;
            this.btnTeams.Text = "     Команды";
            this.btnTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeams.Textcolor = System.Drawing.Color.White;
            this.btnTeams.TextFont = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(290, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1021, 639);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // games_fc1
            // 
            this.games_fc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.games_fc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.games_fc1.Location = new System.Drawing.Point(290, 64);
            this.games_fc1.Name = "games_fc1";
            this.games_fc1.Size = new System.Drawing.Size(1021, 639);
            this.games_fc1.TabIndex = 4;
            this.games_fc1.Visible = false;
            // 
            // coachs_fc1
            // 
            this.coachs_fc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.coachs_fc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coachs_fc1.Location = new System.Drawing.Point(290, 64);
            this.coachs_fc1.Name = "coachs_fc1";
            this.coachs_fc1.Size = new System.Drawing.Size(1021, 639);
            this.coachs_fc1.TabIndex = 3;
            this.coachs_fc1.Visible = false;
            // 
            // teams_fs1
            // 
            this.teams_fs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.teams_fs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teams_fs1.Location = new System.Drawing.Point(290, 64);
            this.teams_fs1.Name = "teams_fs1";
            this.teams_fs1.Size = new System.Drawing.Size(1021, 639);
            this.teams_fs1.TabIndex = 2;
            // 
            // players_fc1
            // 
            this.players_fc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.players_fc1.Location = new System.Drawing.Point(290, 64);
            this.players_fc1.Name = "players_fc1";
            this.players_fc1.Size = new System.Drawing.Size(1021, 639);
            this.players_fc1.TabIndex = 1;
            // 
            // stats_fc1
            // 
            this.stats_fc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stats_fc1.Location = new System.Drawing.Point(290, 64);
            this.stats_fc1.Name = "stats_fc1";
            this.stats_fc1.Size = new System.Drawing.Size(1021, 639);
            this.stats_fc1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1311, 703);
            this.Controls.Add(this.games_fc1);
            this.Controls.Add(this.coachs_fc1);
            this.Controls.Add(this.teams_fs1);
            this.Controls.Add(this.players_fc1);
            this.Controls.Add(this.stats_fc1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hockey League";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuSlider)).EndInit();
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlSideMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenuSlider;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameProgramm;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuFlatButton btnTeams;
        private Bunifu.Framework.UI.BunifuFlatButton btnStats;
        private Bunifu.Framework.UI.BunifuFlatButton btnGames;
        private Bunifu.Framework.UI.BunifuFlatButton btnCoachs;
        private Bunifu.Framework.UI.BunifuFlatButton btnPlayers;
        private Bunifu.Framework.UI.BunifuImageButton btnFull;
        private System.Windows.Forms.Panel panel1;
        private Forms.teams_fs teams_fs1;
        private Forms.players_fc players_fc1;
        private coachs_fc coachs_fc1;
        private games_fc games_fc1;
        private Stats_fc stats_fc1;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

