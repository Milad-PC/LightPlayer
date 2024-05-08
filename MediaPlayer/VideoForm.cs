using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class VideoForm : Form
    {
        private List<MyVideoFiles> src = new List<MyVideoFiles>();
        public VideoForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoForm_Shown(object sender, EventArgs e)
        {
            string[] list = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Video");
            if(list.Length == 0)
            {
                MessageBox.Show("فایل ویدئو یافت نشد");
                this.Close();
                return;
            }
            foreach (string item in list)
            {
                if (Path.GetExtension(item) != ".mp4") continue;
                ListBoxVideo.Items.Add(Path.GetFileName(item).Replace(Path.GetExtension(item), ""));
                src.Add(new MyVideoFiles { Name = Path.GetFileName(item).Replace(Path.GetExtension(item), ""), FilePath = item });
            }
            ListBoxVideo.SelectedIndex = 0;
        }

        private void ListBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListBoxVideo.SelectedItems[0].ToString();
            MyVideoFiles vid = src.Where(u => u.Name == x).FirstOrDefault();
            if (vid == null)
            {
                MessageBox.Show("خطایی رخ داده");
            }
            MPlayer.URL = vid.FilePath;
            MPlayer.Ctlcontrols.play();
        }
    }

    public class MyVideoFiles
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
