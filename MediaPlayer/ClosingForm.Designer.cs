namespace MediaPlayer
{
    partial class ClosingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosingForm));
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPerv = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ListBoxPic = new System.Windows.Forms.ListBox();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnNext.Image = global::MediaPlayer.Properties.Resources.next_page_32px;
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNext.Location = new System.Drawing.Point(14, 518);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(93, 49);
            this.BtnNext.TabIndex = 9;
            this.BtnNext.Text = "بعدی";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPerv
            // 
            this.BtnPerv.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnPerv.Image = global::MediaPlayer.Properties.Resources.back_to_32px;
            this.BtnPerv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPerv.Location = new System.Drawing.Point(113, 518);
            this.BtnPerv.Name = "BtnPerv";
            this.BtnPerv.Size = new System.Drawing.Size(92, 49);
            this.BtnPerv.TabIndex = 10;
            this.BtnPerv.Text = "قبلی";
            this.BtnPerv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPerv.UseVisualStyleBackColor = true;
            this.BtnPerv.Click += new System.EventHandler(this.BtnPerv_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExit.Image = global::MediaPlayer.Properties.Resources.icons8_close_window_64px;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(14, 573);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(191, 49);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ListBoxPic
            // 
            this.ListBoxPic.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBoxPic.FormattingEnabled = true;
            this.ListBoxPic.ItemHeight = 29;
            this.ListBoxPic.Location = new System.Drawing.Point(12, 12);
            this.ListBoxPic.Name = "ListBoxPic";
            this.ListBoxPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxPic.Size = new System.Drawing.Size(191, 497);
            this.ListBoxPic.TabIndex = 8;
            this.ListBoxPic.SelectedIndexChanged += new System.EventHandler(this.ListBoxPic_SelectedIndexChanged);
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
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(211, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(860, 610);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 12;
            this.PicBox.TabStop = false;
            // 
            // ClosingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 634);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPerv);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ListBoxPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClosingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اختتامیه";
            this.Shown += new System.EventHandler(this.ClosingForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPerv;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox ListBoxPic;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}