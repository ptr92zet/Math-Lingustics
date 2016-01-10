namespace RegexpTesterProgram
{
    partial class Form1
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
            this.typedRegexpField = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.standardRegexpComboBox = new System.Windows.Forms.ComboBox();
            this.typedStringField = new System.Windows.Forms.TextBox();
            this.selectStandardLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.regexpGroupBox = new System.Windows.Forms.GroupBox();
            this.typeRegexpCheckBox = new System.Windows.Forms.CheckBox();
            this.testStringsGroupBox = new System.Windows.Forms.GroupBox();
            this.typeStringCheckBox = new System.Windows.Forms.CheckBox();
            this.selectStringLabel = new System.Windows.Forms.Label();
            this.loadedStringsComboBox = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.resultBox.SuspendLayout();
            this.regexpGroupBox.SuspendLayout();
            this.testStringsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typedRegexpField
            // 
            this.typedRegexpField.Enabled = false;
            this.typedRegexpField.Location = new System.Drawing.Point(128, 22);
            this.typedRegexpField.Name = "typedRegexpField";
            this.typedRegexpField.Size = new System.Drawing.Size(283, 20);
            this.typedRegexpField.TabIndex = 0;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 225);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(417, 42);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // standardRegexpComboBox
            // 
            this.standardRegexpComboBox.FormattingEnabled = true;
            this.standardRegexpComboBox.Items.AddRange(new object[] {
            "IPv4 address",
            "Subnet mask",
            "MAC address",
            "Email address",
            "Integers addition operations",
            "Complex numbers subtraction operations",
            "HTML text formatting markups",
            "HTML table markups"});
            this.standardRegexpComboBox.Location = new System.Drawing.Point(199, 59);
            this.standardRegexpComboBox.Name = "standardRegexpComboBox";
            this.standardRegexpComboBox.Size = new System.Drawing.Size(212, 21);
            this.standardRegexpComboBox.TabIndex = 3;
            this.standardRegexpComboBox.SelectionChangeCommitted += new System.EventHandler(this.standardRegexpComboBox_SelectionChangeCommitted);
            // 
            // typedStringField
            // 
            this.typedStringField.Enabled = false;
            this.typedStringField.Location = new System.Drawing.Point(128, 23);
            this.typedStringField.Name = "typedStringField";
            this.typedStringField.Size = new System.Drawing.Size(283, 20);
            this.typedStringField.TabIndex = 6;
            // 
            // selectStandardLabel
            // 
            this.selectStandardLabel.AutoSize = true;
            this.selectStandardLabel.Location = new System.Drawing.Point(21, 62);
            this.selectStandardLabel.Name = "selectStandardLabel";
            this.selectStandardLabel.Size = new System.Drawing.Size(172, 13);
            this.selectStandardLabel.TabIndex = 7;
            this.selectStandardLabel.Text = "Select standard regular expression:";
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.resultLabel);
            this.resultBox.Location = new System.Drawing.Point(12, 282);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(417, 46);
            this.resultBox.TabIndex = 8;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(178, 19);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(56, 13);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Not tested";
            // 
            // regexpGroupBox
            // 
            this.regexpGroupBox.Controls.Add(this.typeRegexpCheckBox);
            this.regexpGroupBox.Controls.Add(this.selectStandardLabel);
            this.regexpGroupBox.Controls.Add(this.typedRegexpField);
            this.regexpGroupBox.Controls.Add(this.standardRegexpComboBox);
            this.regexpGroupBox.Location = new System.Drawing.Point(12, 5);
            this.regexpGroupBox.Name = "regexpGroupBox";
            this.regexpGroupBox.Size = new System.Drawing.Size(417, 95);
            this.regexpGroupBox.TabIndex = 9;
            this.regexpGroupBox.TabStop = false;
            this.regexpGroupBox.Text = "Regular expressions";
            // 
            // typeRegexpCheckBox
            // 
            this.typeRegexpCheckBox.AutoSize = true;
            this.typeRegexpCheckBox.Location = new System.Drawing.Point(10, 24);
            this.typeRegexpCheckBox.Name = "typeRegexpCheckBox";
            this.typeRegexpCheckBox.Size = new System.Drawing.Size(111, 17);
            this.typeRegexpCheckBox.TabIndex = 11;
            this.typeRegexpCheckBox.Text = "Type your regexp:";
            this.typeRegexpCheckBox.UseVisualStyleBackColor = true;
            this.typeRegexpCheckBox.CheckStateChanged += new System.EventHandler(this.typeRegexpCheckBox_CheckStateChanged);
            // 
            // testStringsGroupBox
            // 
            this.testStringsGroupBox.Controls.Add(this.typeStringCheckBox);
            this.testStringsGroupBox.Controls.Add(this.selectStringLabel);
            this.testStringsGroupBox.Controls.Add(this.loadedStringsComboBox);
            this.testStringsGroupBox.Controls.Add(this.loadButton);
            this.testStringsGroupBox.Controls.Add(this.typedStringField);
            this.testStringsGroupBox.Location = new System.Drawing.Point(12, 115);
            this.testStringsGroupBox.Name = "testStringsGroupBox";
            this.testStringsGroupBox.Size = new System.Drawing.Size(417, 95);
            this.testStringsGroupBox.TabIndex = 10;
            this.testStringsGroupBox.TabStop = false;
            this.testStringsGroupBox.Text = "Test strings";
            // 
            // typeStringCheckBox
            // 
            this.typeStringCheckBox.AutoSize = true;
            this.typeStringCheckBox.Location = new System.Drawing.Point(10, 25);
            this.typeStringCheckBox.Name = "typeStringCheckBox";
            this.typeStringCheckBox.Size = new System.Drawing.Size(104, 17);
            this.typeStringCheckBox.TabIndex = 10;
            this.typeStringCheckBox.Text = "Type your string:";
            this.typeStringCheckBox.UseVisualStyleBackColor = true;
            this.typeStringCheckBox.CheckStateChanged += new System.EventHandler(this.typeStringCheckBox_CheckStateChanged);
            // 
            // selectStringLabel
            // 
            this.selectStringLabel.AutoSize = true;
            this.selectStringLabel.Location = new System.Drawing.Point(125, 65);
            this.selectStringLabel.Name = "selectStringLabel";
            this.selectStringLabel.Size = new System.Drawing.Size(68, 13);
            this.selectStringLabel.TabIndex = 9;
            this.selectStringLabel.Text = "Select string:";
            // 
            // loadedStringsComboBox
            // 
            this.loadedStringsComboBox.FormattingEnabled = true;
            this.loadedStringsComboBox.Location = new System.Drawing.Point(199, 62);
            this.loadedStringsComboBox.Name = "loadedStringsComboBox";
            this.loadedStringsComboBox.Size = new System.Drawing.Size(212, 21);
            this.loadedStringsComboBox.TabIndex = 8;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(24, 53);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(90, 36);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load from file";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 340);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.regexpGroupBox);
            this.Controls.Add(this.testStringsGroupBox);
            this.Name = "Form1";
            this.Text = "RegexpTester - Math Linguistics";
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.regexpGroupBox.ResumeLayout(false);
            this.regexpGroupBox.PerformLayout();
            this.testStringsGroupBox.ResumeLayout(false);
            this.testStringsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox typedRegexpField;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ComboBox standardRegexpComboBox;
        private System.Windows.Forms.TextBox typedStringField;
        private System.Windows.Forms.Label selectStandardLabel;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.GroupBox regexpGroupBox;
        private System.Windows.Forms.GroupBox testStringsGroupBox;
        private System.Windows.Forms.Label selectStringLabel;
        private System.Windows.Forms.ComboBox loadedStringsComboBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.CheckBox typeStringCheckBox;
        private System.Windows.Forms.CheckBox typeRegexpCheckBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

