namespace PersonAddresses
{
    partial class PersonEntry
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            addressListBox = new ListBox();
            addressButton = new Button();
            addPersonButton = new Button();
            addressesLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(38, 21);
            firstNameLabel.Margin = new Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(123, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "firstName:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(38, 68);
            lastNameLabel.Margin = new Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(119, 32);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "lastName:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(38, 117);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(76, 32);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(166, 20);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(236, 39);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(166, 65);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(236, 39);
            lastNameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(123, 114);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(279, 39);
            emailTextBox.TabIndex = 3;
            // 
            // addressListBox
            // 
            addressListBox.FormattingEnabled = true;
            addressListBox.ItemHeight = 32;
            addressListBox.Location = new Point(38, 222);
            addressListBox.Name = "addressListBox";
            addressListBox.Size = new Size(458, 228);
            addressListBox.TabIndex = 0;
            // 
            // addressButton
            // 
            addressButton.Location = new Point(376, 174);
            addressButton.Name = "addressButton";
            addressButton.Size = new Size(120, 42);
            addressButton.TabIndex = 4;
            addressButton.Text = "Add";
            addressButton.UseVisualStyleBackColor = true;
            addressButton.Click += addressButton_Click;
            // 
            // addPersonButton
            // 
            addPersonButton.Location = new Point(235, 467);
            addPersonButton.Name = "addPersonButton";
            addPersonButton.Size = new Size(155, 52);
            addPersonButton.TabIndex = 0;
            addPersonButton.Text = "Create";
            addPersonButton.UseVisualStyleBackColor = true;
            addPersonButton.Click += addPersonButton_Click;
            // 
            // addressesLabel
            // 
            addressesLabel.AutoSize = true;
            addressesLabel.Location = new Point(38, 179);
            addressesLabel.Margin = new Padding(6, 0, 6, 0);
            addressesLabel.Name = "addressesLabel";
            addressesLabel.Size = new Size(121, 32);
            addressesLabel.TabIndex = 0;
            addressesLabel.Text = "Addresses";
            // 
            // PersonEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 531);
            Controls.Add(addressesLabel);
            Controls.Add(addPersonButton);
            Controls.Add(addressButton);
            Controls.Add(addressListBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "PersonEntry";
            Text = "Person Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private ListBox addressListBox;
        private Button addressButton;
        private Button addPersonButton;
        private Label addressesLabel;
    }
}