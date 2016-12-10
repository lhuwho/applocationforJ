using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace applocationforJ
{
    public partial class Form1 : Form
    {
        string fileName = string.Empty; //宣告一個存取拖曳檔案的路徑
        int PicX = 0;
        int PicY = 0;
        Int64 AllC = 0;Int64 ALLM = 0;Int64 ALLY = 0;Int64 ALLK = 0;Int64 ALLR = 0;Int64 ALLG = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //拖曳檔案是否存在
                if (File.Exists(fileName))
                {
                    Bitmap img = new Bitmap(fileName);
                    PicX = img.Width; PicY = img.Height;
                    //MessageBox.Show(PicX.ToString());
                    //將圖片顯示在pictureBox1
                    pictureBox1.Image = img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("不是有效的圖檔格式");
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileNameW"))
            {
                string[] data = (e.Data.GetData("FileNameW") as string[]);
                fileName = data[0];
                e.Effect = DragDropEffects.All;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //允許pictureBox1接受拖曳檔案
            pictureBox1.AllowDrop = true;
        }
    }
}
