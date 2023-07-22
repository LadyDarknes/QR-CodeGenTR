using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
// projedenin her�eyi a�a��da basit �ekilde anlat�lm��t�r!
namespace QRcodeGENTR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateQRcode_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode(TextBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);

            // QR kodunun g�r�nt�s�n� al�n
            Bitmap qrImage = QRcode.GetGraphic(50);

            // �effaf bir arka plan ile yeni bir Bitmap olu�turun
            Bitmap transparentImage = new Bitmap(qrImage.Width, qrImage.Height, PixelFormat.Format32bppArgb);

            // Yeni Bitmap �zerine �izim yap�n
            using (Graphics graphics = Graphics.FromImage(transparentImage))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // �effaf arka plan� ayarlay�n
                graphics.Clear(Color.Transparent);

                // QR kodunu yeni Bitmap �zerine �izin
                graphics.DrawImage(qrImage, 0, 0);
            }

            // PictureBox'a �effaf arka planl� QR kodunu atay�n
            QRcodeBox.Image = transparentImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}









// ALLAH-U EKBER!!