﻿namespace MediaPlayer
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.BtnExit = new System.Windows.Forms.Button();
            this.ListBoxPic = new System.Windows.Forms.ListBox();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.BtnPerv = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnExit.Location = new System.Drawing.Point(14, 573);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(191, 49);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ListBoxPic
            // 
            this.ListBoxPic.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBoxPic.FormattingEnabled = true;
            this.ListBoxPic.ItemHeight = 29;
            this.ListBoxPic.Location = new System.Drawing.Point(14, 12);
            this.ListBoxPic.Name = "ListBoxPic";
            this.ListBoxPic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBoxPic.Size = new System.Drawing.Size(191, 497);
            this.ListBoxPic.TabIndex = 4;
            this.ListBoxPic.SelectedIndexChanged += new System.EventHandler(this.ListBoxPic_SelectedIndexChanged);
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(211, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(860, 610);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox.TabIndex = 7;
            this.PicBox.TabStop = false;
            // 
            // BtnPerv
            // 
            this.BtnPerv.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnPerv.Location = new System.Drawing.Point(113, 518);
            this.BtnPerv.Name = "BtnPerv";
            this.BtnPerv.Size = new System.Drawing.Size(92, 49);
            this.BtnPerv.TabIndex = 6;
            this.BtnPerv.Text = "قبلی";
            this.BtnPerv.UseVisualStyleBackColor = true;
            this.BtnPerv.Click += new System.EventHandler(this.BtnPerv_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnNext.Location = new System.Drawing.Point(14, 518);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(93, 49);
            this.BtnNext.TabIndex = 6;
            this.BtnNext.Text = "بعدی";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 634);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPerv);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ListBoxPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نمایش تصویر";
            this.Shown += new System.EventHandler(this.ImageForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox ListBoxPic;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button BtnPerv;
        private System.Windows.Forms.Button BtnNext;
    }
}