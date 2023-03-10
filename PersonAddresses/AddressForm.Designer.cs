namespace PersonAddresses
{
    partial class AddressForm
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
            streetAddressLabel = new Label();
            streetAddressTextBox = new TextBox();
            cityLabel = new Label();
            postcodeLabel = new Label();
            cityTextBox = new TextBox();
            postcodeTextBox = new TextBox();
            saveAddressButton = new Button();
            addressEntryLabel = new Label();
            SuspendLayout();
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(43, 104);
            streetAddressLabel.Margin = new Padding(6, 0, 6, 0);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(172, 32);
            streetAddressLabel.TabIndex = 0;
            streetAddressLabel.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(227, 101);
            streetAddressTextBox.Margin = new Padding(6);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(257, 39);
            streetAddressTextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(160, 152);
            cityLabel.Margin = new Padding(6, 0, 6, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(55, 32);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new Point(101, 200);
            postcodeLabel.Margin = new Padding(6, 0, 6, 0);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new Size(114, 32);
            postcodeLabel.TabIndex = 3;
            postcodeLabel.Text = "PostCode";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(227, 149);
            cityTextBox.Margin = new Padding(6);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(257, 39);
            cityTextBox.TabIndex = 4;
            // 
            // postcodeTextBox
            // 
            postcodeTextBox.Location = new Point(227, 197);
            postcodeTextBox.Margin = new Padding(6);
            postcodeTextBox.Name = "postcodeTextBox";
            postcodeTextBox.Size = new Size(257, 39);
            postcodeTextBox.TabIndex = 5;
            // 
            // saveAddressButton
            // 
            saveAddressButton.Location = new Point(175, 262);
            saveAddressButton.Name = "saveAddressButton";
            saveAddressButton.Size = new Size(157, 43);
            saveAddressButton.TabIndex = 6;
            saveAddressButton.Text = "Save";
            saveAddressButton.UseVisualStyleBackColor = true;
            saveAddressButton.Click += saveAddressButton_Click;
            // 
            // addressEntryLabel
            // 
            addressEntryLabel.AutoSize = true;
            addressEntryLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            addressEntryLabel.Location = new Point(132, 24);
            addressEntryLabel.Name = "addressEntryLabel";
            addressEntryLabel.Size = new Size(229, 45);
            addressEntryLabel.TabIndex = 0;
            addressEntryLabel.Text = "Address Entry";
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 342);
            Controls.Add(addressEntryLabel);
            Controls.Add(saveAddressButton);
            Controls.Add(postcodeTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(postcodeLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressTextBox);
            Controls.Add(streetAddressLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "AddressForm";
            Text = "AddressForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label streetAddressLabel;
        private TextBox streetAddressTextBox;
        private Label cityLabel;
        private Label postcodeLabel;
        private TextBox cityTextBox;
        private TextBox postcodeTextBox;
        private Button saveAddressButton;
        private Label addressEntryLabel;
    }
}