using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MediaPlayer
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Shown(object sender, EventArgs e)
        {
            //start program
            this.Opacity = 0;
            for (int i = 0; i < 101; i++)
            {
                this.Opacity += 0.01;
                Thread.Sleep(5);
                Application.DoEvents();
            }
            //check folders
            if (Directory.Exists(Directory.GetCurrentDirectory() + "/Video") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Video");
            }
            if (Directory.Exists(Directory.GetCurrentDirectory() + "/Image") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Image");
            }
            if (Directory.Exists(Directory.GetCurrentDirectory() + "/Text") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Text");
            }
            if (Directory.Exists(Directory.GetCurrentDirectory() + "/Closing") == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Closing");
            }
            //check files Length
            int x = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Video").Length;
            x += Directory.GetFiles(Directory.GetCurrentDirectory() + "/Image").Length;
            x += Directory.GetFiles(Directory.GetCurrentDirectory() + "/Text").Length;
            x += Directory.GetFiles(Directory.GetCurrentDirectory() + "/Closing").Length;
            if (x == 0)
            {
                MessageBox.Show("هیچ فایلی یافت نشد");
                Application.Exit();
            }
            //End Check
            this.Opacity = 1;
            for (int i = 0; i < 101; i++)
            {
                this.Opacity -= 0.01;
                Thread.Sleep(20);
                Application.DoEvents();
            }
            //end program
            this.Hide();
            MainForm frm = new MainForm();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
    }
}
