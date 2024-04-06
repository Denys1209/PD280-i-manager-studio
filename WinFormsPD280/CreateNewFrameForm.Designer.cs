namespace WinFormsPD280
{
    partial class CreateNewFrameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listOfItems = new ListBox();
            comBoxOfItems = new ComboBox();
            btnAddNewItem = new Button();
            textboxNameOfFrame = new TextBox();
            label1 = new Label();
            btnCreateFrame = new Button();
            label2 = new Label();
            textBoxForDuration = new TextBox();
            SuspendLayout();
            // 
            // listOfItems
            // 
            listOfItems.FormattingEnabled = true;
            listOfItems.ItemHeight = 25;
            listOfItems.Location = new Point(12, 92);
            listOfItems.Name = "listOfItems";
            listOfItems.Size = new Size(550, 504);
            listOfItems.TabIndex = 0;
            // 
            // comBoxOfItems
            // 
            comBoxOfItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxOfItems.FormattingEnabled = true;
            comBoxOfItems.Location = new Point(12, 602);
            comBoxOfItems.Name = "comBoxOfItems";
            comBoxOfItems.Size = new Size(275, 33);
            comBoxOfItems.TabIndex = 1;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new Point(293, 602);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(269, 34);
            btnAddNewItem.TabIndex = 2;
            btnAddNewItem.Text = "add a new item";
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // textboxNameOfFrame
            // 
            textboxNameOfFrame.Location = new Point(252, 15);
            textboxNameOfFrame.Name = "textboxNameOfFrame";
            textboxNameOfFrame.Size = new Size(310, 31);
            textboxNameOfFrame.TabIndex = 3;
            textboxNameOfFrame.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 4;
            label1.Text = "enter the name of the frame";
            // 
            // btnCreateFrame
            // 
            btnCreateFrame.Location = new Point(12, 642);
            btnCreateFrame.Name = "btnCreateFrame";
            btnCreateFrame.Size = new Size(550, 34);
            btnCreateFrame.TabIndex = 5;
            btnCreateFrame.Text = "Create the Frame";
            btnCreateFrame.UseVisualStyleBackColor = true;
            btnCreateFrame.Click += btnCreateFrame_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 6;
            label2.Text = "duration enter seconds";
            // 
            // textBoxForDuration
            // 
            textBoxForDuration.Location = new Point(252, 55);
            textBoxForDuration.Name = "textBoxForDuration";
            textBoxForDuration.Size = new Size(310, 31);
            textBoxForDuration.TabIndex = 7;
            // 
            // CreateNewFrameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 686);
            Controls.Add(textBoxForDuration);
            Controls.Add(label2);
            Controls.Add(btnCreateFrame);
            Controls.Add(label1);
            Controls.Add(textboxNameOfFrame);
            Controls.Add(btnAddNewItem);
            Controls.Add(comBoxOfItems);
            Controls.Add(listOfItems);
            Name = "CreateNewFrameForm";
            Text = "CreateNewFramForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listOfItems;
        private ComboBox comBoxOfItems;
        private Button btnAddNewItem;
        private TextBox textboxNameOfFrame;
        private Label label1;
        private Button btnCreateFrame;
        private Label label2;
        private TextBox textBoxForDuration;
    }
}