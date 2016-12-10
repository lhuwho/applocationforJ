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
        Bitmap img;
        int PicX = 0;
        int PicY = 0;
        int PicArea = 0;
        Int64 AllC = 0; Int64 ALLM = 0; Int64 ALLY = 0; Int64 ALLK = 0; Int64 ALLR = 0; Int64 ALLG = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.DoubleClick += new EventHandler(pictureBox1_DoubleClick);
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //拖曳檔案是否存在
                if (File.Exists(fileName))
                {
                    String ext = Path.GetExtension(fileName);
                    if (ext.Equals("tiff") || ext.Equals("png"))
                    {
                        img = new Bitmap(fileName);
                        PicX = img.Width;
                        PicY = img.Height;
                        PicArea = PicX * PicY;
                        widthText.Text = PicX.ToString();
                        heightText.Text = PicY.ToString();
                        areaText.Text = PicArea.ToString();

                        //MessageBox.Show(PicX.ToString());
                        //將圖片顯示在pictureBox1
                        pictureBox1.Image = img;
                    }
                    else
                    {
                        MessageBox.Show("圖檔附檔名不為Tif或Png");
                    }

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

        private void Calculate_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            widthText.Text = "";
            heightText.Text = "";
            areaText.Text = "";
            C_Val.Text = "";
            M_Val.Text = "";
            Y_Val.Text = "";
            K_Val.Text = "";
            R_Val.Text = "";
            G_Val.Text = "";
            pictureBox1.Image = null;

        }

        private void QuickCalculate_Click(object sender, EventArgs e)
        {

        }
        void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            //取得或設定目前的檔名擴展名，以決定出現在對話方塊中[檔案類型] 的選項。
            ofdPic.Filter = "PNG|*.png|TIFF|*.tif;*.tiff";
            //取得或設定檔案對話方塊中目前所選取之篩選條件的索引
            ofdPic.FilterIndex = 1;
            //關閉對話框，還原當前的目錄
            ofdPic.RestoreDirectory = true;
            //取得或設定含有檔案對話方塊中所選文件的名稱。
            ofdPic.FileName = "";
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                //得到文件名及路徑
                string sPicPaht = ofdPic.FileName.ToString();
                img = new Bitmap(sPicPaht);
                pictureBox1.Image = img;

                PicX = img.Width;
                PicY = img.Height;
                PicArea = PicX * PicY;
                widthText.Text = PicX.ToString();
                heightText.Text = PicY.ToString();
                areaText.Text = PicArea.ToString();

            }
        }
    }
}
