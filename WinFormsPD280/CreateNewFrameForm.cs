using WinFormsPD280.Frame;
using WinFormsPD280.Frame.Items;
using WinFormsPD280.ItemsForm;

namespace WinFormsPD280
{
    public partial class CreateNewFrameForm : Form
    {
        private List<IItem> items;
        private DisplayFrame displayFrame;
        private Dictionary<string, int> itemsNameToIndex;
        public CreateNewFrameForm(DisplayFrame displayFrame)
        {
            InitializeComponent();
            this.displayFrame = displayFrame;
            items = displayFrame.GetItems();
            foreach (var i in items)
            {
                listOfItems.Items.Add(i);
            }
            textboxNameOfFrame.Text = this.displayFrame.Name;
            textBoxForDuration.Text = this.displayFrame.WaitAfterDisplay.ToString();

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
                var staticTextItem = new StaticTextItem("", 8, 0, 0, 0);
                var createStaticTextForm = new FormForCreateTextItem(staticTextItem);
                createStaticTextForm.ShowDialog();
                displayFrame.AddStaticText(staticTextItem);
                listOfItems.Items.Add(staticTextItem);
            }
            else if (itemsNameToIndex[comBoxOfItems.Items[comBoxOfItems.SelectedIndex] as string] == itemsNameToIndex["dynamic text"])
            {
                var dynamicTextItem = new DynamicTextItem("", 8, 0, 0, 0, 0);
                var createDynamicTextForm = new FormForCreateDynamicText(dynamicTextItem);
                createDynamicTextForm.ShowDialog();
                displayFrame.AddDynamicText(dynamicTextItem);
                listOfItems.Items.Add(dynamicTextItem);
            }
            else if (itemsNameToIndex[comBoxOfItems.Items[comBoxOfItems.SelectedIndex] as string] == itemsNameToIndex["QrCode"])
            {
                var qrCodeItem = new QrCodeItem("", 20, 0, 0);
                var createFormForQrCode = new FormForCreateQrCode(qrCodeItem);
                createFormForQrCode.ShowDialog();
                displayFrame.AddQrCode(qrCodeItem);
                listOfItems.Items.Add(qrCodeItem);
            }
            else if (itemsNameToIndex[comBoxOfItems.Items[comBoxOfItems.SelectedIndex] as string] == itemsNameToIndex["Image"])
            {
                var imgItem = new ImgItem("logo", 0, 1, 1);
                var createImgForm = new FormForCreateImage(imgItem);
                createImgForm.ShowDialog();
                displayFrame.AddImg(imgItem);
                listOfItems.Items.Add(imgItem);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateFrame_Click(object sender, EventArgs e)
        {
            displayFrame.Name = textboxNameOfFrame.Text;
            displayFrame.WaitAfterDisplay = int.Parse(textBoxForDuration.Text);
            this.Close();
        }
    }
}
