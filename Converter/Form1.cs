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

        String whiteColorTxt;
        String blackColorTxt;
        String txtConvertTxtImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConvertImage.Enabled = false;

            //carrega caracteres padrão para montar a imagem de texto
            whiteColorTxt = txtBoxWhiteColor.Text;
            blackColorTxt = txtBoxBlackColor.Text;
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            ImportImage();
            btnConvertImage.Enabled = true;
        }

        private void btnConvertImage_Click(object sender, EventArgs e)
        {
            SaveFileTxt();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtBoxView.Text = txtConvertTxtImage;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            whiteColorTxt = txtBoxWhiteColor.Text;
            blackColorTxt = txtBoxBlackColor.Text;

            RefreshImageTxt();
        }

        private void RefreshImageTxt() //atualiza imagem de texto
        {
            txtConvertTxtImage = "";
            FormatToText();
        }

        private void ImportImage()
        {
            OpenFileDialog ofd1 = new OpenFileDialog();

            ofd1.Title = "Open png";
            ofd1.Filter = "Image PNG | *.png";
            ofd1.RestoreDirectory = true;

            if (ofd1.ShowDialog() == DialogResult.OK)
            {

                image = Image.FromFile(ofd1.FileName);
                bitmap = (Bitmap)image;
                picImage.Image = bitmap;

                RefreshImageTxt();
            }
        }

        private void SaveFileTxt()
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Title = "Save file";
            sfd1.Filter = "Text files | *.txt";
            sfd1.RestoreDirectory = true;

            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(sfd1.FileName));

                writer.Write(txtConvertTxtImage); //grava o texto em um arquivo
                writer.Dispose();
                MessageBox.Show("File saved successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileTxt(sfd1.FileName);
            }
        }

        private void FormatToText()
        {
            String rowString = "";

            for (int colunm = 0; colunm < image.Height; colunm++)
            {
                for (int row = 0; row < image.Width; row++)
                {
                    //adiciona o numero/caractere na linha representando a cor na rowString
                    rowString = rowString + GetPixelImage(row, colunm);

                }
                //adiciona a rowString no texto de imagem.
                txtConvertTxtImage = txtConvertTxtImage + rowString;

                //zera a rowString para regravar novamente
                rowString = "";

                //pula para proxima linha
                txtConvertTxtImage = txtConvertTxtImage + "\n";
            }
        }

        private String GetPixelImage(int rowP, int colunmP)
        {
            //armazenar cor
            Color pixelColor;
            String returnTxtColor;

            //pega o codigo da cor do pixel
            pixelColor = bitmap.GetPixel(rowP, colunmP);

            if (pixelColor.ToArgb() == -16777216) //valor representa o preto
            {
                 //cor preta retorna
                returnTxtColor = blackColorTxt;
            }
            else
            {
                //cor branca retorna
                returnTxtColor = whiteColorTxt;
            }

            return returnTxtColor;
        }

        private void OpenFileTxt(String fileName)
        {
            System.Diagnostics.Process.Start("notepad", fileName);
        }
    }
}


/*  
    private void FormatToText()
        {
            for (int colunm = 0; colunm < heightImg; colunm++)
            {
                for (int row = 0; row < widthImg; row++)
                {
                    //adiciona o numero/caractere na linha representando a cor
                    txtConvertTxtImage = String.Format(txtConvertTxtImage + convertTxtImage[row, colunm]);
                }
                //pula para proxima linha
                txtConvertTxtImage = String.Format(txtConvertTxtImage + "\n");
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
                        convertTxtImage[row, column] = blackColorTxt;
                    }
                    else
                    {
                        //cor branca registrada como 0
                        convertTxtImage[row, column] = whiteColorTxt;
                    }
                }
            }
        }
*/