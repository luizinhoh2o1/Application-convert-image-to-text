using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Drawing.Imaging;
using System.IO;

namespace Converter
{
    public partial class Form1 : Form
    {
        Image image;
        Bitmap bitmap;

        const int heightImg = 50;
        const int widthImg = 50;

        int[,] binaryImage = new int[widthImg, heightImg];

        String txtBinaryImg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConvertImage.Enabled = false;
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            txtBinaryImg = "";

            ImportImage();
            btnConvertImage.Enabled = true;
        }

        private void btnConvertImage_Click(object sender, EventArgs e)
        {
            SaveFileTxt();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtBoxView.Text = txtBinaryImg;
        }

        private void ImportImage()
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            DialogResult re = ofd1.ShowDialog();

            ofd1.Filter = "Image PNG | *.png";
            ofd1.RestoreDirectory = true;

            if (re == DialogResult.OK)
            {
                image = Image.FromFile(ofd1.FileName);
                bitmap = (Bitmap)image;
                picImagem.Image = bitmap;

                GetPixelsImage();

                FormatToText();
            }
        }

        private void SaveFileTxt()
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            StreamWriter writer = new StreamWriter("img.txt");

            sfd1.Filter = "Text files | *.txt";
            sfd1.RestoreDirectory = true;

            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                writer.Write(txtBinaryImg);
                writer.Close();
            }
        }

        private void FormatToText()
        {
            for (int colunm = 0; colunm < heightImg; colunm++)
            {
                txtBinaryImg = String.Format(txtBinaryImg + "\n");

                for (int row = 0; row < widthImg; row++)
                {
                    txtBinaryImg = String.Format(txtBinaryImg + binaryImage[row, colunm]);
                }
            }
        }

        private void GetPixelsImage()
        {
            //armazenar cor
            Color pixelColor;

            for (int column = 0; column < heightImg; column++)
            {
                for (int row = 0; row < widthImg; row++)
                {

                    //pega o codigo da cor do pixel
                    pixelColor = bitmap.GetPixel(row, column);

                    if (pixelColor.ToArgb() == -16777216) //valor representa o preto
                    {
                        //cor preta registrada como 1
                        binaryImage[row, column] = 1;
                    }
                    else
                    {
                        //cor branca registrada como 0
                        binaryImage[row, column] = 0;
                    }
                }
            }
        }

    }
}
