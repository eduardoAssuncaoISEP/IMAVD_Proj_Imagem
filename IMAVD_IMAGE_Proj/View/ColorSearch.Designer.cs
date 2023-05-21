namespace IMAVD_IMAGE_Proj
{
    partial class ColorSearch
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
            pictureBox1 = new PictureBox();
            pickColor = new Button();
            selectColorPanel = new Panel();
            colorSelectName = new Label();
            colorDialog1 = new ColorDialog();
            colorDetectButton = new Button();
            getColorCountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pickColor
            // 
            pickColor.Location = new Point(432, 33);
            pickColor.Name = "pickColor";
            pickColor.Size = new Size(94, 29);
            pickColor.TabIndex = 1;
            pickColor.Text = "Pick Color";
            pickColor.UseVisualStyleBackColor = true;
            pickColor.Click += button1_Click;
            // 
            // selectColorPanel
            // 
            selectColorPanel.Location = new Point(532, 32);
            selectColorPanel.Name = "selectColorPanel";
            selectColorPanel.Size = new Size(90, 30);
            selectColorPanel.TabIndex = 2;
            // 
            // colorSelectName
            // 
            colorSelectName.AutoSize = true;
            colorSelectName.Location = new Point(628, 37);
            colorSelectName.Name = "colorSelectName";
            colorSelectName.Size = new Size(85, 20);
            colorSelectName.TabIndex = 3;
            colorSelectName.Text = "SelectColor";
            colorSelectName.Click += label1_Click;
            // 
            // colorDetectButton
            // 
            colorDetectButton.Location = new Point(509, 105);
            colorDetectButton.Name = "colorDetectButton";
            colorDetectButton.Size = new Size(142, 29);
            colorDetectButton.TabIndex = 4;
            colorDetectButton.Text = "Detect Color";
            colorDetectButton.UseVisualStyleBackColor = true;
            colorDetectButton.Click += button1_Click_1;
            // 
            // getColorCountLabel
            // 
            getColorCountLabel.AutoSize = true;
            getColorCountLabel.Location = new Point(509, 157);
            getColorCountLabel.Name = "getColorCountLabel";
            getColorCountLabel.Size = new Size(85, 20);
            getColorCountLabel.TabIndex = 6;
            getColorCountLabel.Text = "CountPixels";
            // 
            // ColorSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(getColorCountLabel);
            Controls.Add(colorDetectButton);
            Controls.Add(colorSelectName);
            Controls.Add(selectColorPanel);
            Controls.Add(pickColor);
            Controls.Add(pictureBox1);
            Name = "ColorSearch";
            Text = "ColorSearch";
            Load += ColorSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button pickColor;
        private Panel selectColorPanel;
        private Label colorSelectName;
        private ColorDialog colorDialog1;
        private Button colorDetectButton;
        private Label getColorCountLabel;
    }
}