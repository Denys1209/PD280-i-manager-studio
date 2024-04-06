namespace WinFormsPD280.ItemsForm
{
    partial class FormForCreateDynamicText
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
            textBoxCorY = new TextBox();
            textBoxCorX = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            btnColor = new Button();
            textBoxFontSize = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBoxForText = new TextBox();
            label5 = new Label();
            comboxListOfIds = new ComboBox();
            SuspendLayout();
            // 
            // textBoxCorY
            // 
            textBoxCorY.Location = new Point(844, 55);
            textBoxCorY.Name = "textBoxCorY";
            textBoxCorY.Size = new Size(150, 31);
            textBoxCorY.TabIndex = 19;
            // 
            // textBoxCorX
            // 
            textBoxCorX.Location = new Point(844, 18);
            textBoxCorX.Name = "textBoxCorX";
            textBoxCorX.Size = new Size(150, 31);
            textBoxCorX.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(811, 51);
            label4.Name = "label4";
            label4.Size = new Size(38, 38);
            label4.TabIndex = 17;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(811, 14);
            label3.Name = "label3";
            label3.Size = new Size(40, 38);
            label3.TabIndex = 16;
            label3.Text = "X:";
            // 
            // button2
            // 
            button2.Location = new Point(510, 91);
            button2.Name = "button2";
            button2.Size = new Size(484, 34);
            button2.TabIndex = 15;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(655, 51);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(150, 34);
            btnColor.TabIndex = 14;
            btnColor.UseVisualStyleBackColor = true;
            // 
            // textBoxFontSize
            // 
            textBoxFontSize.Location = new Point(655, 14);
            textBoxFontSize.Name = "textBoxFontSize";
            textBoxFontSize.Size = new Size(150, 31);
            textBoxFontSize.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(510, 44);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 12;
            label2.Text = "text color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(510, 6);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 11;
            label1.Text = "font size:";
            // 
            // textBoxForText
            // 
            textBoxForText.Location = new Point(6, 6);
            textBoxForText.Multiline = true;
            textBoxForText.Name = "textBoxForText";
            textBoxForText.Size = new Size(498, 119);
            textBoxForText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(1000, 14);
            label5.Name = "label5";
            label5.Size = new Size(46, 38);
            label5.TabIndex = 21;
            label5.Text = "Id:";
            // 
            // comboxListOfIds
            // 
            comboxListOfIds.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxListOfIds.FormattingEnabled = true;
            comboxListOfIds.Location = new Point(1040, 18);
            comboxListOfIds.Name = "comboxListOfIds";
            comboxListOfIds.Size = new Size(125, 33);
            comboxListOfIds.TabIndex = 22;
            // 
            // FormForCreateDynamicText
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 138);
            Controls.Add(comboxListOfIds);
            Controls.Add(label5);
            Controls.Add(textBoxCorY);
            Controls.Add(textBoxCorX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnColor);
            Controls.Add(textBoxFontSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxForText);
            Name = "FormForCreateDynamicText";
            Text = "FormForCreateDynamicText";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCorY;
        private TextBox textBoxCorX;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button btnColor;
        private TextBox textBoxFontSize;
        private Label label2;
        private Label label1;
        private TextBox textBoxForText;
        private Label label5;
        private ComboBox comboxListOfIds;
    }
}