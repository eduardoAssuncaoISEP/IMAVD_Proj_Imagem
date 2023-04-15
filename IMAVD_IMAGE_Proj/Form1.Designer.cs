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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panelPictureBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, inforToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(749, 28);
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
            pictureBox2.Location = new Point(3, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(397, 330);
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
            panelPictureBox1.Size = new Size(403, 360);
            panelPictureBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.Location = new Point(431, 99);
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
            panelPictureBox2.Location = new Point(12, 406);
            panelPictureBox2.Name = "panelPictureBox2";
            panelPictureBox2.Size = new Size(403, 360);
            panelPictureBox2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(421, 86);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 12;
            label1.Text = "ZOOM";
            // 
            // widthCrop
            // 
            widthCrop.Location = new Point(584, 168);
            widthCrop.Name = "widthCrop";
            widthCrop.Size = new Size(125, 27);
            widthCrop.TabIndex = 13;
            // 
            // heightCrop
            // 
            heightCrop.Location = new Point(584, 216);
            heightCrop.Name = "heightCrop";
            heightCrop.Size = new Size(125, 27);
            heightCrop.TabIndex = 14;
            // 
            // yPositionCrop
            // 
            yPositionCrop.Location = new Point(584, 120);
            yPositionCrop.Name = "yPositionCrop";
            yPositionCrop.Size = new Size(125, 27);
            yPositionCrop.TabIndex = 16;
            // 
            // xPositionCrop
            // 
            xPositionCrop.Location = new Point(584, 64);
            xPositionCrop.Name = "xPositionCrop";
            xPositionCrop.Size = new Size(125, 27);
            xPositionCrop.TabIndex = 15;
            // 
            // xCropLabel
            // 
            xCropLabel.AutoSize = true;
            xCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            xCropLabel.Location = new Point(559, 67);
            xCropLabel.Name = "xCropLabel";
            xCropLabel.Size = new Size(23, 20);
            xCropLabel.TabIndex = 17;
            xCropLabel.Text = "X:";
            // 
            // yCropLabel
            // 
            yCropLabel.AutoSize = true;
            yCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            yCropLabel.Location = new Point(559, 123);
            yCropLabel.Name = "yCropLabel";
            yCropLabel.Size = new Size(22, 20);
            yCropLabel.TabIndex = 18;
            yCropLabel.Text = "Y:";
            // 
            // HeightCropLabel
            // 
            HeightCropLabel.AutoSize = true;
            HeightCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HeightCropLabel.Location = new Point(510, 219);
            HeightCropLabel.Name = "HeightCropLabel";
            HeightCropLabel.Size = new Size(68, 20);
            HeightCropLabel.TabIndex = 20;
            HeightCropLabel.Text = "HEIGHT:";
            // 
            // widthCropLabel
            // 
            widthCropLabel.AutoSize = true;
            widthCropLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            widthCropLabel.Location = new Point(515, 171);
            widthCropLabel.Name = "widthCropLabel";
            widthCropLabel.Size = new Size(63, 20);
            widthCropLabel.TabIndex = 19;
            widthCropLabel.Text = "WIDTH:";
            // 
            // saveCropButton
            // 
            saveCropButton.Enabled = false;
            saveCropButton.Location = new Point(602, 274);
            saveCropButton.Name = "saveCropButton";
            saveCropButton.Size = new Size(94, 29);
            saveCropButton.TabIndex = 21;
            saveCropButton.Text = "Save Crop";
            saveCropButton.UseVisualStyleBackColor = true;
            saveCropButton.Click += saveCropButton_Click;
            // 
            // changeGlowButton
            // 
            changeGlowButton.Location = new Point(589, 399);
            changeGlowButton.Name = "changeGlowButton";
            changeGlowButton.Size = new Size(94, 29);
            changeGlowButton.TabIndex = 22;
            changeGlowButton.Text = "Change Glow";
            changeGlowButton.UseVisualStyleBackColor = true;
            changeGlowButton.Click += changeGlowButton_Click;
            // 
            // changeGlowTextBox
            // 
            changeGlowTextBox.Location = new Point(571, 366);
            changeGlowTextBox.Name = "changeGlowTextBox";
            changeGlowTextBox.Size = new Size(125, 27);
            changeGlowTextBox.TabIndex = 23;
            // 
            // changeGlowLabel
            // 
            changeGlowLabel.AutoSize = true;
            changeGlowLabel.Location = new Point(583, 340);
            changeGlowLabel.Name = "changeGlowLabel";
            changeGlowLabel.Size = new Size(97, 20);
            changeGlowLabel.TabIndex = 24;
            changeGlowLabel.Text = "Change Glow";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 829);
            Controls.Add(changeGlowLabel);
            Controls.Add(changeGlowTextBox);
            Controls.Add(changeGlowButton);
            Controls.Add(saveCropButton);
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
    }
}