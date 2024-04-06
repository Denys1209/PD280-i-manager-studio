namespace WinFormsPD280.ItemsForm
{
    partial class FormForCreateTextItem
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
            textBoxForText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxFontSize = new TextBox();
            btnColor = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBoxCorX = new TextBox();
            textBoxCorY = new TextBox();
            SuspendLayout();
            // 
            // textBoxForText
            // 
            textBoxForText.Location = new Point(12, 12);
            textBoxForText.Multiline = true;
            textBoxForText.Name = "textBoxForText";
            textBoxForText.Size = new Size(498, 119);
            textBoxForText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(516, 12);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 1;
            label1.Text = "font size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(516, 50);
            label2.Name = "label2";
            label2.Size = new Size(139, 38);
            label2.TabIndex = 2;
            label2.Text = "text color:";
            // 
            // textBoxFontSize
            // 
            textBoxFontSize.Location = new Point(661, 20);
            textBoxFontSize.Name = "textBoxFontSize";
            textBoxFontSize.Size = new Size(150, 31);
            textBoxFontSize.TabIndex = 3;
            textBoxFontSize.KeyPress += textBoxFontSize_KeyPress;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(661, 57);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(150, 34);
            btnColor.TabIndex = 4;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // button2
            // 
            button2.Location = new Point(516, 97);
            button2.Name = "button2";
            button2.Size = new Size(484, 34);
            button2.TabIndex = 5;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(817, 20);
            label3.Name = "label3";
            label3.Size = new Size(40, 38);
            label3.TabIndex = 6;
            label3.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(817, 57);
            label4.Name = "label4";
            label4.Size = new Size(38, 38);
            label4.TabIndex = 7;
            label4.Text = "Y:";
            // 
            // textBoxCorX
            // 
            textBoxCorX.Location = new Point(850, 24);
            textBoxCorX.Name = "textBoxCorX";
            textBoxCorX.Size = new Size(150, 31);
            textBoxCorX.TabIndex = 8;
            // 
            // textBoxCorY
            // 
            textBoxCorY.Location = new Point(850, 61);
            textBoxCorY.Name = "textBoxCorY";
            textBoxCorY.Size = new Size(150, 31);
            textBoxCorY.TabIndex = 9;
            // 
            // FormForCreateTextItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 144);
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
            Name = "FormForCreateTextItem";
            Text = "FormForCreateTextItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxForText;
        private Label label1;
        private Label label2;
        private TextBox textBoxFontSize;
        private Button btnColor;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCorX;
        private TextBox textBoxCorY;
    }
}