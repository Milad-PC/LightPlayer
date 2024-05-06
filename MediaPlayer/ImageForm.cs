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
    public partial class ImageForm : Form
    {
        private List<MyImageFiles> src = new List<MyImageFiles>();
        public ImageForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageForm_Shown(object sender, EventArgs e)
        {
            string[] list = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Image");
            if (list.Length == 0)
            {
                MessageBox.Show("فایل تصویر یافت نشد");
                this.Close();
                return;
            }
            string filename = string.Empty;
            foreach (string item in list)
            {
                filename = Path.GetFileName(item).Replace(Path.GetExtension(item), "");
                ListBoxPic.Items.Add(filename);
                src.Add(new MyImageFiles { Name = filename, FilePath = item });
            }
            ListBoxPic.SelectedIndex = 0;
        }

        private void ListBoxPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListBoxPic.SelectedItems[0].ToString();
            MyImageFiles pic = src.Where(u => u.Name == x).FirstOrDefault();
            if (pic == null)
            {
                MessageBox.Show("خطایی رخ داده");
            }
            PicBox.Image = Image.FromFile(pic.FilePath);
            PicBox.Refresh();
            PicBox.Visible = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int c = ListBoxPic.Items.Count;
            c = c - 1;
            int x = ListBoxPic.SelectedIndex;
            if (x == c)
            {
                ListBoxPic.SelectedIndex = 0;
            }
            else
            {
                ListBoxPic.SelectedIndex++;
            }
        }

        private void BtnPerv_Click(object sender, EventArgs e)
        {
            int x = ListBoxPic.SelectedIndex;
            if (x == 0)
            {
                ListBoxPic.SelectedIndex = ListBoxPic.Items.Count - 1;
            }
            else
            {
                ListBoxPic.SelectedIndex--;
            }
        }
    }
    public class MyImageFiles
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
