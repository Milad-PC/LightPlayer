namespace MediaPlayer
{
    partial class VideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoForm));
            this.ListBoxVideo = new System.Windows.Forms.ListBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.MPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.MPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxVideo
            // 
            this.ListBoxVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxVideo.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBoxVideo.FormattingEnabled = true;
            this.ListBoxVideo.ItemHeight = 29;
            this.ListBoxVideo.Location = new System.Drawing.Point(17, 12);
            this.ListBoxVideo.Name = "ListBoxVideo";
            this.ListBoxVideo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxVideo.Size = new System.Drawing.Size(191, 553);
            this.ListBoxVideo.TabIndex = 1;
            this.ListBoxVideo.SelectedIndexChanged += new System.EventHandler(this.ListBoxVideo_SelectedIndexChanged);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 634D;
            this.reSize1.InitialHostContainerWidth = 1083D;
            this.reSize1.Tag = null;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnClose.Image = global::MediaPlayer.Properties.Resources.undo;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(17, 573);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(191, 49);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "بازگشت";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MPlayer
            // 
            this.MPlayer.Enabled = true;
            this.MPlayer.Location = new System.Drawing.Point(214, 12);
            this.MPlayer.Name = "MPlayer";
            this.MPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MPlayer.OcxState")));
            this.MPlayer.Size = new System.Drawing.Size(857, 610);
            this.MPlayer.TabIndex = 2;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 634);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.MPlayer);
            this.Controls.Add(this.ListBoxVideo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نمایش ویدئو";
            this.Shown += new System.EventHandler(this.VideoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxVideo;
        private AxWMPLib.AxWindowsMediaPlayer MPlayer;
        private System.Windows.Forms.Button BtnClose;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}