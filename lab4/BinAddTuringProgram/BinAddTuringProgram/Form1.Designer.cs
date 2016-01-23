namespace BinAddTuringProgram
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
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.takeStepButton = new System.Windows.Forms.Button();
            this.typeYourTapeField = new System.Windows.Forms.TextBox();
            this.typeYourTapeLabel = new System.Windows.Forms.Label();
            this.loadTapeCheckBox = new System.Windows.Forms.CheckBox();
            this.loadTapeButton = new System.Windows.Forms.Button();
            this.onTapeLabel = new System.Windows.Forms.Label();
            this.onTapeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(11, 181);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(356, 112);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = "";
            // 
            // takeStepButton
            // 
            this.takeStepButton.Location = new System.Drawing.Point(11, 130);
            this.takeStepButton.Name = "takeStepButton";
            this.takeStepButton.Size = new System.Drawing.Size(356, 45);
            this.takeStepButton.TabIndex = 1;
            this.takeStepButton.Text = "Take step";
            this.takeStepButton.UseVisualStyleBackColor = true;
            this.takeStepButton.Click += new System.EventHandler(this.takeStepButton_Click);
            // 
            // typeYourTapeField
            // 
            this.typeYourTapeField.Location = new System.Drawing.Point(11, 31);
            this.typeYourTapeField.Name = "typeYourTapeField";
            this.typeYourTapeField.Size = new System.Drawing.Size(355, 20);
            this.typeYourTapeField.TabIndex = 2;
            // 
            // typeYourTapeLabel
            // 
            this.typeYourTapeLabel.AutoSize = true;
            this.typeYourTapeLabel.Location = new System.Drawing.Point(8, 15);
            this.typeYourTapeLabel.Name = "typeYourTapeLabel";
            this.typeYourTapeLabel.Size = new System.Drawing.Size(148, 13);
            this.typeYourTapeLabel.TabIndex = 3;
            this.typeYourTapeLabel.Text = "Type your tape content string:";
            // 
            // loadTapeCheckBox
            // 
            this.loadTapeCheckBox.AutoSize = true;
            this.loadTapeCheckBox.Location = new System.Drawing.Point(11, 67);
            this.loadTapeCheckBox.Name = "loadTapeCheckBox";
            this.loadTapeCheckBox.Size = new System.Drawing.Size(152, 17);
            this.loadTapeCheckBox.TabIndex = 4;
            this.loadTapeCheckBox.Text = "Load tape content from file";
            this.loadTapeCheckBox.UseVisualStyleBackColor = true;
            this.loadTapeCheckBox.CheckStateChanged += new System.EventHandler(this.loadTapeCheckBox_CheckStateChanged);
            // 
            // loadTapeButton
            // 
            this.loadTapeButton.Enabled = false;
            this.loadTapeButton.Location = new System.Drawing.Point(169, 62);
            this.loadTapeButton.Name = "loadTapeButton";
            this.loadTapeButton.Size = new System.Drawing.Size(197, 25);
            this.loadTapeButton.TabIndex = 5;
            this.loadTapeButton.Text = "Load from file";
            this.loadTapeButton.UseVisualStyleBackColor = true;
            this.loadTapeButton.Click += new System.EventHandler(this.loadTapeButton_Click);
            // 
            // onTapeLabel
            // 
            this.onTapeLabel.AutoSize = true;
            this.onTapeLabel.Enabled = false;
            this.onTapeLabel.Location = new System.Drawing.Point(8, 102);
            this.onTapeLabel.Name = "onTapeLabel";
            this.onTapeLabel.Size = new System.Drawing.Size(74, 13);
            this.onTapeLabel.TabIndex = 6;
            this.onTapeLabel.Text = "Tape from file:";
            // 
            // onTapeValue
            // 
            this.onTapeValue.AutoSize = true;
            this.onTapeValue.Enabled = false;
            this.onTapeValue.Location = new System.Drawing.Point(88, 102);
            this.onTapeValue.Name = "onTapeValue";
            this.onTapeValue.Size = new System.Drawing.Size(10, 13);
            this.onTapeValue.TabIndex = 7;
            this.onTapeValue.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 305);
            this.Controls.Add(this.onTapeValue);
            this.Controls.Add(this.onTapeLabel);
            this.Controls.Add(this.loadTapeButton);
            this.Controls.Add(this.loadTapeCheckBox);
            this.Controls.Add(this.typeYourTapeLabel);
            this.Controls.Add(this.typeYourTapeField);
            this.Controls.Add(this.takeStepButton);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "BinAddTuringMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button takeStepButton;
        private System.Windows.Forms.TextBox typeYourTapeField;
        private System.Windows.Forms.Label typeYourTapeLabel;
        private System.Windows.Forms.CheckBox loadTapeCheckBox;
        private System.Windows.Forms.Button loadTapeButton;
        private System.Windows.Forms.Label onTapeLabel;
        private System.Windows.Forms.Label onTapeValue;
    }
}

