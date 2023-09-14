using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Tesseract;
namespace Lector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }


        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                pictureBox1.Image = Image.FromFile(files[0]);
            }
        }

        private void btnReadText_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                // Cargando la imagen en Emgu.CV
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                UMat uImage = bmp.ToImage<Bgr, Byte>().ToUMat();

                // Convirtiendo la imagen a escala de grises
                Image<Gray, byte> gray = uImage.ToImage<Gray, byte>();

                // Aplicando desenfoque Gaussiano para resaltar el texto
                Image<Gray, byte> blurred = gray.SmoothGaussian(5);

                // Creando una nueva instancia de TesseractEngine (añade la ruta correcta a tesseract.exe)
                using (var ocr = new TesseractEngine(@".\tessdata", "spa", EngineMode.TesseractAndLstm))
                {
                    // Realizando OCR en la imagen procesada
                    using (var pix = Pix.LoadFromMemory(blurred.ToBitmap().ToByteArray(System.Drawing.Imaging.ImageFormat.Png)))
                    using (var page = ocr.Process(pix))
                    {
                        string texto = page.GetText();

                        WriteToConsole(texto);  // Usa esto en lugar de MessageBox.Show(texto);
                                                // ...

                    }


                }

            }
            else
            {
                MessageBox.Show("Por favor, carga una imagen primero.");
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagenes|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void WriteToConsole(string message)
        {
            txtConsole.Text = ""; // Limpia el contenido anterior
            txtConsole.AppendText(message + Environment.NewLine);
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }
    }

    public static class ImageExtensions
    {
        public static byte[] ToByteArray(this Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
    }

}