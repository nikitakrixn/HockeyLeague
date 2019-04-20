namespace Kursa4_krixn_exploid
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.lblTextInfo = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextInfo
            // 
            this.lblTextInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTextInfo.Location = new System.Drawing.Point(244, 265);
            this.lblTextInfo.Name = "lblTextInfo";
            this.lblTextInfo.Size = new System.Drawing.Size(296, 40);
            this.lblTextInfo.TabIndex = 0;
            this.lblTextInfo.Text = "Загрузка, пожалуйста подождите...";
            this.lblTextInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBackground.Controls.Add(this.pnlMove);
            this.pnlBackground.Location = new System.Drawing.Point(240, 308);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(300, 5);
            this.pnlBackground.TabIndex = 1;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMove.Location = new System.Drawing.Point(250, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(50, 5);
            this.pnlMove.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Kursa4_krixn_exploid.Properties.Resources.Ice_Hockey_Ldogos_999x999;
            this.pictureBox1.Location = new System.Drawing.Point(312, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 7;
            this.Elipse.TargetControl = this.pnlBackground;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.lblTextInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTextInfo;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
    }
}