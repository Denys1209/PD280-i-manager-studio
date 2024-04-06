namespace WinFormsPD280
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Connect = new Button();
            listOfComPorts = new ComboBox();
            label2 = new Label();
            RefreshPortsButton = new Button();
            Close = new Button();
            RefreshScreen = new Button();
            InitScreen = new Button();
            TextBoxForText = new TextBox();
            label1 = new Label();
            listOfBaudRates = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            ListOfTextIds = new ComboBox();
            label5 = new Label();
            btnPickColor = new Button();
            label6 = new Label();
            SizeTextBox = new TextBox();
            label7 = new Label();
            CorXTextBox = new TextBox();
            CorYTextBox = new TextBox();
            label8 = new Label();
            ShowStaticTextButton = new Button();
            ShowDynamicTextButton = new Button();
            label9 = new Label();
            label12 = new Label();
            inputQrCodeSize = new TextBox();
            listBoxOfFrames = new ListBox();
            label13 = new Label();
            inputQrCodeText = new TextBox();
            btnShowQrCode = new Button();
            label14 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            listOfImages = new ComboBox();
            label15 = new Label();
            pathTextBox = new TextBox();
            btnPickPath = new Button();
            btnUploadImg = new Button();
            btnShowImg = new Button();
            inputHeightImg = new TextBox();
            inputWidthImg = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label11 = new Label();
            label10 = new Label();
            inputQrCodeCorX = new TextBox();
            inputQrCodeCorY = new TextBox();
            inputImgCorY = new TextBox();
            inputImgCorX = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            showImgType = new ComboBox();
            btnAddNewFrame = new Button();
            btnStartFrameSlider = new Button();
            btnStopFrameSlider = new Button();
            SuspendLayout();
            // 
            // Connect
            // 
            Connect.Location = new Point(481, 12);
            Connect.Name = "Connect";
            Connect.Size = new Size(112, 34);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // listOfComPorts
            // 
            listOfComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            listOfComPorts.Location = new Point(144, 14);
            listOfComPorts.Name = "listOfComPorts";
            listOfComPorts.Size = new Size(182, 33);
            listOfComPorts.Sorted = true;
            listOfComPorts.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 12);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 3;
            label2.Text = "PORT:";
            // 
            // RefreshPortsButton
            // 
            RefreshPortsButton.Location = new Point(332, 12);
            RefreshPortsButton.Name = "RefreshPortsButton";
            RefreshPortsButton.Size = new Size(143, 34);
            RefreshPortsButton.TabIndex = 4;
            RefreshPortsButton.Text = "Refresh ports";
            RefreshPortsButton.UseVisualStyleBackColor = true;
            RefreshPortsButton.Click += RefreshPortsButton_Click;
            // 
            // Close
            // 
            Close.Location = new Point(332, 52);
            Close.Name = "Close";
            Close.Size = new Size(261, 34);
            Close.TabIndex = 5;
            Close.Text = "Close connection";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // RefreshScreen
            // 
            RefreshScreen.Location = new Point(599, 12);
            RefreshScreen.Name = "RefreshScreen";
            RefreshScreen.Size = new Size(216, 34);
            RefreshScreen.TabIndex = 7;
            RefreshScreen.Text = "refresh screen";
            RefreshScreen.UseVisualStyleBackColor = true;
            RefreshScreen.Click += RefreshScreen_Click;
            // 
            // InitScreen
            // 
            InitScreen.Location = new Point(599, 52);
            InitScreen.Name = "InitScreen";
            InitScreen.Size = new Size(216, 34);
            InitScreen.TabIndex = 8;
            InitScreen.Text = "Init screen";
            InitScreen.UseVisualStyleBackColor = true;
            InitScreen.Click += InitScreen_Click;
            // 
            // TextBoxForText
            // 
            TextBoxForText.Location = new Point(17, 229);
            TextBoxForText.Multiline = true;
            TextBoxForText.Name = "TextBoxForText";
            TextBoxForText.Size = new Size(463, 66);
            TextBoxForText.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 55);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 10;
            label1.Text = "baud rate:";
            // 
            // listOfBaudRates
            // 
            listOfBaudRates.DropDownStyle = ComboBoxStyle.DropDownList;
            listOfBaudRates.Location = new Point(144, 54);
            listOfBaudRates.Name = "listOfBaudRates";
            listOfBaudRates.Size = new Size(182, 33);
            listOfBaudRates.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(188, 45);
            label3.TabIndex = 12;
            label3.Text = "Text section";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 194);
            label4.Name = "label4";
            label4.Size = new Size(32, 25);
            label4.TabIndex = 13;
            label4.Text = "Id:";
            // 
            // ListOfTextIds
            // 
            ListOfTextIds.DropDownStyle = ComboBoxStyle.DropDownList;
            ListOfTextIds.Location = new Point(55, 187);
            ListOfTextIds.Name = "ListOfTextIds";
            ListOfTextIds.Size = new Size(83, 33);
            ListOfTextIds.TabIndex = 14;
            ListOfTextIds.SelectedIndexChanged += ListOfTextIds_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 195);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 15;
            label5.Text = "Color:";
            // 
            // btnPickColor
            // 
            btnPickColor.Location = new Point(201, 186);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(61, 33);
            btnPickColor.TabIndex = 16;
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 194);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 17;
            label6.Text = "Size:";
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(321, 188);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(81, 31);
            SizeTextBox.TabIndex = 18;
            SizeTextBox.Text = "20";
            SizeTextBox.TextChanged += SizeTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 192);
            label7.Name = "label7";
            label7.Size = new Size(27, 25);
            label7.TabIndex = 19;
            label7.Text = "X:";
            // 
            // CorXTextBox
            // 
            CorXTextBox.Location = new Point(440, 186);
            CorXTextBox.Name = "CorXTextBox";
            CorXTextBox.Size = new Size(81, 31);
            CorXTextBox.TabIndex = 20;
            CorXTextBox.Text = "0";
            CorXTextBox.TextChanged += CorXTextBox_TextChanged;
            // 
            // CorYTextBox
            // 
            CorYTextBox.Location = new Point(558, 186);
            CorYTextBox.Name = "CorYTextBox";
            CorYTextBox.Size = new Size(81, 31);
            CorYTextBox.TabIndex = 22;
            CorYTextBox.Text = "0";
            CorYTextBox.TextChanged += CorYTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 189);
            label8.Name = "label8";
            label8.Size = new Size(26, 25);
            label8.TabIndex = 21;
            label8.Text = "Y:";
            // 
            // ShowStaticTextButton
            // 
            ShowStaticTextButton.Location = new Point(486, 227);
            ShowStaticTextButton.Name = "ShowStaticTextButton";
            ShowStaticTextButton.Size = new Size(329, 34);
            ShowStaticTextButton.TabIndex = 23;
            ShowStaticTextButton.Text = "Show static text";
            ShowStaticTextButton.UseVisualStyleBackColor = true;
            ShowStaticTextButton.Click += ShowStaticTextButton_Click;
            // 
            // ShowDynamicTextButton
            // 
            ShowDynamicTextButton.Location = new Point(486, 267);
            ShowDynamicTextButton.Name = "ShowDynamicTextButton";
            ShowDynamicTextButton.Size = new Size(329, 34);
            ShowDynamicTextButton.TabIndex = 24;
            ShowDynamicTextButton.Text = "Show dynamic text";
            ShowDynamicTextButton.UseVisualStyleBackColor = true;
            ShowDynamicTextButton.Click += ShowDynamicTextButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 324);
            label9.Name = "label9";
            label9.Size = new Size(241, 45);
            label9.TabIndex = 25;
            label9.Text = "QrCode section";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 387);
            label12.Name = "label12";
            label12.Size = new Size(47, 25);
            label12.TabIndex = 26;
            label12.Text = "Size:";
            // 
            // inputQrCodeSize
            // 
            inputQrCodeSize.Location = new Point(72, 384);
            inputQrCodeSize.Name = "inputQrCodeSize";
            inputQrCodeSize.Size = new Size(81, 31);
            inputQrCodeSize.TabIndex = 29;
            inputQrCodeSize.Text = "200";
            inputQrCodeSize.KeyPress += InputQrCodeSize_KeyPress;
            // 
            // listBoxOfFrames
            // 
            listBoxOfFrames.FormattingEnabled = true;
            listBoxOfFrames.ItemHeight = 25;
            listBoxOfFrames.Location = new Point(892, 71);
            listBoxOfFrames.Name = "listBoxOfFrames";
            listBoxOfFrames.Size = new Size(458, 529);
            listBoxOfFrames.TabIndex = 32;
            listBoxOfFrames.MouseDoubleClick += listBoxOfFrames_MouseDoubleClick;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(892, 14);
            label13.Name = "label13";
            label13.Size = new Size(122, 45);
            label13.TabIndex = 33;
            label13.Text = "Frames";
            // 
            // inputQrCodeText
            // 
            inputQrCodeText.Location = new Point(12, 424);
            inputQrCodeText.Multiline = true;
            inputQrCodeText.Name = "inputQrCodeText";
            inputQrCodeText.Size = new Size(463, 66);
            inputQrCodeText.TabIndex = 34;
            // 
            // btnShowQrCode
            // 
            btnShowQrCode.Location = new Point(486, 424);
            btnShowQrCode.Name = "btnShowQrCode";
            btnShowQrCode.Size = new Size(329, 66);
            btnShowQrCode.TabIndex = 35;
            btnShowQrCode.Text = "Show QrCode";
            btnShowQrCode.UseVisualStyleBackColor = true;
            btnShowQrCode.Click += btnShowQrCode_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 502);
            label14.Name = "label14";
            label14.Size = new Size(220, 45);
            label14.TabIndex = 36;
            label14.Text = "Image section";
            // 
            // listOfImages
            // 
            listOfImages.DropDownStyle = ComboBoxStyle.DropDownList;
            listOfImages.Location = new Point(92, 551);
            listOfImages.Name = "listOfImages";
            listOfImages.Size = new Size(104, 33);
            listOfImages.TabIndex = 37;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 553);
            label15.Name = "label15";
            label15.Size = new Size(74, 25);
            label15.TabIndex = 38;
            label15.Text = "Images:";
            // 
            // pathTextBox
            // 
            pathTextBox.Location = new Point(202, 550);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.Size = new Size(391, 31);
            pathTextBox.TabIndex = 39;
            // 
            // btnPickPath
            // 
            btnPickPath.Location = new Point(599, 547);
            btnPickPath.Name = "btnPickPath";
            btnPickPath.Size = new Size(40, 34);
            btnPickPath.TabIndex = 40;
            btnPickPath.Text = "...";
            btnPickPath.UseVisualStyleBackColor = true;
            btnPickPath.Click += btnPickPath_Click;
            // 
            // btnUploadImg
            // 
            btnUploadImg.Location = new Point(645, 549);
            btnUploadImg.Name = "btnUploadImg";
            btnUploadImg.Size = new Size(170, 34);
            btnUploadImg.TabIndex = 41;
            btnUploadImg.Text = "upload";
            btnUploadImg.UseVisualStyleBackColor = true;
            btnUploadImg.Click += btnUploadImg_Click;
            // 
            // btnShowImg
            // 
            btnShowImg.Location = new Point(645, 589);
            btnShowImg.Name = "btnShowImg";
            btnShowImg.Size = new Size(170, 34);
            btnShowImg.TabIndex = 42;
            btnShowImg.Text = "show";
            btnShowImg.UseVisualStyleBackColor = true;
            btnShowImg.Click += btnShowImg_Click;
            // 
            // inputHeightImg
            // 
            inputHeightImg.Location = new Point(175, 595);
            inputHeightImg.Name = "inputHeightImg";
            inputHeightImg.Size = new Size(81, 31);
            inputHeightImg.TabIndex = 46;
            inputHeightImg.Text = "320";
            // 
            // inputWidthImg
            // 
            inputWidthImg.Location = new Point(57, 595);
            inputWidthImg.Name = "inputWidthImg";
            inputWidthImg.Size = new Size(81, 31);
            inputWidthImg.TabIndex = 45;
            inputWidthImg.Text = "240";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(140, 598);
            label16.Name = "label16";
            label16.Size = new Size(29, 25);
            label16.TabIndex = 44;
            label16.Text = "H:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 598);
            label17.Name = "label17";
            label17.Size = new Size(33, 25);
            label17.TabIndex = 43;
            label17.Text = "W:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(159, 393);
            label11.Name = "label11";
            label11.Size = new Size(27, 25);
            label11.TabIndex = 27;
            label11.Text = "X:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 390);
            label10.Name = "label10";
            label10.Size = new Size(26, 25);
            label10.TabIndex = 28;
            label10.Text = "Y:";
            // 
            // inputQrCodeCorX
            // 
            inputQrCodeCorX.Location = new Point(187, 387);
            inputQrCodeCorX.Name = "inputQrCodeCorX";
            inputQrCodeCorX.Size = new Size(81, 31);
            inputQrCodeCorX.TabIndex = 30;
            inputQrCodeCorX.Text = "0";
            inputQrCodeCorX.KeyPress += inputQrCodeCorX_KeyPress;
            // 
            // inputQrCodeCorY
            // 
            inputQrCodeCorY.Location = new Point(306, 387);
            inputQrCodeCorY.Name = "inputQrCodeCorY";
            inputQrCodeCorY.Size = new Size(81, 31);
            inputQrCodeCorY.TabIndex = 31;
            inputQrCodeCorY.Text = "0";
            inputQrCodeCorY.KeyPress += inputQrCodeCorY_KeyPress;
            // 
            // inputImgCorY
            // 
            inputImgCorY.Location = new Point(175, 632);
            inputImgCorY.Name = "inputImgCorY";
            inputImgCorY.Size = new Size(81, 31);
            inputImgCorY.TabIndex = 50;
            inputImgCorY.Text = "0";
            // 
            // inputImgCorX
            // 
            inputImgCorX.Location = new Point(53, 632);
            inputImgCorX.Name = "inputImgCorX";
            inputImgCorX.Size = new Size(81, 31);
            inputImgCorX.TabIndex = 49;
            inputImgCorX.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(140, 635);
            label18.Name = "label18";
            label18.Size = new Size(26, 25);
            label18.TabIndex = 48;
            label18.Text = "Y:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 638);
            label19.Name = "label19";
            label19.Size = new Size(27, 25);
            label19.TabIndex = 47;
            label19.Text = "X:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(291, 621);
            label21.Name = "label21";
            label21.Size = new Size(96, 25);
            label21.TabIndex = 52;
            label21.Text = "Show type";
            // 
            // showImgType
            // 
            showImgType.DropDownStyle = ComboBoxStyle.DropDownList;
            showImgType.Items.AddRange(new object[] { "show only", "show after screen clean" });
            showImgType.Location = new Point(391, 618);
            showImgType.Name = "showImgType";
            showImgType.Size = new Size(248, 33);
            showImgType.TabIndex = 53;
            // 
            // btnAddNewFrame
            // 
            btnAddNewFrame.Location = new Point(892, 617);
            btnAddNewFrame.Name = "btnAddNewFrame";
            btnAddNewFrame.Size = new Size(458, 34);
            btnAddNewFrame.TabIndex = 54;
            btnAddNewFrame.Text = "add a new frame";
            btnAddNewFrame.UseVisualStyleBackColor = true;
            btnAddNewFrame.Click += btnAddNewFrame_Click;
            // 
            // btnStartFrameSlider
            // 
            btnStartFrameSlider.Location = new Point(892, 657);
            btnStartFrameSlider.Name = "btnStartFrameSlider";
            btnStartFrameSlider.Size = new Size(227, 34);
            btnStartFrameSlider.TabIndex = 55;
            btnStartFrameSlider.Text = "start frame slider";
            btnStartFrameSlider.UseVisualStyleBackColor = true;
            btnStartFrameSlider.Click += btnStartFrameSlider_Click;
            // 
            // btnStopFrameSlider
            // 
            btnStopFrameSlider.Location = new Point(1125, 657);
            btnStopFrameSlider.Name = "btnStopFrameSlider";
            btnStopFrameSlider.Size = new Size(227, 34);
            btnStopFrameSlider.TabIndex = 56;
            btnStopFrameSlider.Text = "stop frame slider";
            btnStopFrameSlider.UseVisualStyleBackColor = true;
            btnStopFrameSlider.Click += btnStopFrameSlider_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 906);
            Controls.Add(btnStopFrameSlider);
            Controls.Add(btnStartFrameSlider);
            Controls.Add(btnAddNewFrame);
            Controls.Add(showImgType);
            Controls.Add(label21);
            Controls.Add(inputImgCorY);
            Controls.Add(inputImgCorX);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(inputHeightImg);
            Controls.Add(inputWidthImg);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(btnShowImg);
            Controls.Add(btnUploadImg);
            Controls.Add(btnPickPath);
            Controls.Add(pathTextBox);
            Controls.Add(label15);
            Controls.Add(listOfImages);
            Controls.Add(label14);
            Controls.Add(btnShowQrCode);
            Controls.Add(inputQrCodeText);
            Controls.Add(label13);
            Controls.Add(listBoxOfFrames);
            Controls.Add(inputQrCodeCorY);
            Controls.Add(inputQrCodeCorX);
            Controls.Add(inputQrCodeSize);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(ShowDynamicTextButton);
            Controls.Add(ShowStaticTextButton);
            Controls.Add(CorYTextBox);
            Controls.Add(label8);
            Controls.Add(CorXTextBox);
            Controls.Add(label7);
            Controls.Add(SizeTextBox);
            Controls.Add(label6);
            Controls.Add(btnPickColor);
            Controls.Add(label5);
            Controls.Add(ListOfTextIds);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listOfBaudRates);
            Controls.Add(label1);
            Controls.Add(TextBoxForText);
            Controls.Add(InitScreen);
            Controls.Add(RefreshScreen);
            Controls.Add(Close);
            Controls.Add(RefreshPortsButton);
            Controls.Add(label2);
            Controls.Add(listOfComPorts);
            Controls.Add(Connect);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Connect;
        private ComboBox listOfComPorts;
        private Label label2;
        private Button RefreshPortsButton;
        private Button Close;
        private Button RefreshScreen;
        private Button InitScreen;
        private TextBox TextBoxForText;
        private Label label1;
        private ComboBox listOfBaudRates;
        private Label label3;
        private Label label4;
        private ComboBox ListOfTextIds;
        private Label label5;
        private Button btnPickColor;
        private Label label6;
        private TextBox SizeTextBox;
        private Label label7;
        private TextBox CorXTextBox;
        private TextBox CorYTextBox;
        private Label label8;
        private Button ShowStaticTextButton;
        private Button ShowDynamicTextButton;
        private Label label9;
        private Label label12;
        private TextBox inputQrCodeSize;
        private ListBox listBoxOfFrames;
        private Label label13;
        private TextBox inputQrCodeText;
        private Button btnShowQrCode;
        private Label label14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox listOfImages;
        private Label label15;
        private TextBox pathTextBox;
        private Button btnPickPath;
        private Button btnUploadImg;
        private Button btnShowImg;
        private TextBox inputHeightImg;
        private TextBox inputWidthImg;
        private Label label16;
        private Label label17;
        private Label label11;
        private Label label10;
        private TextBox inputQrCodeCorX;
        private TextBox inputQrCodeCorY;
        private TextBox inputImgCorY;
        private TextBox inputImgCorX;
        private Label label18;
        private Label label19;
        private Label label21;
        private ComboBox showImgType;
        private Button btnAddNewFrame;
        private Button btnStartFrameSlider;
        private Button btnStopFrameSlider;
    }
}
