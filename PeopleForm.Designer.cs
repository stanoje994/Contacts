namespace WinFormUI
{
    partial class PeopleForm
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.listPeopleListBox = new System.Windows.Forms.ListBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.refreshListButton = new System.Windows.Forms.Button();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(37, 64);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(37, 132);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(39, 91);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(234, 29);
            this.firstNameText.TabIndex = 2;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(39, 159);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(234, 29);
            this.lastNameText.TabIndex = 3;
            // 
            // addPersonHeader
            // 
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(32, 9);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(218, 39);
            this.addPersonHeader.TabIndex = 4;
            this.addPersonHeader.Text = "Add Contact";
            // 
            // listPeopleHeader
            // 
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(381, 9);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(232, 39);
            this.listPeopleHeader.TabIndex = 5;
            this.listPeopleHeader.Text = "List Contacts";
            // 
            // listPeopleListBox
            // 
            this.listPeopleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPeopleListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.listPeopleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleListBox.FormattingEnabled = true;
            this.listPeopleListBox.ItemHeight = 20;
            this.listPeopleListBox.Location = new System.Drawing.Point(388, 55);
            this.listPeopleListBox.Name = "listPeopleListBox";
            this.listPeopleListBox.Size = new System.Drawing.Size(684, 364);
            this.listPeopleListBox.TabIndex = 6;
            this.listPeopleListBox.SelectedIndexChanged += new System.EventHandler(this.listPeopleListBox_SelectedIndexChanged);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(39, 431);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(172, 49);
            this.addPersonButton.TabIndex = 7;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // refreshListButton
            // 
            this.refreshListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshListButton.Location = new System.Drawing.Point(900, 431);
            this.refreshListButton.Name = "refreshListButton";
            this.refreshListButton.Size = new System.Drawing.Size(172, 49);
            this.refreshListButton.TabIndex = 8;
            this.refreshListButton.Text = "Refresh List";
            this.refreshListButton.UseVisualStyleBackColor = true;
            this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberText.Location = new System.Drawing.Point(41, 229);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(234, 29);
            this.PhoneNumberText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phone Number";
            // 
            // AddressText
            // 
            this.AddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(41, 300);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(234, 29);
            this.AddressText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(39, 378);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(234, 29);
            this.EmailText.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Email Address";
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 492);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshListButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.listPeopleListBox);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.ListBox listPeopleListBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button refreshListButton;
        private System.Windows.Forms.TextBox PhoneNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label3;
    }
}

