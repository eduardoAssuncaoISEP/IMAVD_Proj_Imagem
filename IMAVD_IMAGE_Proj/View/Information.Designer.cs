namespace IMAVD_IMAGE_Proj
{
    partial class Information
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
            image_name = new Label();
            image_extension = new Label();
            image_location = new Label();
            image_dimension = new Label();
            image_size = new Label();
            image_created = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // image_name
            // 
            image_name.AutoSize = true;
            image_name.Location = new Point(31, 23);
            image_name.Name = "image_name";
            image_name.Size = new Size(49, 20);
            image_name.TabIndex = 0;
            image_name.Text = "Name";
            // 
            // image_extension
            // 
            image_extension.AutoSize = true;
            image_extension.Location = new Point(31, 76);
            image_extension.Name = "image_extension";
            image_extension.Size = new Size(72, 20);
            image_extension.TabIndex = 1;
            image_extension.Text = "Extension";
            // 
            // image_location
            // 
            image_location.AutoSize = true;
            image_location.Location = new Point(31, 130);
            image_location.Name = "image_location";
            image_location.Size = new Size(66, 20);
            image_location.TabIndex = 2;
            image_location.Text = "Location";
            // 
            // image_dimension
            // 
            image_dimension.AutoSize = true;
            image_dimension.Location = new Point(31, 178);
            image_dimension.Name = "image_dimension";
            image_dimension.Size = new Size(80, 20);
            image_dimension.TabIndex = 3;
            image_dimension.Text = "Dimension";
            // 
            // image_size
            // 
            image_size.AutoSize = true;
            image_size.Location = new Point(31, 229);
            image_size.Name = "image_size";
            image_size.Size = new Size(36, 20);
            image_size.TabIndex = 4;
            image_size.Text = "Size";
            // 
            // image_created
            // 
            image_created.AutoSize = true;
            image_created.Location = new Point(31, 277);
            image_created.Name = "image_created";
            image_created.Size = new Size(82, 20);
            image_created.TabIndex = 5;
            image_created.Text = "Created on";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 2);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 56);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Extension:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 110);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 158);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "Dimension:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 209);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 10;
            label5.Text = "Size:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 257);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 11;
            label6.Text = "Created On:";
            // 
            // button1
            // 
            button1.Location = new Point(159, 315);
            button1.Name = "button1";
            button1.Size = new Size(44, 29);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Properties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 356);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(image_created);
            Controls.Add(image_size);
            Controls.Add(image_dimension);
            Controls.Add(image_location);
            Controls.Add(image_extension);
            Controls.Add(image_name);
            Name = "Properties";
            Text = "Image Info.";
            Load += Properties_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label image_name;
        private Label image_extension;
        private Label image_location;
        private Label image_dimension;
        private Label image_size;
        private Label image_created;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}