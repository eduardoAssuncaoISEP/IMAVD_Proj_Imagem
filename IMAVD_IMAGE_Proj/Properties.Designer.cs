namespace IMAVD_IMAGE_Proj
{
    partial class Properties
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
            // Properties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 336);
            Controls.Add(image_created);
            Controls.Add(image_size);
            Controls.Add(image_dimension);
            Controls.Add(image_location);
            Controls.Add(image_extension);
            Controls.Add(image_name);
            Name = "Properties";
            Text = "Properties";
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
    }
}