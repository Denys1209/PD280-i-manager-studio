using System.IO.Ports;
using System.Windows.Forms;
using WinFormsPD280.Frame;
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280
{
    public partial class Form1 : Form
    {

        private DisplayManager displayManager;
        public Form1()
        {
            InitializeComponent();
            displayManager = new DisplayManager();

            //list of numbers don't chage
            listOfBaudRates.Items.AddRange(new string[] {
                "9600",
                "19200",
                "38400",
                "57600",
                "115200",
            });

            listOfImages.Items.AddRange(new string[]
            {
                "logo",
                "image1",
                "image2",
                "image3",
                "image4",
                "image5",
            });

            for (int i = 1; i < 21; ++i)
            {
                ListOfTextIds.Items.Add(i.ToString());
            }
            btnPickColor.BackColor = Color.Black;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            displayManager.OnEndProgram();
                   }

        private void FindAndAddAllComPorts()
        {
            listOfComPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                Array.Sort(ports);
                foreach (string portName in ports)
                {
                    listOfComPorts.Items.Add(portName.ToUpper());
                }
            }
            else
            {
                MessageBox.Show("No COM ports available.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FindAndAddAllComPorts();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (listOfBaudRates.SelectedItem == null || listOfBaudRates!.SelectedItem == "")
            {
                MessageBox.Show("Please chose the baud rate");
                return;
            }

            if (displayManager.Connect(listOfComPorts.SelectedItem?.ToString() ?? "", int.Parse(listOfBaudRates!.SelectedItem.ToString()!)))
            {
                MessageBox.Show("Connect");
            }
            else
            {
                MessageBox.Show("Error during connection check is the device pluged");
            }

        }

        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            FindAndAddAllComPorts();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            displayManager.Disconnect();
        }


        private void RefreshScreen_Click(object sender, EventArgs e)
        {
            displayManager.InitializeDisplay();
        }

        private void InitScreen_Click(object sender, EventArgs e)
        {
            displayManager.InitializeDisplay();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                btnPickColor.BackColor = selectedColor;
            }
        }

        private void SizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = SizeTextBox.SelectionStart;

            string filteredText = new string(SizeTextBox.Text.Where(c => char.IsDigit(c)).ToArray());

            SizeTextBox.Text = filteredText;

            SizeTextBox.SelectionStart = selectionStart;
        }

        private void CorXTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = CorXTextBox.SelectionStart;

            string filteredText = new string(CorXTextBox.Text.Where(c => char.IsDigit(c)).ToArray());

            CorXTextBox.Text = filteredText;

            CorXTextBox.SelectionStart = selectionStart;

        }

        private void CorYTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = CorYTextBox.SelectionStart;

            string filteredText = new string(CorYTextBox.Text.Where(c => char.IsDigit(c)).ToArray());

            CorYTextBox.Text = filteredText;

            CorYTextBox.SelectionStart = selectionStart;


        }

        private void ShowStaticTextButton_Click(object sender, EventArgs e)
        {
            displayManager.ShowFixedText(TextBoxForText.Text, int.Parse(SizeTextBox.Text), int.Parse(CorXTextBox.Text), int.Parse(CorYTextBox.Text), btnPickColor.BackColor.ToArgb());
        }

        private void InputQrCodeSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnShowQrCode_Click(object sender, EventArgs e)
        {
            displayManager.ShowQrCode(inputQrCodeText.Text, int.Parse(inputQrCodeSize.Text), int.Parse(inputQrCodeCorX.Text), int.Parse(inputQrCodeCorY.Text));
        }

        private void ShowDynamicTextButton_Click(object sender, EventArgs e)
        {
            displayManager.ShowDynamicText(TextBoxForText.Text, int.Parse(ListOfTextIds.SelectedItem.ToString()), int.Parse(SizeTextBox.Text), int.Parse(CorXTextBox.Text), int.Parse(CorYTextBox.Text), btnPickColor.BackColor.ToArgb());
        }

        private void ListOfTextIds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputQrCodeCorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit, prevent the character from being entered
                e.Handled = true;
            }
        }

        private void inputQrCodeCorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not a digit, prevent the character from being entered
                e.Handled = true;
            }
        }

        private void btnPickPath_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            displayManager.UploadPicture(listOfImages.SelectedItem.ToString(), pathTextBox.Text, int.Parse(inputWidthImg.Text), int.Parse(inputHeightImg.Text));
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            displayManager.ShowPicture(listOfImages.SelectedItem.ToString(), int.Parse(inputImgCorX.Text), int.Parse(inputImgCorY.Text), showImgType.SelectedIndex);
        }

        private void btnAddNewFrame_Click(object sender, EventArgs e)
        {
            var displayFrame = new DisplayFrame($"slide = {listBoxOfFrames.Items.Count}");
            var newFrameWindow = new CreateNewFrameForm(displayFrame);
            newFrameWindow.Show();
            listBoxOfFrames.Items.Add(displayFrame);
            displayManager.AddNewFrame(displayFrame);
        }

        private void btnStartFrameSlider_Click(object sender, EventArgs e)
        {
            displayManager.StartSlider();
        }

        private void btnStopFrameSlider_Click(object sender, EventArgs e)
        {
            displayManager.StopSlider();
        }

        private void listBoxOfFrames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxOfFrames.SelectedIndex != -1)
            {
                displayManager.DeleteFrame(listBoxOfFrames.Items[listBoxOfFrames.SelectedIndex] as IDisplayFrame);
            }
        }
    }
}
