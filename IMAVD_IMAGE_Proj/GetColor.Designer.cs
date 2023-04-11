namespace IMAVD_IMAGE_Proj
{
    partial class GetColor
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
            getColorPictureBox = new PictureBox();
            getColorPanel = new Panel();
            getColorLabel = new Label();
            getColorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)getColorPictureBox).BeginInit();
            SuspendLayout();
            // 
            // getColorPictureBox
            // 
            getColorPictureBox.Location = new Point(34, 47);
            getColorPictureBox.Name = "getColorPictureBox";
            getColorPictureBox.Size = new Size(311, 325);
            getColorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            getColorPictureBox.TabIndex = 0;
            getColorPictureBox.TabStop = false;
            // 
            // getColorPanel
            // 
            getColorPanel.Location = new Point(442, 72);
            getColorPanel.Name = "getColorPanel";
            getColorPanel.Size = new Size(250, 125);
            getColorPanel.TabIndex = 1;
            // 
            // getColorLabel
            // 
            getColorLabel.AutoSize = true;
            getColorLabel.Location = new Point(549, 242);
            getColorLabel.Name = "getColorLabel";
            getColorLabel.Size = new Size(50, 20);
            getColorLabel.TabIndex = 2;
            getColorLabel.Text = "label1";
            // 
            // getColorButton
            // 
            getColorButton.Location = new Point(527, 318);
            getColorButton.Name = "getColorButton";
            getColorButton.Size = new Size(94, 29);
            getColorButton.TabIndex = 3;
            getColorButton.Text = "OK";
            getColorButton.UseVisualStyleBackColor = true;
            getColorButton.Click += getColorButton_Click;
            // 
            // GetColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(getColorButton);
            Controls.Add(getColorLabel);
            Controls.Add(getColorPanel);
            Controls.Add(getColorPictureBox);
            Name = "GetColor";
            Text = "GetColor";
            Load += GetColor_Load;
            MouseClick += getColorImage_MouseClick;
            MouseMove += getColorImage_MouseMove;
            ((System.ComponentModel.ISupportInitialize)getColorPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox getColorPictureBox;
        private Panel getColorPanel;
        private Label getColorLabel;
        private Button getColorButton;
    }
}