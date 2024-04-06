using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280.ItemsForm
{
    public partial class FormForCreateQrCode : Form
    {
        private QrCodeItem qrCodeItem;
        public FormForCreateQrCode(QrCodeItem qrCodeItem)
        {
            InitializeComponent();
            this.qrCodeItem = qrCodeItem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qrCodeItem.Text = textBoxForText.Text;
            qrCodeItem.Size = int.Parse(textBoxSize.Text);
            qrCodeItem.X = int.Parse(textBoxCorX.Text);
            qrCodeItem.Y = int.Parse(textBoxCorY.Text);
            this.Close();
        }
    }
}
