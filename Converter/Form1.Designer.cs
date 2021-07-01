
namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnConvertImage = new System.Windows.Forms.Button();
            this.txtBoxView = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.Location = new System.Drawing.Point(12, 62);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(326, 267);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(12, 403);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(126, 23);
            this.btnCarregarImagem.TabIndex = 1;
            this.btnCarregarImagem.Text = "Open Image";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnConvertImage
            // 
            this.btnConvertImage.Location = new System.Drawing.Point(199, 403);
            this.btnConvertImage.Name = "btnConvertImage";
            this.btnConvertImage.Size = new System.Drawing.Size(124, 23);
            this.btnConvertImage.TabIndex = 2;
            this.btnConvertImage.Text = "Convert Image";
            this.btnConvertImage.UseVisualStyleBackColor = true;
            this.btnConvertImage.Click += new System.EventHandler(this.btnConvertImage_Click);
            // 
            // txtBoxView
            // 
            this.txtBoxView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxView.Location = new System.Drawing.Point(384, 34);
            this.txtBoxView.Multiline = true;
            this.txtBoxView.Name = "txtBoxView";
            this.txtBoxView.Size = new System.Drawing.Size(432, 716);
            this.txtBoxView.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(227, 350);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 762);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtBoxView);
            this.Controls.Add(this.btnConvertImage);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.picImagem);
            this.Name = "Form1";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnConvertImage;
        private System.Windows.Forms.TextBox txtBoxView;
        private System.Windows.Forms.Button btnView;
    }
}

