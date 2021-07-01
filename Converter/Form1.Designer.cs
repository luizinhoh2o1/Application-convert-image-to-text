
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnConvertImage = new System.Windows.Forms.Button();
            this.txtBoxView = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtBoxWhiteColor = new System.Windows.Forms.TextBox();
            this.txtBoxBlackColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.White;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(326, 267);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(12, 285);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(126, 23);
            this.btnCarregarImagem.TabIndex = 1;
            this.btnCarregarImagem.Text = "Open Image";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnConvertImage
            // 
            this.btnConvertImage.Location = new System.Drawing.Point(214, 285);
            this.btnConvertImage.Name = "btnConvertImage";
            this.btnConvertImage.Size = new System.Drawing.Size(124, 23);
            this.btnConvertImage.TabIndex = 2;
            this.btnConvertImage.Text = "Convert Image";
            this.btnConvertImage.UseVisualStyleBackColor = true;
            this.btnConvertImage.Click += new System.EventHandler(this.btnConvertImage_Click);
            // 
            // txtBoxView
            // 
            this.txtBoxView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxView.Font = new System.Drawing.Font("Segoe UI", 4.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxView.Location = new System.Drawing.Point(357, 12);
            this.txtBoxView.Multiline = true;
            this.txtBoxView.Name = "txtBoxView";
            this.txtBoxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxView.Size = new System.Drawing.Size(235, 267);
            this.txtBoxView.TabIndex = 3;
            this.txtBoxView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(430, 285);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "White color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Black color";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(135, 380);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtBoxWhiteColor
            // 
            this.txtBoxWhiteColor.Location = new System.Drawing.Point(67, 351);
            this.txtBoxWhiteColor.Name = "txtBoxWhiteColor";
            this.txtBoxWhiteColor.Size = new System.Drawing.Size(100, 23);
            this.txtBoxWhiteColor.TabIndex = 10;
            this.txtBoxWhiteColor.Text = "0";
            this.txtBoxWhiteColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBlackColor
            // 
            this.txtBoxBlackColor.Location = new System.Drawing.Point(175, 351);
            this.txtBoxBlackColor.Name = "txtBoxBlackColor";
            this.txtBoxBlackColor.Size = new System.Drawing.Size(100, 23);
            this.txtBoxBlackColor.TabIndex = 11;
            this.txtBoxBlackColor.Text = "1";
            this.txtBoxBlackColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(597, 415);
            this.Controls.Add(this.txtBoxBlackColor);
            this.Controls.Add(this.txtBoxWhiteColor);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtBoxView);
            this.Controls.Add(this.btnConvertImage);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.picImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IMG Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnConvertImage;
        private System.Windows.Forms.TextBox txtBoxView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtBoxWhiteColor;
        private System.Windows.Forms.TextBox txtBoxBlackColor;
    }
}

