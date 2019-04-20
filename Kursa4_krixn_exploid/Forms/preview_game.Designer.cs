namespace Kursa4_krixn_exploid.Forms
{
    partial class preview_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preview_game));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pctHteam = new System.Windows.Forms.PictureBox();
            this.pctAteam = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDateMatch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHscore = new System.Windows.Forms.Label();
            this.lblAscore = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblMatchInfo = new System.Windows.Forms.Label();
            this.lblCurrentCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAteam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(954, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctHteam
            // 
            this.pctHteam.Location = new System.Drawing.Point(69, 77);
            this.pctHteam.Name = "pctHteam";
            this.pctHteam.Size = new System.Drawing.Size(296, 253);
            this.pctHteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHteam.TabIndex = 3;
            this.pctHteam.TabStop = false;
            // 
            // pctAteam
            // 
            this.pctAteam.Location = new System.Drawing.Point(620, 77);
            this.pctAteam.Name = "pctAteam";
            this.pctAteam.Size = new System.Drawing.Size(296, 253);
            this.pctAteam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAteam.TabIndex = 3;
            this.pctAteam.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.panel1.Location = new System.Drawing.Point(69, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 14);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.panel2.Location = new System.Drawing.Point(620, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 14);
            this.panel2.TabIndex = 4;
            // 
            // lblDateMatch
            // 
            this.lblDateMatch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateMatch.ForeColor = System.Drawing.Color.White;
            this.lblDateMatch.Location = new System.Drawing.Point(378, 90);
            this.lblDateMatch.Name = "lblDateMatch";
            this.lblDateMatch.Size = new System.Drawing.Size(236, 31);
            this.lblDateMatch.TabIndex = 9;
            this.lblDateMatch.Text = "24.11.2018";
            this.lblDateMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = ":";
            // 
            // lblHscore
            // 
            this.lblHscore.AutoSize = true;
            this.lblHscore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHscore.ForeColor = System.Drawing.Color.White;
            this.lblHscore.Location = new System.Drawing.Point(457, 190);
            this.lblHscore.Name = "lblHscore";
            this.lblHscore.Size = new System.Drawing.Size(22, 24);
            this.lblHscore.TabIndex = 9;
            this.lblHscore.Text = "0";
            // 
            // lblAscore
            // 
            this.lblAscore.AutoSize = true;
            this.lblAscore.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAscore.ForeColor = System.Drawing.Color.White;
            this.lblAscore.Location = new System.Drawing.Point(511, 189);
            this.lblAscore.Name = "lblAscore";
            this.lblAscore.Size = new System.Drawing.Size(22, 24);
            this.lblAscore.TabIndex = 9;
            this.lblAscore.Text = "0";
            // 
            // lblStadium
            // 
            this.lblStadium.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStadium.ForeColor = System.Drawing.Color.White;
            this.lblStadium.Location = new System.Drawing.Point(373, 120);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(243, 56);
            this.lblStadium.TabIndex = 9;
            this.lblStadium.Text = "24.11.2018";
            this.lblStadium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatchInfo
            // 
            this.lblMatchInfo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMatchInfo.ForeColor = System.Drawing.Color.White;
            this.lblMatchInfo.Location = new System.Drawing.Point(376, 300);
            this.lblMatchInfo.Name = "lblMatchInfo";
            this.lblMatchInfo.Size = new System.Drawing.Size(238, 30);
            this.lblMatchInfo.TabIndex = 9;
            this.lblMatchInfo.Text = "Матч состоялся";
            this.lblMatchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentCity
            // 
            this.lblCurrentCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentCity.ForeColor = System.Drawing.Color.White;
            this.lblCurrentCity.Location = new System.Drawing.Point(371, 242);
            this.lblCurrentCity.Name = "lblCurrentCity";
            this.lblCurrentCity.Size = new System.Drawing.Size(243, 45);
            this.lblCurrentCity.TabIndex = 9;
            this.lblCurrentCity.Text = "24.11.2018";
            this.lblCurrentCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preview_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(996, 423);
            this.Controls.Add(this.lblAscore);
            this.Controls.Add(this.lblHscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentCity);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblMatchInfo);
            this.Controls.Add(this.lblDateMatch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctAteam);
            this.Controls.Add(this.pctHteam);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "preview_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "preview_game";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.preview_game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAteam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pctHteam;
        public System.Windows.Forms.PictureBox pctAteam;
        public System.Windows.Forms.Label lblDateMatch;
        public System.Windows.Forms.Label lblHscore;
        public System.Windows.Forms.Label lblAscore;
        public System.Windows.Forms.Label lblStadium;
        public System.Windows.Forms.Label lblMatchInfo;
        public System.Windows.Forms.Label lblCurrentCity;
    }
}