using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideoForm frm = new VideoForm();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageForm frm = new ImageForm();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void BtnDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextForm frm = new TextForm();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClosingForm frm = new ClosingForm();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
