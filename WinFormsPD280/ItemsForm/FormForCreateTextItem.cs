﻿using System;
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
    public partial class FormForCreateTextItem : Form
    {
        private StaticTextItem staticTextItem;
        public FormForCreateTextItem(StaticTextItem staticTextItem)
        {
            InitializeComponent();
            this.staticTextItem = staticTextItem; 
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
            staticTextItem.Text = textBoxForText.Text;
            staticTextItem.FontSize = int.Parse(textBoxFontSize.Text);
            staticTextItem.Color = btnColor.BackColor.ToArgb();
            staticTextItem.X = int.Parse(textBoxCorX.Text);
            staticTextItem.Y = int.Parse(textBoxCorY.Text);
            this.Close();
        }
    }
}
