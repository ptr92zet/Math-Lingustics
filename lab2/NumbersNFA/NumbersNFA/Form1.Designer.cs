namespace NumbersNFA
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNamePath = new System.Windows.Forms.Label();
            this.tokensComboBox = new System.Windows.Forms.ComboBox();
            this.selectTokenLabel = new System.Windows.Forms.Label();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.tokenLengthLabel = new System.Windows.Forms.Label();
            this.tokenLengthValueLabel = new System.Windows.Forms.Label();
            this.currentIndexLabel = new System.Windows.Forms.Label();
            this.currentIndexValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(13, 13);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(125, 29);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select a file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(154, 13);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(55, 13);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File name:";
            // 
            // fileNamePath
            // 
            this.fileNamePath.AutoSize = true;
            this.fileNamePath.Location = new System.Drawing.Point(157, 28);
            this.fileNamePath.Name = "fileNamePath";
            this.fileNamePath.Size = new System.Drawing.Size(0, 13);
            this.fileNamePath.TabIndex = 2;
            // 
            // tokensComboBox
            // 
            this.tokensComboBox.FormattingEnabled = true;
            this.tokensComboBox.Location = new System.Drawing.Point(13, 86);
            this.tokensComboBox.Name = "tokensComboBox";
            this.tokensComboBox.Size = new System.Drawing.Size(125, 21);
            this.tokensComboBox.TabIndex = 3;
            this.tokensComboBox.SelectionChangeCommitted += new System.EventHandler(this.tokensComboBox_SelectionChangeCommitted);
            // 
            // selectTokenLabel
            // 
            this.selectTokenLabel.AutoSize = true;
            this.selectTokenLabel.Location = new System.Drawing.Point(12, 70);
            this.selectTokenLabel.Name = "selectTokenLabel";
            this.selectTokenLabel.Size = new System.Drawing.Size(121, 13);
            this.selectTokenLabel.TabIndex = 4;
            this.selectTokenLabel.Text = "Select token to analyze:";
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(15, 195);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(123, 27);
            this.analyzeButton.TabIndex = 5;
            this.analyzeButton.Text = "Take step!";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(160, 55);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(528, 219);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Text = "";
            // 
            // tokenLengthLabel
            // 
            this.tokenLengthLabel.AutoSize = true;
            this.tokenLengthLabel.Location = new System.Drawing.Point(12, 120);
            this.tokenLengthLabel.Name = "tokenLengthLabel";
            this.tokenLengthLabel.Size = new System.Drawing.Size(73, 13);
            this.tokenLengthLabel.TabIndex = 7;
            this.tokenLengthLabel.Text = "Token length:";
            // 
            // tokenLengthValueLabel
            // 
            this.tokenLengthValueLabel.AutoSize = true;
            this.tokenLengthValueLabel.Location = new System.Drawing.Point(113, 120);
            this.tokenLengthValueLabel.Name = "tokenLengthValueLabel";
            this.tokenLengthValueLabel.Size = new System.Drawing.Size(13, 13);
            this.tokenLengthValueLabel.TabIndex = 8;
            this.tokenLengthValueLabel.Text = "0";
            // 
            // currentIndexLabel
            // 
            this.currentIndexLabel.AutoSize = true;
            this.currentIndexLabel.Location = new System.Drawing.Point(12, 149);
            this.currentIndexLabel.Name = "currentIndexLabel";
            this.currentIndexLabel.Size = new System.Drawing.Size(72, 13);
            this.currentIndexLabel.TabIndex = 9;
            this.currentIndexLabel.Text = "Current index:";
            // 
            // currentIndexValueLabel
            // 
            this.currentIndexValueLabel.AutoSize = true;
            this.currentIndexValueLabel.Location = new System.Drawing.Point(113, 149);
            this.currentIndexValueLabel.Name = "currentIndexValueLabel";
            this.currentIndexValueLabel.Size = new System.Drawing.Size(13, 13);
            this.currentIndexValueLabel.TabIndex = 10;
            this.currentIndexValueLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 286);
            this.Controls.Add(this.currentIndexValueLabel);
            this.Controls.Add(this.currentIndexLabel);
            this.Controls.Add(this.tokenLengthValueLabel);
            this.Controls.Add(this.tokenLengthLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.selectTokenLabel);
            this.Controls.Add(this.tokensComboBox);
            this.Controls.Add(this.fileNamePath);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.selectFileButton);
            this.Name = "Form1";
            this.Text = "Numbers NFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileNamePath;
        private System.Windows.Forms.ComboBox tokensComboBox;
        private System.Windows.Forms.Label selectTokenLabel;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label tokenLengthLabel;
        private System.Windows.Forms.Label tokenLengthValueLabel;
        private System.Windows.Forms.Label currentIndexLabel;
        private System.Windows.Forms.Label currentIndexValueLabel;
    }
}

