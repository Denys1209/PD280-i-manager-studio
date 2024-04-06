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
            SuspendLayout();
            // 
            // listOfItems
            // 
            listOfItems.FormattingEnabled = true;
            listOfItems.ItemHeight = 25;
            listOfItems.Location = new Point(12, 12);
            listOfItems.Name = "listOfItems";
            listOfItems.Size = new Size(550, 504);
            listOfItems.TabIndex = 0;
            // 
            // comBoxOfItems
            // 
            comBoxOfItems.DropDownStyle = ComboBoxStyle.DropDownList;
            comBoxOfItems.FormattingEnabled = true;
            comBoxOfItems.Location = new Point(12, 522);
            comBoxOfItems.Name = "comBoxOfItems";
            comBoxOfItems.Size = new Size(275, 33);
            comBoxOfItems.TabIndex = 1;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new Point(293, 522);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(269, 34);
            btnAddNewItem.TabIndex = 2;
            btnAddNewItem.Text = "add a new item";
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // CreateNewFramForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 573);
            Controls.Add(btnAddNewItem);
            Controls.Add(comBoxOfItems);
            Controls.Add(listOfItems);
            Name = "CreateNewFramForm";
            Text = "CreateNewFramForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listOfItems;
        private ComboBox comBoxOfItems;
        private Button btnAddNewItem;
    }
}