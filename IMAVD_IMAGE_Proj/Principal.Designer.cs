namespace IMAVD_IMAGE_Proj
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            invertToolStripMenuItem = new ToolStripMenuItem();
            inforToolStripMenuItem = new ToolStripMenuItem();
            propertiesToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            findColorToolStripMenuItem = new ToolStripMenuItem();
            getColorToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            panelPictureBox1 = new Panel();
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            panelPictureBox2 = new Panel();
            label1 = new Label();
            widthCrop = new TextBox();
            heightCrop = new TextBox();
            yPositionCrop = new TextBox();
            xPositionCrop = new TextBox();
            xCropLabel = new Label();
            yCropLabel = new Label();
            HeightCropLabel = new Label();
            widthCropLabel = new Label();
            saveCropButton = new Button();
            changeGlowButton = new Button();
            changeGlowTextBox = new TextBox();
            changeContrastLabel = new Label();
            changeContrastTextBox = new TextBox();
            changeContrastButton = new Button();
            makeSelectionButton = new Button();
            makeCropButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rotateVerticalButton = new Button();
            rotateHorizontalButton = new Button();
            rotateRightButton = new Button();
            rotateLeftButton = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            okResizeButton = new Button();
            resizeDomainUpDown = new DomainUpDown();
            tabPage4 = new TabPage();
            applyBrightnessButton = new Button();
            brightnessTrackBar = new TrackBar();
            brightnessDomainUpDown = new DomainUpDown();
            tabPage5 = new TabPage();
            applyContrastButton = new Button();
            contrastTrackBar = new TrackBar();
            contrastDomainUpDown = new DomainUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            label3 = new Label();
            button6 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            tabPage6 = new TabPage();
            panel3 = new Panel();
            label5 = new Label();
            button7 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panelPictureBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(241, 241, 241);
            menuStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, inforToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1284, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = Color.FromArgb(26, 26, 26);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = SystemColors.Control;
            openToolStripMenuItem.ForeColor = Color.FromArgb(26, 26, 26);
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem, invertToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.ForeColor = Color.FromArgb(26, 26, 26);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.BackColor = SystemColors.Control;
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(180, 22);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(180, 22);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(180, 22);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // invertToolStripMenuItem
            // 
            invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            invertToolStripMenuItem.Size = new Size(180, 22);
            invertToolStripMenuItem.Text = "Negative";
            invertToolStripMenuItem.Click += invertToolStripMenuItem_Click;
            // 
            // inforToolStripMenuItem
            // 
            inforToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { propertiesToolStripMenuItem, colorToolStripMenuItem });
            inforToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            inforToolStripMenuItem.ForeColor = Color.FromArgb(26, 26, 26);
            inforToolStripMenuItem.Name = "inforToolStripMenuItem";
            inforToolStripMenuItem.Size = new Size(45, 20);
            inforToolStripMenuItem.Text = "Infor";
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(180, 22);
            propertiesToolStripMenuItem.Text = "Properties";
            propertiesToolStripMenuItem.Click += propertiesToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findColorToolStripMenuItem, getColorToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Color";
            // 
            // findColorToolStripMenuItem
            // 
            findColorToolStripMenuItem.Name = "findColorToolStripMenuItem";
            findColorToolStripMenuItem.Size = new Size(139, 22);
            findColorToolStripMenuItem.Text = "Color search";
            findColorToolStripMenuItem.Click += findColorToolStripMenuItem_Click;
            // 
            // getColorToolStripMenuItem
            // 
            getColorToolStripMenuItem.Name = "getColorToolStripMenuItem";
            getColorToolStripMenuItem.Size = new Size(139, 22);
            getColorToolStripMenuItem.Text = "Get color";
            getColorToolStripMenuItem.Click += getColorToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(10, 14);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 409);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panelPictureBox1
            // 
            panelPictureBox1.AutoScroll = true;
            panelPictureBox1.Controls.Add(pictureBox1);
            panelPictureBox1.Location = new Point(10, 30);
            panelPictureBox1.Margin = new Padding(3, 2, 3, 2);
            panelPictureBox1.Name = "panelPictureBox1";
            panelPictureBox1.Size = new Size(458, 373);
            panelPictureBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 15);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.Location = new Point(17, 32);
            trackBar1.Margin = new Padding(3, 2, 3, 2);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(45, 178);
            trackBar1.TabIndex = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panelPictureBox2
            // 
            panelPictureBox2.AutoScroll = true;
            panelPictureBox2.Controls.Add(pictureBox2);
            panelPictureBox2.Location = new Point(817, 30);
            panelPictureBox2.Margin = new Padding(3, 2, 3, 2);
            panelPictureBox2.Name = "panelPictureBox2";
            panelPictureBox2.Size = new Size(458, 334);
            panelPictureBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 12;
            label1.Text = "ZOOM";
            // 
            // widthCrop
            // 
            widthCrop.Enabled = false;
            widthCrop.Location = new Point(18, 127);
            widthCrop.Margin = new Padding(3, 2, 3, 2);
            widthCrop.Name = "widthCrop";
            widthCrop.Size = new Size(110, 23);
            widthCrop.TabIndex = 13;
            // 
            // heightCrop
            // 
            heightCrop.Enabled = false;
            heightCrop.Location = new Point(18, 168);
            heightCrop.Margin = new Padding(3, 2, 3, 2);
            heightCrop.Name = "heightCrop";
            heightCrop.Size = new Size(110, 23);
            heightCrop.TabIndex = 14;
            // 
            // yPositionCrop
            // 
            yPositionCrop.Enabled = false;
            yPositionCrop.Location = new Point(18, 85);
            yPositionCrop.Margin = new Padding(3, 2, 3, 2);
            yPositionCrop.Name = "yPositionCrop";
            yPositionCrop.Size = new Size(110, 23);
            yPositionCrop.TabIndex = 16;
            // 
            // xPositionCrop
            // 
            xPositionCrop.Enabled = false;
            xPositionCrop.Location = new Point(18, 43);
            xPositionCrop.Margin = new Padding(3, 2, 3, 2);
            xPositionCrop.Name = "xPositionCrop";
            xPositionCrop.Size = new Size(110, 23);
            xPositionCrop.TabIndex = 15;
            // 
            // xCropLabel
            // 
            xCropLabel.AutoSize = true;
            xCropLabel.Enabled = false;
            xCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xCropLabel.ForeColor = Color.FromArgb(241, 241, 241);
            xCropLabel.Location = new Point(134, 46);
            xCropLabel.Name = "xCropLabel";
            xCropLabel.Size = new Size(15, 15);
            xCropLabel.TabIndex = 17;
            xCropLabel.Text = "X";
            // 
            // yCropLabel
            // 
            yCropLabel.AutoSize = true;
            yCropLabel.Enabled = false;
            yCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            yCropLabel.ForeColor = Color.FromArgb(241, 241, 241);
            yCropLabel.Location = new Point(134, 89);
            yCropLabel.Name = "yCropLabel";
            yCropLabel.Size = new Size(14, 15);
            yCropLabel.TabIndex = 18;
            yCropLabel.Text = "Y";
            // 
            // HeightCropLabel
            // 
            HeightCropLabel.AutoSize = true;
            HeightCropLabel.Enabled = false;
            HeightCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeightCropLabel.ForeColor = Color.FromArgb(241, 241, 241);
            HeightCropLabel.Location = new Point(134, 171);
            HeightCropLabel.Name = "HeightCropLabel";
            HeightCropLabel.Size = new Size(51, 15);
            HeightCropLabel.TabIndex = 20;
            HeightCropLabel.Text = "HEIGHT";
            // 
            // widthCropLabel
            // 
            widthCropLabel.AutoSize = true;
            widthCropLabel.Enabled = false;
            widthCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            widthCropLabel.ForeColor = Color.FromArgb(241, 241, 241);
            widthCropLabel.Location = new Point(134, 130);
            widthCropLabel.Name = "widthCropLabel";
            widthCropLabel.Size = new Size(48, 15);
            widthCropLabel.TabIndex = 19;
            widthCropLabel.Text = "WIDTH";
            // 
            // saveCropButton
            // 
            saveCropButton.Enabled = false;
            saveCropButton.Location = new Point(223, 8);
            saveCropButton.Margin = new Padding(3, 2, 3, 2);
            saveCropButton.Name = "saveCropButton";
            saveCropButton.Size = new Size(82, 22);
            saveCropButton.TabIndex = 21;
            saveCropButton.Text = "Save Crop";
            saveCropButton.UseVisualStyleBackColor = true;
            saveCropButton.Click += saveCropButton_Click;
            // 
            // changeGlowButton
            // 
            changeGlowButton.Enabled = false;
            changeGlowButton.Location = new Point(122, 9);
            changeGlowButton.Margin = new Padding(3, 2, 3, 2);
            changeGlowButton.Name = "changeGlowButton";
            changeGlowButton.Size = new Size(82, 22);
            changeGlowButton.TabIndex = 22;
            changeGlowButton.Text = "Change Glow";
            changeGlowButton.UseVisualStyleBackColor = true;
            // 
            // changeGlowTextBox
            // 
            changeGlowTextBox.Enabled = false;
            changeGlowTextBox.Location = new Point(6, 8);
            changeGlowTextBox.Margin = new Padding(3, 2, 3, 2);
            changeGlowTextBox.Name = "changeGlowTextBox";
            changeGlowTextBox.Size = new Size(110, 23);
            changeGlowTextBox.TabIndex = 23;
            // 
            // changeContrastLabel
            // 
            changeContrastLabel.AutoSize = true;
            changeContrastLabel.Enabled = false;
            changeContrastLabel.Location = new Point(234, 13);
            changeContrastLabel.Name = "changeContrastLabel";
            changeContrastLabel.Size = new Size(96, 15);
            changeContrastLabel.TabIndex = 27;
            changeContrastLabel.Text = "Change Contrast";
            // 
            // changeContrastTextBox
            // 
            changeContrastTextBox.Enabled = false;
            changeContrastTextBox.Location = new Point(230, 30);
            changeContrastTextBox.Margin = new Padding(3, 2, 3, 2);
            changeContrastTextBox.Name = "changeContrastTextBox";
            changeContrastTextBox.Size = new Size(110, 23);
            changeContrastTextBox.TabIndex = 26;
            // 
            // changeContrastButton
            // 
            changeContrastButton.Enabled = false;
            changeContrastButton.Location = new Point(346, 29);
            changeContrastButton.Margin = new Padding(3, 2, 3, 2);
            changeContrastButton.Name = "changeContrastButton";
            changeContrastButton.Size = new Size(82, 22);
            changeContrastButton.TabIndex = 25;
            changeContrastButton.Text = "Change Glow";
            changeContrastButton.UseVisualStyleBackColor = true;
            // 
            // makeSelectionButton
            // 
            makeSelectionButton.Location = new Point(6, 8);
            makeSelectionButton.Margin = new Padding(3, 2, 3, 2);
            makeSelectionButton.Name = "makeSelectionButton";
            makeSelectionButton.Size = new Size(123, 22);
            makeSelectionButton.TabIndex = 28;
            makeSelectionButton.Text = "Make Selection";
            makeSelectionButton.UseVisualStyleBackColor = true;
            makeSelectionButton.Click += makeSelectionButton_Click;
            // 
            // makeCropButton
            // 
            makeCropButton.Location = new Point(135, 8);
            makeCropButton.Margin = new Padding(3, 2, 3, 2);
            makeCropButton.Name = "makeCropButton";
            makeCropButton.Size = new Size(82, 22);
            makeCropButton.TabIndex = 29;
            makeCropButton.Text = "Crop";
            makeCropButton.UseVisualStyleBackColor = true;
            makeCropButton.Click += makeCropButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(10, 417);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(458, 103);
            tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(51, 47, 46);
            tabPage1.Controls.Add(rotateVerticalButton);
            tabPage1.Controls.Add(rotateHorizontalButton);
            tabPage1.Controls.Add(rotateRightButton);
            tabPage1.Controls.Add(rotateLeftButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(450, 75);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rotation";
            // 
            // rotateVerticalButton
            // 
            rotateVerticalButton.Location = new Point(135, 37);
            rotateVerticalButton.Margin = new Padding(3, 2, 3, 2);
            rotateVerticalButton.Name = "rotateVerticalButton";
            rotateVerticalButton.Size = new Size(123, 22);
            rotateVerticalButton.TabIndex = 3;
            rotateVerticalButton.Text = "Rotate Vertical";
            rotateVerticalButton.UseVisualStyleBackColor = true;
            rotateVerticalButton.Click += rotateVerticalButton_Click;
            // 
            // rotateHorizontalButton
            // 
            rotateHorizontalButton.Location = new Point(135, 8);
            rotateHorizontalButton.Margin = new Padding(3, 2, 3, 2);
            rotateHorizontalButton.Name = "rotateHorizontalButton";
            rotateHorizontalButton.Size = new Size(123, 22);
            rotateHorizontalButton.TabIndex = 2;
            rotateHorizontalButton.Text = "Rotate Horizontal";
            rotateHorizontalButton.UseVisualStyleBackColor = true;
            rotateHorizontalButton.Click += rotateHorizontalButton_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Location = new Point(6, 37);
            rotateRightButton.Margin = new Padding(3, 2, 3, 2);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(123, 22);
            rotateRightButton.TabIndex = 1;
            rotateRightButton.Text = "Rotate Right";
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // rotateLeftButton
            // 
            rotateLeftButton.Location = new Point(6, 8);
            rotateLeftButton.Margin = new Padding(3, 2, 3, 2);
            rotateLeftButton.Name = "rotateLeftButton";
            rotateLeftButton.Size = new Size(123, 22);
            rotateLeftButton.TabIndex = 0;
            rotateLeftButton.Text = "Rotate Left";
            rotateLeftButton.UseVisualStyleBackColor = true;
            rotateLeftButton.Click += rotateLeftButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(51, 47, 46);
            tabPage2.Controls.Add(makeSelectionButton);
            tabPage2.Controls.Add(makeCropButton);
            tabPage2.Controls.Add(saveCropButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(450, 75);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crop";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(51, 47, 46);
            tabPage3.Controls.Add(okResizeButton);
            tabPage3.Controls.Add(resizeDomainUpDown);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(450, 75);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Resize";
            // 
            // okResizeButton
            // 
            okResizeButton.Location = new Point(103, 9);
            okResizeButton.Margin = new Padding(3, 2, 3, 2);
            okResizeButton.Name = "okResizeButton";
            okResizeButton.Size = new Size(34, 22);
            okResizeButton.TabIndex = 1;
            okResizeButton.Text = "Ok";
            okResizeButton.UseVisualStyleBackColor = true;
            okResizeButton.Click += okResizeButton_Click;
            // 
            // resizeDomainUpDown
            // 
            resizeDomainUpDown.Location = new Point(6, 8);
            resizeDomainUpDown.Margin = new Padding(3, 2, 3, 2);
            resizeDomainUpDown.Name = "resizeDomainUpDown";
            resizeDomainUpDown.Size = new Size(91, 23);
            resizeDomainUpDown.TabIndex = 0;
            resizeDomainUpDown.SelectedItemChanged += resizeDomainUpDown_SelectedItemChanged;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(51, 47, 46);
            tabPage4.Controls.Add(applyBrightnessButton);
            tabPage4.Controls.Add(brightnessTrackBar);
            tabPage4.Controls.Add(brightnessDomainUpDown);
            tabPage4.Controls.Add(changeContrastTextBox);
            tabPage4.Controls.Add(changeContrastButton);
            tabPage4.Controls.Add(changeContrastLabel);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(450, 75);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Brightness";
            // 
            // applyBrightnessButton
            // 
            applyBrightnessButton.Location = new Point(125, 34);
            applyBrightnessButton.Margin = new Padding(3, 2, 3, 2);
            applyBrightnessButton.Name = "applyBrightnessButton";
            applyBrightnessButton.Size = new Size(82, 22);
            applyBrightnessButton.TabIndex = 2;
            applyBrightnessButton.Text = "APPLY";
            applyBrightnessButton.UseVisualStyleBackColor = true;
            applyBrightnessButton.Click += applyBrightnessButton_Click;
            // 
            // brightnessTrackBar
            // 
            brightnessTrackBar.Cursor = Cursors.Hand;
            brightnessTrackBar.Location = new Point(6, 8);
            brightnessTrackBar.Margin = new Padding(3, 2, 3, 2);
            brightnessTrackBar.Maximum = 255;
            brightnessTrackBar.Minimum = -255;
            brightnessTrackBar.Name = "brightnessTrackBar";
            brightnessTrackBar.Size = new Size(114, 45);
            brightnessTrackBar.TabIndex = 1;
            brightnessTrackBar.Scroll += brightnessTrackBar_Scroll;
            // 
            // brightnessDomainUpDown
            // 
            brightnessDomainUpDown.Location = new Point(126, 8);
            brightnessDomainUpDown.Margin = new Padding(3, 2, 3, 2);
            brightnessDomainUpDown.Name = "brightnessDomainUpDown";
            brightnessDomainUpDown.Size = new Size(81, 23);
            brightnessDomainUpDown.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(51, 47, 46);
            tabPage5.Controls.Add(applyContrastButton);
            tabPage5.Controls.Add(contrastTrackBar);
            tabPage5.Controls.Add(contrastDomainUpDown);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(450, 75);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Contrast";
            // 
            // applyContrastButton
            // 
            applyContrastButton.Location = new Point(125, 34);
            applyContrastButton.Margin = new Padding(3, 2, 3, 2);
            applyContrastButton.Name = "applyContrastButton";
            applyContrastButton.Size = new Size(83, 22);
            applyContrastButton.TabIndex = 4;
            applyContrastButton.Text = "APPLY";
            applyContrastButton.UseVisualStyleBackColor = true;
            applyContrastButton.Click += applyContrastButton_Click;
            // 
            // contrastTrackBar
            // 
            contrastTrackBar.Cursor = Cursors.Hand;
            contrastTrackBar.Location = new Point(6, 8);
            contrastTrackBar.Margin = new Padding(3, 2, 3, 2);
            contrastTrackBar.Maximum = 100;
            contrastTrackBar.Minimum = -100;
            contrastTrackBar.Name = "contrastTrackBar";
            contrastTrackBar.Size = new Size(114, 45);
            contrastTrackBar.TabIndex = 3;
            contrastTrackBar.Scroll += contrastTrackBar_Scroll;
            // 
            // contrastDomainUpDown
            // 
            contrastDomainUpDown.Location = new Point(126, 8);
            contrastDomainUpDown.Margin = new Padding(3, 2, 3, 2);
            contrastDomainUpDown.Name = "contrastDomainUpDown";
            contrastDomainUpDown.Size = new Size(82, 23);
            contrastDomainUpDown.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(10, 35);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(163, 22);
            button1.TabIndex = 32;
            button1.Text = "Chromakey Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(10, 62);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(163, 22);
            button2.TabIndex = 33;
            button2.Text = "Remove Chromakey";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(10, 88);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 34;
            button3.Text = "Undo*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(362, 60);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(86, 24);
            button4.TabIndex = 35;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 61);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(198, 40);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 37;
            label2.Text = "Write a text to insert";
            // 
            // button5
            // 
            button5.Location = new Point(198, 115);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 38;
            button5.Text = "ADD";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(198, 98);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 39;
            label3.Text = "Add an image";
            // 
            // button6
            // 
            button6.Location = new Point(10, 115);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(163, 22);
            button6.TabIndex = 40;
            button6.Text = "Download";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 47, 46);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Location = new Point(492, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 216);
            panel1.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(14, 14);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 42;
            label4.Text = "INFORMATION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 47, 46);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(HeightCropLabel);
            panel2.Controls.Add(yPositionCrop);
            panel2.Controls.Add(xPositionCrop);
            panel2.Controls.Add(widthCropLabel);
            panel2.Controls.Add(heightCrop);
            panel2.Controls.Add(yCropLabel);
            panel2.Controls.Add(widthCrop);
            panel2.Controls.Add(xCropLabel);
            panel2.Location = new Point(589, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 216);
            panel2.TabIndex = 43;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(51, 47, 46);
            tabPage6.Controls.Add(changeGlowTextBox);
            tabPage6.Controls.Add(changeGlowButton);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(450, 75);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Glow";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 47, 46);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(817, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 143);
            panel3.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(10, 9);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 0;
            label5.Text = "CHROMA KEY CONTROL";
            // 
            // button7
            // 
            button7.Location = new Point(98, 87);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 41;
            button7.Text = "Redo*";
            button7.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(1284, 540);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(panelPictureBox2);
            Controls.Add(panelPictureBox1);
            Controls.Add(menuStrip1);
            Controls.Add(panel3);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelPictureBox1.ResumeLayout(false);
            panelPictureBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panelPictureBox2.ResumeLayout(false);
            panelPictureBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem inforToolStripMenuItem;
        private ToolStripMenuItem propertiesToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripMenuItem invertToolStripMenuItem;
        private Panel panelPictureBox1;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem findColorToolStripMenuItem;
        private ToolStripMenuItem getColorToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panelPictureBox2;
        private TrackBar trackBar1;
        private Label label1;
        private TextBox widthCrop;
        private TextBox heightCrop;
        private TextBox yPositionCrop;
        private TextBox xPositionCrop;
        private Label xCropLabel;
        private Label yCropLabel;
        private Label HeightCropLabel;
        private Label widthCropLabel;
        private Button saveCropButton;
        private Button changeGlowButton;
        private TextBox changeGlowTextBox;
        private Label changeContrastLabel;
        private TextBox changeContrastTextBox;
        private Button changeContrastButton;
        private Button makeSelectionButton;
        private Button makeCropButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button rotateVerticalButton;
        private Button rotateHorizontalButton;
        private Button rotateRightButton;
        private Button rotateLeftButton;
        private TabPage tabPage3;
        private DomainUpDown resizeDomainUpDown;
        private Button okResizeButton;
        private TabPage tabPage4;
        private DomainUpDown brightnessDomainUpDown;
        private TrackBar brightnessTrackBar;
        private TabPage tabPage5;
        private TrackBar contrastTrackBar;
        private DomainUpDown contrastDomainUpDown;
        private Button applyBrightnessButton;
        private Button applyContrastButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Button button5;
        private Label label3;
        private Button button6;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private TabPage tabPage6;
        private Panel panel3;
        private Button button7;
        private Label label5;
    }
}