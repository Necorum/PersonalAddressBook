namespace PersonalAddressBook
{
    partial class AddressBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.StoreBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityStateZipcodeTextboc = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CitySTateZipcodeLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressGrid = new System.Windows.Forms.DataGridView();
            this.ExportCSVbtn = new System.Windows.Forms.Button();
            this.ExportJSONbtn = new System.Windows.Forms.Button();
            this.ExportXMLbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Personal Address Book";
            // 
            // StoreBtn
            // 
            this.StoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreBtn.Location = new System.Drawing.Point(91, 305);
            this.StoreBtn.Name = "StoreBtn";
            this.StoreBtn.Size = new System.Drawing.Size(90, 23);
            this.StoreBtn.TabIndex = 1;
            this.StoreBtn.Text = "Store Info";
            this.StoreBtn.UseVisualStyleBackColor = true;
            this.StoreBtn.Click += new System.EventHandler(this.StoreBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(691, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(90, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(26, 99);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(155, 20);
            this.FirstNameTextbox.TabIndex = 4;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(26, 144);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(155, 20);
            this.LastNameTextbox.TabIndex = 5;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(26, 189);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(155, 20);
            this.AddressTextBox.TabIndex = 6;
            // 
            // CityStateZipcodeTextboc
            // 
            this.CityStateZipcodeTextboc.Location = new System.Drawing.Point(26, 234);
            this.CityStateZipcodeTextboc.Name = "CityStateZipcodeTextboc";
            this.CityStateZipcodeTextboc.Size = new System.Drawing.Size(155, 20);
            this.CityStateZipcodeTextboc.TabIndex = 7;
            // 
            // PhoneNumberTextbox
            // 
            this.PhoneNumberTextbox.Location = new System.Drawing.Point(26, 279);
            this.PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            this.PhoneNumberTextbox.Size = new System.Drawing.Size(155, 20);
            this.PhoneNumberTextbox.TabIndex = 8;
            this.PhoneNumberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextbox_KeyPress);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.MintCream;
            this.FirstNameLabel.Location = new System.Drawing.Point(23, 83);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(61, 13);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "FIrst Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.MintCream;
            this.LastNameLabel.Location = new System.Drawing.Point(23, 128);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.ForeColor = System.Drawing.Color.MintCream;
            this.AddressLabel.Location = new System.Drawing.Point(23, 173);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address:";
            // 
            // CitySTateZipcodeLabel
            // 
            this.CitySTateZipcodeLabel.AutoSize = true;
            this.CitySTateZipcodeLabel.ForeColor = System.Drawing.Color.MintCream;
            this.CitySTateZipcodeLabel.Location = new System.Drawing.Point(23, 218);
            this.CitySTateZipcodeLabel.Name = "CitySTateZipcodeLabel";
            this.CitySTateZipcodeLabel.Size = new System.Drawing.Size(101, 13);
            this.CitySTateZipcodeLabel.TabIndex = 12;
            this.CitySTateZipcodeLabel.Text = "City/State/Zipcode:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.MintCream;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(23, 263);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.PhoneNumberLabel.TabIndex = 13;
            this.PhoneNumberLabel.Text = "Phone Number: ";
            // 
            // AddressGrid
            // 
            this.AddressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGrid.Location = new System.Drawing.Point(206, 99);
            this.AddressGrid.Name = "AddressGrid";
            this.AddressGrid.Size = new System.Drawing.Size(582, 279);
            this.AddressGrid.TabIndex = 14;
            // 
            // ExportCSVbtn
            // 
            this.ExportCSVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportCSVbtn.Location = new System.Drawing.Point(206, 384);
            this.ExportCSVbtn.Name = "ExportCSVbtn";
            this.ExportCSVbtn.Size = new System.Drawing.Size(96, 23);
            this.ExportCSVbtn.TabIndex = 15;
            this.ExportCSVbtn.Text = "Export to CSV";
            this.ExportCSVbtn.UseVisualStyleBackColor = true;
            this.ExportCSVbtn.Click += new System.EventHandler(this.ExportCSVbtn_Click);
            // 
            // ExportJSONbtn
            // 
            this.ExportJSONbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportJSONbtn.Location = new System.Drawing.Point(439, 384);
            this.ExportJSONbtn.Name = "ExportJSONbtn";
            this.ExportJSONbtn.Size = new System.Drawing.Size(106, 23);
            this.ExportJSONbtn.TabIndex = 16;
            this.ExportJSONbtn.Text = "Export to JSON";
            this.ExportJSONbtn.UseVisualStyleBackColor = true;
            this.ExportJSONbtn.Click += new System.EventHandler(this.ExportJSONbtn_Click);
            // 
            // ExportXMLbtn
            // 
            this.ExportXMLbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportXMLbtn.Location = new System.Drawing.Point(691, 384);
            this.ExportXMLbtn.Name = "ExportXMLbtn";
            this.ExportXMLbtn.Size = new System.Drawing.Size(97, 23);
            this.ExportXMLbtn.TabIndex = 17;
            this.ExportXMLbtn.Text = "Export to XML";
            this.ExportXMLbtn.UseVisualStyleBackColor = true;
            this.ExportXMLbtn.Click += new System.EventHandler(this.ExportXMLbtn_Click);
            // 
            // AddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExportXMLbtn);
            this.Controls.Add(this.ExportJSONbtn);
            this.Controls.Add(this.ExportCSVbtn);
            this.Controls.Add(this.AddressGrid);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.CitySTateZipcodeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PhoneNumberTextbox);
            this.Controls.Add(this.CityStateZipcodeTextboc);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StoreBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddressBook";
            this.Text = "AddressBook";
            this.Load += new System.EventHandler(this.AddressBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddressGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StoreBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CityStateZipcodeTextboc;
        private System.Windows.Forms.TextBox PhoneNumberTextbox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CitySTateZipcodeLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.DataGridView AddressGrid;
        private System.Windows.Forms.Button ExportCSVbtn;
        private System.Windows.Forms.Button ExportJSONbtn;
        private System.Windows.Forms.Button ExportXMLbtn;
    }
}

