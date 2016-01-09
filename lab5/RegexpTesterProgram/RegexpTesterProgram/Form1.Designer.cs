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
            this.typeStringLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.standardRegexpComboBox = new System.Windows.Forms.ComboBox();
            this.typedStringField = new System.Windows.Forms.TextBox();
            this.selectStandardLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.regexpGroupBox = new System.Windows.Forms.GroupBox();
            this.typeRegexpLabel = new System.Windows.Forms.Label();
            this.testStringsGroupBox = new System.Windows.Forms.GroupBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.loadedStringsComboBox = new System.Windows.Forms.ComboBox();
            this.selectStringLabel = new System.Windows.Forms.Label();
            this.regexpGroupBox.SuspendLayout();
            this.testStringsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typedRegexpField
            // 
            this.typedRegexpField.Location = new System.Drawing.Point(128, 22);
            this.typedRegexpField.Name = "typedRegexpField";
            this.typedRegexpField.Size = new System.Drawing.Size(283, 20);
            this.typedRegexpField.TabIndex = 0;
            // 
            // typeStringLabel
            // 
            this.typeStringLabel.AutoSize = true;
            this.typeStringLabel.Location = new System.Drawing.Point(7, 26);
            this.typeStringLabel.Name = "typeStringLabel";
            this.typeStringLabel.Size = new System.Drawing.Size(108, 13);
            this.typeStringLabel.TabIndex = 4;
            this.typeStringLabel.Text = "Type your own string:";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 225);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(417, 42);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // standardRegexpComboBox
            // 
            this.standardRegexpComboBox.FormattingEnabled = true;
            this.standardRegexpComboBox.Location = new System.Drawing.Point(210, 59);
            this.standardRegexpComboBox.Name = "standardRegexpComboBox";
            this.standardRegexpComboBox.Size = new System.Drawing.Size(201, 21);
            this.standardRegexpComboBox.TabIndex = 3;
            // 
            // typedStringField
            // 
            this.typedStringField.Location = new System.Drawing.Point(128, 23);
            this.typedStringField.Name = "typedStringField";
            this.typedStringField.Size = new System.Drawing.Size(283, 20);
            this.typedStringField.TabIndex = 6;
            // 
            // selectStandardLabel
            // 
            this.selectStandardLabel.AutoSize = true;
            this.selectStandardLabel.Location = new System.Drawing.Point(7, 62);
            this.selectStandardLabel.Name = "selectStandardLabel";
            this.selectStandardLabel.Size = new System.Drawing.Size(172, 13);
            this.selectStandardLabel.TabIndex = 7;
            this.selectStandardLabel.Text = "Select standard regular expression:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 282);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(417, 46);
            this.resultBox.TabIndex = 8;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result:";
            // 
            // regexpGroupBox
            // 
            this.regexpGroupBox.Controls.Add(this.typeRegexpLabel);
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
            // typeRegexpLabel
            // 
            this.typeRegexpLabel.AutoSize = true;
            this.typeRegexpLabel.Location = new System.Drawing.Point(7, 25);
            this.typeRegexpLabel.Name = "typeRegexpLabel";
            this.typeRegexpLabel.Size = new System.Drawing.Size(115, 13);
            this.typeRegexpLabel.TabIndex = 1;
            this.typeRegexpLabel.Text = "Type your own regexp:";
            // 
            // testStringsGroupBox
            // 
            this.testStringsGroupBox.Controls.Add(this.selectStringLabel);
            this.testStringsGroupBox.Controls.Add(this.loadedStringsComboBox);
            this.testStringsGroupBox.Controls.Add(this.loadButton);
            this.testStringsGroupBox.Controls.Add(this.typeStringLabel);
            this.testStringsGroupBox.Controls.Add(this.typedStringField);
            this.testStringsGroupBox.Location = new System.Drawing.Point(12, 115);
            this.testStringsGroupBox.Name = "testStringsGroupBox";
            this.testStringsGroupBox.Size = new System.Drawing.Size(417, 95);
            this.testStringsGroupBox.TabIndex = 10;
            this.testStringsGroupBox.TabStop = false;
            this.testStringsGroupBox.Text = "Test strings";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(10, 53);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(105, 36);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load from file";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // loadedStringsComboBox
            // 
            this.loadedStringsComboBox.FormattingEnabled = true;
            this.loadedStringsComboBox.Location = new System.Drawing.Point(210, 62);
            this.loadedStringsComboBox.Name = "loadedStringsComboBox";
            this.loadedStringsComboBox.Size = new System.Drawing.Size(201, 21);
            this.loadedStringsComboBox.TabIndex = 8;
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
            this.regexpGroupBox.ResumeLayout(false);
            this.regexpGroupBox.PerformLayout();
            this.testStringsGroupBox.ResumeLayout(false);
            this.testStringsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox typedRegexpField;
        private System.Windows.Forms.Label typeStringLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ComboBox standardRegexpComboBox;
        private System.Windows.Forms.TextBox typedStringField;
        private System.Windows.Forms.Label selectStandardLabel;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.GroupBox regexpGroupBox;
        private System.Windows.Forms.Label typeRegexpLabel;
        private System.Windows.Forms.GroupBox testStringsGroupBox;
        private System.Windows.Forms.Label selectStringLabel;
        private System.Windows.Forms.ComboBox loadedStringsComboBox;
        private System.Windows.Forms.Button loadButton;
    }
}

