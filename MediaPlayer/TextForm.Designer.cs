namespace MediaPlayer
{
    partial class TextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.ListBox = new System.Windows.Forms.ListBox();
            this.pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 29;
            this.ListBox.Location = new System.Drawing.Point(14, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ListBox.Size = new System.Drawing.Size(191, 555);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Location = new System.Drawing.Point(211, 12);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None;
            this.pdfViewer.ShowPrintStatusDialog = false;
            this.pdfViewer.Size = new System.Drawing.Size(860, 610);
            this.pdfViewer.TabIndex = 8;
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
            this.BtnClose.Location = new System.Drawing.Point(14, 573);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(191, 49);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "بازگشت";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 634);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نمایش متن";
            this.Shown += new System.EventHandler(this.TextForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ListBox ListBox;
        private DevExpress.XtraPdfViewer.PdfViewer pdfViewer;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}