using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string str;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            str = Guid.NewGuid().ToString().Substring(1,5);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text==str)
            {
                Main frm = new Main();
                this.Hide();
                frm.Show();
            }
            else
            {
              
            }
        }
    }
}
