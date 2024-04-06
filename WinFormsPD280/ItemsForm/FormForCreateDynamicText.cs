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
    public partial class FormForCreateDynamicText : Form
    {

        private DynamicTextItem dynamicTextItem;

        public FormForCreateDynamicText(DynamicTextItem dynamicText)
        {
            InitializeComponent();
            dynamicTextItem = dynamicText;

            for (int i = 1; i <= 20; ++i) 
            {
                comboxListOfIds.Items.Add(i.ToString());
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                btnColor.BackColor = selectedColor;
            }

        }

        private void textBoxFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamicTextItem.Text = textBoxForText.Text;
            dynamicTextItem.FontSize = int.Parse(textBoxFontSize.Text);
            dynamicTextItem.Color = btnColor.BackColor.ToArgb();
            dynamicTextItem.X = int.Parse(textBoxCorX.Text);
            dynamicTextItem.Y = int.Parse(textBoxCorY.Text);
            dynamicTextItem.Id = int.Parse(comboxListOfIds.SelectedItem.ToString());
            this.Close();
        }
    }
}
