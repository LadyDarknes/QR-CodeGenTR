namespace QRcodeGENTR
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
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            button1 = new Button();
            TextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            GenerateQRcode = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            QRcodeBox = new PictureBox();
            siticoneCustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QRcodeBox).BeginInit();
            SuspendLayout();
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.Controls.Add(button1);
            siticoneCustomGradientPanel1.Controls.Add(TextBox1);
            siticoneCustomGradientPanel1.Controls.Add(GenerateQRcode);
            siticoneCustomGradientPanel1.Controls.Add(QRcodeBox);
            siticoneCustomGradientPanel1.FillColor = Color.Orchid;
            siticoneCustomGradientPanel1.FillColor2 = Color.MediumOrchid;
            siticoneCustomGradientPanel1.FillColor3 = Color.CornflowerBlue;
            siticoneCustomGradientPanel1.FillColor4 = Color.Violet;
            siticoneCustomGradientPanel1.Location = new Point(0, 0);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.Size = new Size(684, 422);
            siticoneCustomGradientPanel1.TabIndex = 0;
            siticoneCustomGradientPanel1.Paint += siticoneCustomGradientPanel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(640, 0);
            button1.Name = "button1";
            button1.Size = new Size(41, 42);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TextBox1
            // 
            TextBox1.Animated = true;
            TextBox1.BackColor = Color.DimGray;
            TextBox1.BorderColor = Color.LightSkyBlue;
            TextBox1.DefaultText = "Lütfen link giriniz!";
            TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBox1.FillColor = Color.Violet;
            TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox1.ForeColor = Color.WhiteSmoke;
            TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBox1.Location = new Point(13, 275);
            TextBox1.Margin = new Padding(4, 4, 4, 4);
            TextBox1.Name = "TextBox1";
            TextBox1.PasswordChar = '\0';
            TextBox1.PlaceholderForeColor = Color.MediumVioletRed;
            TextBox1.PlaceholderText = "";
            TextBox1.SelectedText = "";
            TextBox1.Size = new Size(640, 47);
            TextBox1.TabIndex = 2;
            // 
            // GenerateQRcode
            // 
            GenerateQRcode.Animated = true;
            GenerateQRcode.DisabledState.BorderColor = Color.DarkGray;
            GenerateQRcode.DisabledState.CustomBorderColor = Color.DarkGray;
            GenerateQRcode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GenerateQRcode.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            GenerateQRcode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GenerateQRcode.FillColor = Color.Orchid;
            GenerateQRcode.FillColor2 = Color.DarkViolet;
            GenerateQRcode.FocusedColor = Color.BlueViolet;
            GenerateQRcode.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GenerateQRcode.ForeColor = Color.Black;
            GenerateQRcode.Location = new Point(249, 363);
            GenerateQRcode.Name = "GenerateQRcode";
            GenerateQRcode.Size = new Size(180, 45);
            GenerateQRcode.TabIndex = 1;
            GenerateQRcode.Text = "QRcode üret";
            GenerateQRcode.Click += GenerateQRcode_Click;
            // 
            // QRcodeBox
            // 
            QRcodeBox.BackColor = Color.Transparent;
            QRcodeBox.Location = new Point(0, 3);
            QRcodeBox.Name = "QRcodeBox";
            QRcodeBox.Size = new Size(643, 253);
            QRcodeBox.SizeMode = PictureBoxSizeMode.Zoom;
            QRcodeBox.TabIndex = 0;
            QRcodeBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 420);
            Controls.Add(siticoneCustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            siticoneCustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QRcodeBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton GenerateQRcode;
        private PictureBox QRcodeBox;
        private Button button1;
    }
}