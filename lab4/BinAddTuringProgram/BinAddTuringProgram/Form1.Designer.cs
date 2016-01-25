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
            this.takeStepButton = new System.Windows.Forms.Button();
            this.typeYourTapeField = new System.Windows.Forms.TextBox();
            this.typeYourTapeLabel = new System.Windows.Forms.Label();
            this.loadTapeCheckBox = new System.Windows.Forms.CheckBox();
            this.loadTapeButton = new System.Windows.Forms.Button();
            this.onTapeLabel = new System.Windows.Forms.Label();
            this.onTapeValue = new System.Windows.Forms.Label();
            this.tapeLabel = new System.Windows.Forms.Label();
            this.tapeStateLabel = new System.Windows.Forms.Label();
            this.tapePositionLabel = new System.Windows.Forms.Label();
            this.consoleBox = new System.Windows.Forms.RichTextBox();
            this.initializeTapeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // takeStepButton
            // 
            this.takeStepButton.Location = new System.Drawing.Point(116, 129);
            this.takeStepButton.Name = "takeStepButton";
            this.takeStepButton.Size = new System.Drawing.Size(251, 45);
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
            this.onTapeLabel.Location = new System.Drawing.Point(9, 102);
            this.onTapeLabel.Name = "onTapeLabel";
            this.onTapeLabel.Size = new System.Drawing.Size(74, 13);
            this.onTapeLabel.TabIndex = 6;
            this.onTapeLabel.Text = "Tape from file:";
            // 
            // onTapeValue
            // 
            this.onTapeValue.AutoSize = true;
            this.onTapeValue.Enabled = false;
            this.onTapeValue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.onTapeValue.Location = new System.Drawing.Point(89, 102);
            this.onTapeValue.Name = "onTapeValue";
            this.onTapeValue.Size = new System.Drawing.Size(13, 13);
            this.onTapeValue.TabIndex = 7;
            this.onTapeValue.Text = " ";
            // 
            // tapeLabel
            // 
            this.tapeLabel.AutoSize = true;
            this.tapeLabel.Location = new System.Drawing.Point(12, 189);
            this.tapeLabel.Name = "tapeLabel";
            this.tapeLabel.Size = new System.Drawing.Size(35, 13);
            this.tapeLabel.TabIndex = 8;
            this.tapeLabel.Text = "Tape:";
            // 
            // tapeStateLabel
            // 
            this.tapeStateLabel.AutoSize = true;
            this.tapeStateLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tapeStateLabel.Location = new System.Drawing.Point(53, 190);
            this.tapeStateLabel.Name = "tapeStateLabel";
            this.tapeStateLabel.Size = new System.Drawing.Size(0, 13);
            this.tapeStateLabel.TabIndex = 9;
            this.tapeStateLabel.Text = " ";
            // 
            // tapePositionLabel
            // 
            this.tapePositionLabel.AutoSize = true;
            this.tapePositionLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tapePositionLabel.Location = new System.Drawing.Point(53, 203);
            this.tapePositionLabel.Name = "tapePositionLabel";
            this.tapePositionLabel.Size = new System.Drawing.Size(0, 13);
            this.tapePositionLabel.TabIndex = 10;
            this.tapePositionLabel.Text = " ";
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(15, 227);
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(351, 96);
            this.consoleBox.TabIndex = 11;
            this.consoleBox.Text = "";
            // 
            // initializeTapeButton
            // 
            this.initializeTapeButton.Location = new System.Drawing.Point(15, 129);
            this.initializeTapeButton.Name = "initializeTapeButton";
            this.initializeTapeButton.Size = new System.Drawing.Size(95, 45);
            this.initializeTapeButton.TabIndex = 12;
            this.initializeTapeButton.Text = "Initialize";
            this.initializeTapeButton.UseVisualStyleBackColor = true;
            this.initializeTapeButton.Click += new System.EventHandler(this.initializeTapeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 335);
            this.Controls.Add(this.initializeTapeButton);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.tapePositionLabel);
            this.Controls.Add(this.tapeStateLabel);
            this.Controls.Add(this.tapeLabel);
            this.Controls.Add(this.onTapeValue);
            this.Controls.Add(this.onTapeLabel);
            this.Controls.Add(this.loadTapeButton);
            this.Controls.Add(this.loadTapeCheckBox);
            this.Controls.Add(this.typeYourTapeLabel);
            this.Controls.Add(this.typeYourTapeField);
            this.Controls.Add(this.takeStepButton);
            this.Name = "Form1";
            this.Text = "BinAddTuringMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button takeStepButton;
        private System.Windows.Forms.TextBox typeYourTapeField;
        private System.Windows.Forms.Label typeYourTapeLabel;
        private System.Windows.Forms.CheckBox loadTapeCheckBox;
        private System.Windows.Forms.Button loadTapeButton;
        private System.Windows.Forms.Label onTapeLabel;
        private System.Windows.Forms.Label onTapeValue;
        private System.Windows.Forms.Label tapeLabel;
        private System.Windows.Forms.Label tapeStateLabel;
        private System.Windows.Forms.Label tapePositionLabel;
        private System.Windows.Forms.RichTextBox consoleBox;
        private System.Windows.Forms.Button initializeTapeButton;
    }
}

