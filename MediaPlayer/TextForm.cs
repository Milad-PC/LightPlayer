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
    public partial class TextForm : Form
    {
        private List<MyPDFFiles> src = new List<MyPDFFiles>();
        public TextForm()
        {
            InitializeComponent();
        }

        private void TextForm_Shown(object sender, EventArgs e)
        {
            string[] list = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Text");
            if (list.Length == 0)
            {
                MessageBox.Show("فایل پی دی اف یافت نشد");
                this.Close();
                return;
            }
            string filename = string.Empty;
            foreach (string item in list)
            {
                if (Path.GetExtension(item) != ".pdf") continue;
                filename = Path.GetFileName(item).Replace(Path.GetExtension(item), "");
                ListBox.Items.Add(filename);
                src.Add(new MyPDFFiles { Name = filename, FilePath = item });
            }
            ListBox.SelectedIndex = 0;
            //pdfViewer.DocumentFilePath = Directory.GetCurrentDirectory() + "/Text/پیام تبریک.pdf";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListBox.SelectedItems[0].ToString();
            MyPDFFiles pdf = src.Where(u => u.Name == x).FirstOrDefault();
            if (pdf == null)
            {
                MessageBox.Show("خطایی رخ داده");
            }
            pdfViewer.DocumentFilePath = pdf.FilePath;
        }
    }
    public class MyPDFFiles
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
    }
}
