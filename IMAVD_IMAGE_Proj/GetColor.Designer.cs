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
            components = new System.ComponentModel.Container();
            getColorPictureBox = new PictureBox();
            getColorPanel = new Panel();
            getColorButton = new Button();
            getColorTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)getColorPictureBox).BeginInit();
            SuspendLayout();
            // 
            // getColorPictureBox
            // 
            getColorPictureBox.Location = new Point(34, 47);
            getColorPictureBox.Name = "getColorPictureBox";
            getColorPictureBox.Size = new Size(361, 329);
            getColorPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            getColorPictureBox.TabIndex = 0;
            getColorPictureBox.TabStop = false;
            getColorPictureBox.MouseClick += getColorImage_MouseClick;
            getColorPictureBox.MouseMove += getColorImage_MouseMove;
            // 
            // getColorPanel
            // 
            getColorPanel.Location = new Point(527, 70);
            getColorPanel.Name = "getColorPanel";
            getColorPanel.Size = new Size(250, 125);
            getColorPanel.TabIndex = 1;
            // 
            // getColorButton
            // 
            getColorButton.Location = new Point(609, 316);
            getColorButton.Name = "getColorButton";
            getColorButton.Size = new Size(94, 29);
            getColorButton.TabIndex = 3;
            getColorButton.Text = "OK";
            getColorButton.UseVisualStyleBackColor = true;
            getColorButton.Click += getColorButton_Click;
            // 
            // getColorTextBox
            // 
            getColorTextBox.Location = new Point(527, 201);
            getColorTextBox.Name = "getColorTextBox";
            getColorTextBox.Size = new Size(250, 27);
            getColorTextBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // GetColor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 759);
            Controls.Add(getColorTextBox);
            Controls.Add(getColorButton);
            Controls.Add(getColorPanel);
            Controls.Add(getColorPictureBox);
            Name = "GetColor";
            Text = "GetColor";
            Load += GetColor_Load;
            ((System.ComponentModel.ISupportInitialize)getColorPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox getColorPictureBox;
        private Panel getColorPanel;
        private Button getColorButton;
        private TextBox getColorTextBox;
        private ContextMenuStrip contextMenuStrip1;
    }
}