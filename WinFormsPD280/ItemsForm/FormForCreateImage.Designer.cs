namespace WinFormsPD280.ItemsForm
{
    partial class FormForCreateImage
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
            listOfImgName = new ComboBox();
            btnAdd = new Button();
            textBoxCorY = new TextBox();
            textBoxCorX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            showImgType = new ComboBox();
            label21 = new Label();
            SuspendLayout();
            // 
            // listOfImgName
            // 
            listOfImgName.DropDownStyle = ComboBoxStyle.DropDownList;
            listOfImgName.FormattingEnabled = true;
            listOfImgName.Location = new Point(12, 12);
            listOfImgName.Name = "listOfImgName";
            listOfImgName.Size = new Size(182, 33);
            listOfImgName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxCorY
            // 
            textBoxCorY.Location = new Point(234, 57);
            textBoxCorY.Name = "textBoxCorY";
            textBoxCorY.Size = new Size(150, 31);
            textBoxCorY.TabIndex = 21;
            // 
            // textBoxCorX
            // 
            textBoxCorX.Location = new Point(234, 14);
            textBoxCorX.Name = "textBoxCorX";
            textBoxCorX.Size = new Size(150, 31);
            textBoxCorX.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(201, 49);
            label4.Name = "label4";
            label4.Size = new Size(38, 38);
            label4.TabIndex = 19;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(201, 12);
            label3.Name = "label3";
            label3.Size = new Size(40, 38);
            label3.TabIndex = 18;
            label3.Text = "X:";
            // 
            // showImgType
            // 
            showImgType.DropDownStyle = ComboBoxStyle.DropDownList;
            showImgType.Items.AddRange(new object[] { "show only", "show after screen clean" });
            showImgType.Location = new Point(136, 94);
            showImgType.Name = "showImgType";
            showImgType.Size = new Size(248, 33);
            showImgType.TabIndex = 55;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(36, 97);
            label21.Name = "label21";
            label21.Size = new Size(96, 25);
            label21.TabIndex = 54;
            label21.Text = "Show type";
            // 
            // FormForCreateImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 137);
            Controls.Add(showImgType);
            Controls.Add(label21);
            Controls.Add(textBoxCorY);
            Controls.Add(textBoxCorX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(listOfImgName);
            Name = "FormForCreateImage";
            Text = "FormForCreateImage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox listOfImgName;
        private Button btnAdd;
        private TextBox textBoxCorY;
        private TextBox textBoxCorX;
        private Label label4;
        private Label label3;
        private ComboBox showImgType;
        private Label label21;
    }
}