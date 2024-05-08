namespace MediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BtnVideo = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            this.BtnDoc = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVideo
            // 
            this.BtnVideo.BackColor = System.Drawing.Color.Transparent;
            this.BtnVideo.Font = new System.Drawing.Font("Yekan", 15.75F);
            this.BtnVideo.Image = global::MediaPlayer.Properties.Resources.video;
            this.BtnVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVideo.Location = new System.Drawing.Point(12, 12);
            this.BtnVideo.Name = "BtnVideo";
            this.BtnVideo.Size = new System.Drawing.Size(289, 94);
            this.BtnVideo.TabIndex = 0;
            this.BtnVideo.Text = "ویدئو";
            this.BtnVideo.UseVisualStyleBackColor = false;
            this.BtnVideo.Click += new System.EventHandler(this.BtnVideo_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.Font = new System.Drawing.Font("Yekan", 15.75F);
            this.BtnImage.Image = global::MediaPlayer.Properties.Resources.image;
            this.BtnImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImage.Location = new System.Drawing.Point(12, 112);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(289, 94);
            this.BtnImage.TabIndex = 0;
            this.BtnImage.Text = "تصاویر";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // BtnDoc
            // 
            this.BtnDoc.Font = new System.Drawing.Font("Yekan", 15.75F);
            this.BtnDoc.Image = global::MediaPlayer.Properties.Resources.document;
            this.BtnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoc.Location = new System.Drawing.Point(12, 212);
            this.BtnDoc.Name = "BtnDoc";
            this.BtnDoc.Size = new System.Drawing.Size(289, 94);
            this.BtnDoc.TabIndex = 0;
            this.BtnDoc.Text = "مقالات";
            this.BtnDoc.UseVisualStyleBackColor = true;
            this.BtnDoc.Click += new System.EventHandler(this.BtnDoc_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Yekan", 15.75F);
            this.BtnStart.Image = global::MediaPlayer.Properties.Resources.party_balloons;
            this.BtnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStart.Location = new System.Drawing.Point(12, 312);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(289, 94);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "اختتامیه";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "از اینکه از مطالاب ما استقبال می کنید بسیار متشکریم";
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 491D;
            this.reSize1.InitialHostContainerWidth = 991D;
            this.reSize1.Tag = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaPlayer.Properties.Resources.favicon1;
            this.pictureBox1.Location = new System.Drawing.Point(307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Yekan", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExit.Image = global::MediaPlayer.Properties.Resources.icons8_close_window_64px;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(12, 412);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(289, 67);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnDoc);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.BtnVideo);
            this.Controls.Add(this.BtnExit);
            this.Font = new System.Drawing.Font("Yekan", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnVideo;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.Button BtnDoc;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}