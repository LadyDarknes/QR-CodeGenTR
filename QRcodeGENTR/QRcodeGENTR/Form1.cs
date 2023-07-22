using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
// projedenin herþeyi aþaðýda basit þekilde anlatýlmýþtýr!
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

            // QR kodunun görüntüsünü alýn
            Bitmap qrImage = QRcode.GetGraphic(50);

            // Þeffaf bir arka plan ile yeni bir Bitmap oluþturun
            Bitmap transparentImage = new Bitmap(qrImage.Width, qrImage.Height, PixelFormat.Format32bppArgb);

            // Yeni Bitmap üzerine çizim yapýn
            using (Graphics graphics = Graphics.FromImage(transparentImage))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Þeffaf arka planý ayarlayýn
                graphics.Clear(Color.Transparent);

                // QR kodunu yeni Bitmap üzerine çizin
                graphics.DrawImage(qrImage, 0, 0);
            }

            // PictureBox'a þeffaf arka planlý QR kodunu atayýn
            QRcodeBox.Image = transparentImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}









// ALLAH-U EKBER!!