namespace WinFormsPD280.ItemsForm
{
    partial class FormForCreateQrCode
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
            textBoxSize = new TextBox();
            label1 = new Label();
            textBoxForText = new TextBox();
            SuspendLayout();
            // 
            // textBoxCorY
            // 
            textBoxCorY.Location = new Point(785, 63);
            textBoxCorY.Name = "textBoxCorY";
            textBoxCorY.Size = new Size(150, 31);
            textBoxCorY.TabIndex = 17;
            // 
            // textBoxCorX
            // 
            textBoxCorX.Location = new Point(785, 22);
            textBoxCorX.Name = "textBoxCorX";
            textBoxCorX.Size = new Size(150, 31);
            textBoxCorX.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(752, 59);
            label4.Name = "label4";
            label4.Size = new Size(38, 38);
            label4.TabIndex = 15;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(752, 22);
            label3.Name = "label3";
            label3.Size = new Size(40, 38);
            label3.TabIndex = 14;
            label3.Text = "X:";
            // 
            // button2
            // 
            button2.Location = new Point(516, 63);
            button2.Name = "button2";
            button2.Size = new Size(229, 34);
            button2.TabIndex = 13;
            button2.Text = "add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(595, 19);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(150, 31);
            textBoxSize.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(516, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 38);
            label1.TabIndex = 11;
            label1.Text = "Size:";
            // 
            // textBoxForText
            // 
            textBoxForText.Location = new Point(12, 12);
            textBoxForText.Multiline = true;
            textBoxForText.Name = "textBoxForText";
            textBoxForText.Size = new Size(498, 85);
            textBoxForText.TabIndex = 10;
            // 
            // FormForCreateQrCode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 115);
            Controls.Add(textBoxCorY);
            Controls.Add(textBoxCorX);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBoxSize);
            Controls.Add(label1);
            Controls.Add(textBoxForText);
            Name = "FormForCreateQrCode";
            Text = "FormForCreateQrCode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCorY;
        private TextBox textBoxCorX;
        private Label label4;
        private Label label3;
        private Button button2;
        private TextBox textBoxSize;
        private Label label1;
        private TextBox textBoxForText;
    }
}