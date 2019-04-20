namespace Kursa4_krixn_exploid.Forms
{
    partial class LineUP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineUP));
            this.dvgLineUP = new System.Windows.Forms.DataGridView();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblNameCoach = new System.Windows.Forms.Label();
            this.lblNameTeam = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLineUP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgLineUP
            // 
            this.dvgLineUP.AllowUserToAddRows = false;
            this.dvgLineUP.AllowUserToDeleteRows = false;
            this.dvgLineUP.AllowUserToResizeColumns = false;
            this.dvgLineUP.AllowUserToResizeRows = false;
            this.dvgLineUP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgLineUP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.dvgLineUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLineUP.Location = new System.Drawing.Point(12, 166);
            this.dvgLineUP.Name = "dvgLineUP";
            this.dvgLineUP.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgLineUP.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgLineUP.Size = new System.Drawing.Size(587, 512);
            this.dvgLineUP.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(12, 11);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(76, 73);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // lblNameCoach
            // 
            this.lblNameCoach.AutoSize = true;
            this.lblNameCoach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameCoach.ForeColor = System.Drawing.Color.White;
            this.lblNameCoach.Location = new System.Drawing.Point(96, 120);
            this.lblNameCoach.Name = "lblNameCoach";
            this.lblNameCoach.Size = new System.Drawing.Size(0, 30);
            this.lblNameCoach.TabIndex = 3;
            this.lblNameCoach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameTeam
            // 
            this.lblNameTeam.AutoSize = true;
            this.lblNameTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameTeam.ForeColor = System.Drawing.Color.White;
            this.lblNameTeam.Location = new System.Drawing.Point(96, 32);
            this.lblNameTeam.Name = "lblNameTeam";
            this.lblNameTeam.Size = new System.Drawing.Size(0, 32);
            this.lblNameTeam.TabIndex = 4;
            this.lblNameTeam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(303, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 51);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить игрока";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(86)))), ((int)(((byte)(151)))));
            this.btnDeletePlayer.FlatAppearance.BorderSize = 0;
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeletePlayer.ForeColor = System.Drawing.Color.White;
            this.btnDeletePlayer.Location = new System.Drawing.Point(454, 109);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(145, 51);
            this.btnDeletePlayer.TabIndex = 12;
            this.btnDeletePlayer.Text = "Удалить игрока";
            this.btnDeletePlayer.UseVisualStyleBackColor = false;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(570, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursa4_krixn_exploid.Properties.Resources.avata_player;
            this.pictureBox1.Location = new System.Drawing.Point(34, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LineUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(612, 690);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNameTeam);
            this.Controls.Add(this.lblNameCoach);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.dvgLineUP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LineUP";
            this.Text = "LineUP";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LineUP_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dvgLineUP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgLineUP;
        private System.Windows.Forms.PictureBox pctLogo;
        public System.Windows.Forms.Label lblNameCoach;
        public System.Windows.Forms.Label lblNameTeam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeletePlayer;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}