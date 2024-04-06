using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsPD280.Frame;
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280
{
    public partial class CreateNewFrameForm : Form
    {
        private List<IItem> items;
        private IDisplayFrame displayFrame;
        private Dictionary<string, int> itemsNameToIndex;
        public CreateNewFrameForm(IDisplayFrame displayFrame)
        {
            InitializeComponent();
            this.displayFrame = displayFrame;
            items = displayFrame.GetItems();
            foreach (var i in items) 
            {
                listOfItems.Items.Add(i);
            }

            itemsNameToIndex = new Dictionary<string, int>();
            itemsNameToIndex.Add("static text", 0);
            itemsNameToIndex.Add("dynamic text", 1);
            itemsNameToIndex.Add("QrCode", 2);
            itemsNameToIndex.Add("Image", 3);

            foreach (var item in itemsNameToIndex.Keys)
            {
                comBoxOfItems.Items.Add(item);
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            if (comBoxOfItems.SelectedIndex == -1)
            {
                MessageBox.Show("please chose an item");
            }
            else if (itemsNameToIndex[comBoxOfItems.Items[comBoxOfItems.SelectedIndex] as string] == itemsNameToIndex["static text"]) 
            {

            }
        }
    }
}
