namespace IMAVD_IMAGE_Proj
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            invertToolStripMenuItem = new ToolStripMenuItem();
            cropToolStripMenuItem = new ToolStripMenuItem();
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
            changeGlowLabel = new Label();
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
            brightnessTrackBar = new TrackBar();
            brightnessDomainUpDown = new DomainUpDown();
            tabPage5 = new TabPage();
            constrastTrackBar = new TrackBar();
            constrastDomainUpDown = new DomainUpDown();
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
            ((System.ComponentModel.ISupportInitialize)constrastTrackBar).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, inforToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1493, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, greenToolStripMenuItem, blueToolStripMenuItem, invertToolStripMenuItem, cropToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(152, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(152, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(152, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // invertToolStripMenuItem
            // 
            invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            invertToolStripMenuItem.Size = new Size(152, 26);
            invertToolStripMenuItem.Text = "Negative";
            invertToolStripMenuItem.Click += invertToolStripMenuItem_Click;
            // 
            // cropToolStripMenuItem
            // 
            cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            cropToolStripMenuItem.Size = new Size(152, 26);
            cropToolStripMenuItem.Text = "Crop";
            cropToolStripMenuItem.Click += cropToolStripMenuItem_Click;
            // 
            // inforToolStripMenuItem
            // 
            inforToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { propertiesToolStripMenuItem, colorToolStripMenuItem });
            inforToolStripMenuItem.Name = "inforToolStripMenuItem";
            inforToolStripMenuItem.Size = new Size(54, 24);
            inforToolStripMenuItem.Text = "Infor";
            inforToolStripMenuItem.Click += inforToolStripMenuItem_Click;
            // 
            // propertiesToolStripMenuItem
            // 
            propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            propertiesToolStripMenuItem.Size = new Size(159, 26);
            propertiesToolStripMenuItem.Text = "Properties";
            propertiesToolStripMenuItem.Click += propertiesToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findColorToolStripMenuItem, getColorToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(159, 26);
            colorToolStripMenuItem.Text = "Color";
            // 
            // findColorToolStripMenuItem
            // 
            findColorToolStripMenuItem.Name = "findColorToolStripMenuItem";
            findColorToolStripMenuItem.Size = new Size(174, 26);
            findColorToolStripMenuItem.Text = "Color search";
            findColorToolStripMenuItem.Click += findColorToolStripMenuItem_Click;
            // 
            // getColorToolStripMenuItem
            // 
            getColorToolStripMenuItem.Name = "getColorToolStripMenuItem";
            getColorToolStripMenuItem.Size = new Size(174, 26);
            getColorToolStripMenuItem.Text = "Get color";
            getColorToolStripMenuItem.Click += getColorToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 19);
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
            panelPictureBox1.Location = new Point(12, 40);
            panelPictureBox1.Name = "panelPictureBox1";
            panelPictureBox1.Size = new Size(523, 497);
            panelPictureBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 20);
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
            trackBar1.Location = new Point(576, 99);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.RightToLeft = RightToLeft.No;
            trackBar1.Size = new Size(56, 237);
            trackBar1.TabIndex = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panelPictureBox2
            // 
            panelPictureBox2.AutoScroll = true;
            panelPictureBox2.Controls.Add(pictureBox2);
            panelPictureBox2.Location = new Point(12, 597);
            panelPictureBox2.Name = "panelPictureBox2";
            panelPictureBox2.Size = new Size(523, 446);
            panelPictureBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(566, 86);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 12;
            label1.Text = "ZOOM";
            // 
            // widthCrop
            // 
            widthCrop.Location = new Point(1338, 185);
            widthCrop.Name = "widthCrop";
            widthCrop.Size = new Size(125, 27);
            widthCrop.TabIndex = 13;
            // 
            // heightCrop
            // 
            heightCrop.Location = new Point(1338, 233);
            heightCrop.Name = "heightCrop";
            heightCrop.Size = new Size(125, 27);
            heightCrop.TabIndex = 14;
            // 
            // yPositionCrop
            // 
            yPositionCrop.Location = new Point(1338, 137);
            yPositionCrop.Name = "yPositionCrop";
            yPositionCrop.Size = new Size(125, 27);
            yPositionCrop.TabIndex = 16;
            // 
            // xPositionCrop
            // 
            xPositionCrop.Location = new Point(1338, 81);
            xPositionCrop.Name = "xPositionCrop";
            xPositionCrop.Size = new Size(125, 27);
            xPositionCrop.TabIndex = 15;
            // 
            // xCropLabel
            // 
            xCropLabel.AutoSize = true;
            xCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xCropLabel.Location = new Point(1313, 84);
            xCropLabel.Name = "xCropLabel";
            xCropLabel.Size = new Size(23, 20);
            xCropLabel.TabIndex = 17;
            xCropLabel.Text = "X:";
            // 
            // yCropLabel
            // 
            yCropLabel.AutoSize = true;
            yCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            yCropLabel.Location = new Point(1313, 140);
            yCropLabel.Name = "yCropLabel";
            yCropLabel.Size = new Size(22, 20);
            yCropLabel.TabIndex = 18;
            yCropLabel.Text = "Y:";
            // 
            // HeightCropLabel
            // 
            HeightCropLabel.AutoSize = true;
            HeightCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeightCropLabel.Location = new Point(1264, 236);
            HeightCropLabel.Name = "HeightCropLabel";
            HeightCropLabel.Size = new Size(68, 20);
            HeightCropLabel.TabIndex = 20;
            HeightCropLabel.Text = "HEIGHT:";
            // 
            // widthCropLabel
            // 
            widthCropLabel.AutoSize = true;
            widthCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            widthCropLabel.Location = new Point(1269, 188);
            widthCropLabel.Name = "widthCropLabel";
            widthCropLabel.Size = new Size(63, 20);
            widthCropLabel.TabIndex = 19;
            widthCropLabel.Text = "WIDTH:";
            // 
            // saveCropButton
            // 
            saveCropButton.Enabled = false;
            saveCropButton.Location = new Point(93, 155);
            saveCropButton.Name = "saveCropButton";
            saveCropButton.Size = new Size(94, 29);
            saveCropButton.TabIndex = 21;
            saveCropButton.Text = "Save Crop";
            saveCropButton.UseVisualStyleBackColor = true;
            saveCropButton.Click += saveCropButton_Click;
            // 
            // changeGlowButton
            // 
            changeGlowButton.Location = new Point(1343, 416);
            changeGlowButton.Name = "changeGlowButton";
            changeGlowButton.Size = new Size(94, 29);
            changeGlowButton.TabIndex = 22;
            changeGlowButton.Text = "Change Glow";
            changeGlowButton.UseVisualStyleBackColor = true;
            changeGlowButton.Click += changeGlowButton_Click;
            // 
            // changeGlowTextBox
            // 
            changeGlowTextBox.Location = new Point(1325, 383);
            changeGlowTextBox.Name = "changeGlowTextBox";
            changeGlowTextBox.Size = new Size(125, 27);
            changeGlowTextBox.TabIndex = 23;
            // 
            // changeGlowLabel
            // 
            changeGlowLabel.AutoSize = true;
            changeGlowLabel.Location = new Point(1337, 357);
            changeGlowLabel.Name = "changeGlowLabel";
            changeGlowLabel.Size = new Size(97, 20);
            changeGlowLabel.TabIndex = 24;
            changeGlowLabel.Text = "Change Glow";
            // 
            // changeContrastLabel
            // 
            changeContrastLabel.AutoSize = true;
            changeContrastLabel.Location = new Point(1332, 465);
            changeContrastLabel.Name = "changeContrastLabel";
            changeContrastLabel.Size = new Size(118, 20);
            changeContrastLabel.TabIndex = 27;
            changeContrastLabel.Text = "Change Contrast";
            // 
            // changeContrastTextBox
            // 
            changeContrastTextBox.Location = new Point(1328, 488);
            changeContrastTextBox.Name = "changeContrastTextBox";
            changeContrastTextBox.Size = new Size(125, 27);
            changeContrastTextBox.TabIndex = 26;
            // 
            // changeContrastButton
            // 
            changeContrastButton.Location = new Point(1346, 521);
            changeContrastButton.Name = "changeContrastButton";
            changeContrastButton.Size = new Size(94, 29);
            changeContrastButton.TabIndex = 25;
            changeContrastButton.Text = "Change Glow";
            changeContrastButton.UseVisualStyleBackColor = true;
            changeContrastButton.Click += changeContrastButton_Click;
            // 
            // makeSelectionButton
            // 
            makeSelectionButton.Location = new Point(71, 56);
            makeSelectionButton.Name = "makeSelectionButton";
            makeSelectionButton.Size = new Size(135, 29);
            makeSelectionButton.TabIndex = 28;
            makeSelectionButton.Text = "Make Selection";
            makeSelectionButton.UseVisualStyleBackColor = true;
            makeSelectionButton.Click += makeSelectionButton_Click;
            // 
            // makeCropButton
            // 
            makeCropButton.Location = new Point(93, 106);
            makeCropButton.Name = "makeCropButton";
            makeCropButton.Size = new Size(94, 29);
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
            tabControl1.Location = new Point(676, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 391);
            tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rotateVerticalButton);
            tabPage1.Controls.Add(rotateHorizontalButton);
            tabPage1.Controls.Add(rotateRightButton);
            tabPage1.Controls.Add(rotateLeftButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(376, 358);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Rotation";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rotateVerticalButton
            // 
            rotateVerticalButton.Location = new Point(84, 182);
            rotateVerticalButton.Name = "rotateVerticalButton";
            rotateVerticalButton.Size = new Size(141, 29);
            rotateVerticalButton.TabIndex = 3;
            rotateVerticalButton.Text = "Rotate Vertical";
            rotateVerticalButton.UseVisualStyleBackColor = true;
            rotateVerticalButton.Click += rotateVerticalButton_Click;
            // 
            // rotateHorizontalButton
            // 
            rotateHorizontalButton.Location = new Point(84, 147);
            rotateHorizontalButton.Name = "rotateHorizontalButton";
            rotateHorizontalButton.Size = new Size(141, 29);
            rotateHorizontalButton.TabIndex = 2;
            rotateHorizontalButton.Text = "Rotate Horizontal";
            rotateHorizontalButton.UseVisualStyleBackColor = true;
            rotateHorizontalButton.Click += rotateHorizontalButton_Click;
            // 
            // rotateRightButton
            // 
            rotateRightButton.Location = new Point(84, 88);
            rotateRightButton.Name = "rotateRightButton";
            rotateRightButton.Size = new Size(141, 29);
            rotateRightButton.TabIndex = 1;
            rotateRightButton.Text = "Rotate Right";
            rotateRightButton.UseVisualStyleBackColor = true;
            rotateRightButton.Click += rotateRightButton_Click;
            // 
            // rotateLeftButton
            // 
            rotateLeftButton.Location = new Point(84, 53);
            rotateLeftButton.Name = "rotateLeftButton";
            rotateLeftButton.Size = new Size(141, 29);
            rotateLeftButton.TabIndex = 0;
            rotateLeftButton.Text = "Rotate Left";
            rotateLeftButton.UseVisualStyleBackColor = true;
            rotateLeftButton.Click += rotateLeftButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(makeSelectionButton);
            tabPage2.Controls.Add(makeCropButton);
            tabPage2.Controls.Add(saveCropButton);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(376, 358);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crop";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(okResizeButton);
            tabPage3.Controls.Add(resizeDomainUpDown);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(376, 358);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Resize";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // okResizeButton
            // 
            okResizeButton.Location = new Point(143, 73);
            okResizeButton.Name = "okResizeButton";
            okResizeButton.Size = new Size(39, 29);
            okResizeButton.TabIndex = 1;
            okResizeButton.Text = "Ok";
            okResizeButton.UseVisualStyleBackColor = true;
            okResizeButton.Click += okResizeButton_Click;
            // 
            // resizeDomainUpDown
            // 
            resizeDomainUpDown.Location = new Point(23, 75);
            resizeDomainUpDown.Name = "resizeDomainUpDown";
            resizeDomainUpDown.Size = new Size(104, 27);
            resizeDomainUpDown.TabIndex = 0;
            resizeDomainUpDown.SelectedItemChanged += resizeDomainUpDown_SelectedItemChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(brightnessTrackBar);
            tabPage4.Controls.Add(brightnessDomainUpDown);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(376, 358);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Brightness";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // brightnessTrackBar
            // 
            brightnessTrackBar.Location = new Point(85, 61);
            brightnessTrackBar.Maximum = 255;
            brightnessTrackBar.Minimum = -255;
            brightnessTrackBar.Name = "brightnessTrackBar";
            brightnessTrackBar.Size = new Size(130, 56);
            brightnessTrackBar.TabIndex = 1;
            brightnessTrackBar.Scroll += brightnessTrackBar_Scroll;
            // 
            // brightnessDomainUpDown
            // 
            brightnessDomainUpDown.Location = new Point(221, 71);
            brightnessDomainUpDown.Name = "brightnessDomainUpDown";
            brightnessDomainUpDown.Size = new Size(84, 27);
            brightnessDomainUpDown.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(constrastTrackBar);
            tabPage5.Controls.Add(constrastDomainUpDown);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(376, 358);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Contrast";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // constrastTrackBar
            // 
            constrastTrackBar.Location = new Point(65, 55);
            constrastTrackBar.Maximum = 100;
            constrastTrackBar.Minimum = -100;
            constrastTrackBar.Name = "constrastTrackBar";
            constrastTrackBar.Size = new Size(130, 56);
            constrastTrackBar.TabIndex = 3;
            constrastTrackBar.Scroll += constrastTrackBar_Scroll;
            // 
            // constrastDomainUpDown
            // 
            constrastDomainUpDown.Location = new Point(201, 65);
            constrastDomainUpDown.Name = "constrastDomainUpDown";
            constrastDomainUpDown.Size = new Size(84, 27);
            constrastDomainUpDown.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 1055);
            Controls.Add(tabControl1);
            Controls.Add(changeContrastLabel);
            Controls.Add(changeContrastTextBox);
            Controls.Add(changeContrastButton);
            Controls.Add(changeGlowLabel);
            Controls.Add(changeGlowTextBox);
            Controls.Add(changeGlowButton);
            Controls.Add(HeightCropLabel);
            Controls.Add(widthCropLabel);
            Controls.Add(yCropLabel);
            Controls.Add(xCropLabel);
            Controls.Add(yPositionCrop);
            Controls.Add(xPositionCrop);
            Controls.Add(heightCrop);
            Controls.Add(widthCrop);
            Controls.Add(label1);
            Controls.Add(panelPictureBox2);
            Controls.Add(trackBar1);
            Controls.Add(panelPictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)constrastTrackBar).EndInit();
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
        private ToolStripMenuItem cropToolStripMenuItem;
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
        private Label changeGlowLabel;
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
        private TrackBar constrastTrackBar;
        private DomainUpDown constrastDomainUpDown;
    }
}