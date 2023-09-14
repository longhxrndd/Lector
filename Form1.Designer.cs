namespace Lector
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnLoadImage = new System.Windows.Forms.Button();
            btnReadText = new System.Windows.Forms.Button();
            txtConsole = new System.Windows.Forms.TextBox();

            txtConsole.Location = new System.Drawing.Point(12, 405);
            txtConsole.Multiline = true;
            txtConsole.Name = "txtConsole";
            txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtConsole.Size = new System.Drawing.Size(776, 100);
            txtConsole.BackColor = System.Drawing.Color.Black; // Fondo negro
            txtConsole.ForeColor = System.Drawing.Color.White; // Letras verdes
            txtConsole.ReadOnly = true; // Hacerlo de solo lectura

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(776, 358);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(pictureBox1_DragEnter);
            pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(pictureBox1_DragDrop);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new System.Drawing.Point(12, 376);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new System.Drawing.Size(112, 23);
            btnLoadImage.TabIndex = 1;
            btnLoadImage.Text = "Cargar Imagen";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += new System.EventHandler(btnLoadImage_Click);

            // 
            // btnReadText
            // 
            btnReadText.Location = new System.Drawing.Point(676, 376);
            btnReadText.Name = "btnReadText";
            btnReadText.Size = new System.Drawing.Size(112, 23);
            btnReadText.TabIndex = 2;
            btnReadText.Text = "Leer Texto";
            btnReadText.UseVisualStyleBackColor = true;
            btnReadText.Click += new System.EventHandler(btnReadText_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 550);
            Controls.Add(btnReadText);
            Controls.Add(btnLoadImage);
            Controls.Add(pictureBox1);
            Controls.Add(txtConsole);
            Name = "Form1";
            Text = "Lector de Imagenes";
            Load += new System.EventHandler(Form1_Load);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtConsole;
        private PictureBox pictureBox1;
        private Button btnLoadImage;
        private Button btnReadText;
    }
}