
using WinFormsPD280.Frame.Items;

namespace WinFormsPD280.ItemsForm
{
    public partial class FormForCreateImage : Form
    {
        private ImgItem imgItem;
        public FormForCreateImage(ImgItem imgItem)
        {
            InitializeComponent();
            listOfImgName.Items.AddRange(new string[]
           {
                "logo",
                "image1",
                "image2",
                "image3",
                "image4",
                "image5",
           });
            this.imgItem = imgItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.imgItem.Y = int.Parse(textBoxCorY.Text);
            this.imgItem.X = int.Parse(textBoxCorX.Text);
            this.imgItem.Name = listOfImgName.SelectedItem.ToString();
            this.imgItem.ShowType = showImgType.SelectedIndex;
            this.Close();
        }
    }
}
