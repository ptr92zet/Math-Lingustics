namespace ParkometerDFATuring
{
    partial class ParkometerDFATuringForm
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
            this.coinToInsertLabel = new System.Windows.Forms.Label();
            this.button1PLN = new System.Windows.Forms.Button();
            this.button2PLN = new System.Windows.Forms.Button();
            this.button5PLN = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.readTapeButton = new System.Windows.Forms.Button();
            this.onTapeLabel = new System.Windows.Forms.Label();
            this.tapeContentLabel = new System.Windows.Forms.Label();
            this.currentTapeIndexLabel = new System.Windows.Forms.Label();
            this.currentTapeIndex = new System.Windows.Forms.Label();
            this.initializeButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.clearButon = new System.Windows.Forms.Button();
            this.onTapeValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coinToInsertLabel
            // 
            this.coinToInsertLabel.AutoSize = true;
            this.coinToInsertLabel.Location = new System.Drawing.Point(13, 13);
            this.coinToInsertLabel.Name = "coinToInsertLabel";
            this.coinToInsertLabel.Size = new System.Drawing.Size(59, 13);
            this.coinToInsertLabel.TabIndex = 0;
            this.coinToInsertLabel.Text = "Insert coin:";
            // 
            // button1PLN
            // 
            this.button1PLN.Location = new System.Drawing.Point(91, 8);
            this.button1PLN.Name = "button1PLN";
            this.button1PLN.Size = new System.Drawing.Size(56, 23);
            this.button1PLN.TabIndex = 1;
            this.button1PLN.Text = "1 PLN";
            this.button1PLN.UseVisualStyleBackColor = true;
            this.button1PLN.Click += new System.EventHandler(this.button1PLN_Click);
            // 
            // button2PLN
            // 
            this.button2PLN.Location = new System.Drawing.Point(177, 8);
            this.button2PLN.Name = "button2PLN";
            this.button2PLN.Size = new System.Drawing.Size(56, 23);
            this.button2PLN.TabIndex = 3;
            this.button2PLN.Text = "2 PLN";
            this.button2PLN.UseVisualStyleBackColor = true;
            this.button2PLN.Click += new System.EventHandler(this.button2PLN_Click);
            // 
            // button5PLN
            // 
            this.button5PLN.Location = new System.Drawing.Point(259, 8);
            this.button5PLN.Name = "button5PLN";
            this.button5PLN.Size = new System.Drawing.Size(56, 23);
            this.button5PLN.TabIndex = 4;
            this.button5PLN.Text = "5 PLN";
            this.button5PLN.UseVisualStyleBackColor = true;
            this.button5PLN.Click += new System.EventHandler(this.button5PLN_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(16, 173);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(299, 96);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 157);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(90, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Parkometer state:";
            // 
            // readTapeButton
            // 
            this.readTapeButton.Location = new System.Drawing.Point(78, 42);
            this.readTapeButton.Name = "readTapeButton";
            this.readTapeButton.Size = new System.Drawing.Size(192, 23);
            this.readTapeButton.TabIndex = 7;
            this.readTapeButton.Text = "Read tape";
            this.readTapeButton.UseVisualStyleBackColor = true;
            this.readTapeButton.Click += new System.EventHandler(this.readTapeButton_Click);
            // 
            // onTapeLabel
            // 
            this.onTapeLabel.AutoSize = true;
            this.onTapeLabel.Location = new System.Drawing.Point(13, 80);
            this.onTapeLabel.Name = "onTapeLabel";
            this.onTapeLabel.Size = new System.Drawing.Size(48, 13);
            this.onTapeLabel.TabIndex = 8;
            this.onTapeLabel.Text = "On tape:";
            // 
            // tapeContentLabel
            // 
            this.tapeContentLabel.AutoSize = true;
            this.tapeContentLabel.Location = new System.Drawing.Point(13, 103);
            this.tapeContentLabel.Name = "tapeContentLabel";
            this.tapeContentLabel.Size = new System.Drawing.Size(0, 13);
            this.tapeContentLabel.TabIndex = 9;
            // 
            // currentTapeIndexLabel
            // 
            this.currentTapeIndexLabel.AutoSize = true;
            this.currentTapeIndexLabel.Location = new System.Drawing.Point(13, 131);
            this.currentTapeIndexLabel.Name = "currentTapeIndexLabel";
            this.currentTapeIndexLabel.Size = new System.Drawing.Size(96, 13);
            this.currentTapeIndexLabel.TabIndex = 10;
            this.currentTapeIndexLabel.Text = "Current tape index:";
            // 
            // currentTapeIndex
            // 
            this.currentTapeIndex.AutoSize = true;
            this.currentTapeIndex.Location = new System.Drawing.Point(126, 131);
            this.currentTapeIndex.Name = "currentTapeIndex";
            this.currentTapeIndex.Size = new System.Drawing.Size(10, 13);
            this.currentTapeIndex.TabIndex = 11;
            this.currentTapeIndex.Text = " ";
            // 
            // initializeButton
            // 
            this.initializeButton.Location = new System.Drawing.Point(16, 42);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(56, 23);
            this.initializeButton.TabIndex = 12;
            this.initializeButton.Text = "Initialize";
            this.initializeButton.UseVisualStyleBackColor = true;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(276, 42);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(39, 23);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // clearButon
            // 
            this.clearButon.Location = new System.Drawing.Point(12, 96);
            this.clearButon.Name = "clearButon";
            this.clearButon.Size = new System.Drawing.Size(49, 23);
            this.clearButon.TabIndex = 14;
            this.clearButon.Text = "Clear";
            this.clearButon.UseVisualStyleBackColor = true;
            this.clearButon.Click += new System.EventHandler(this.clearButon_Click);
            // 
            // onTapeValue
            // 
            this.onTapeValue.AutoSize = true;
            this.onTapeValue.Location = new System.Drawing.Point(67, 80);
            this.onTapeValue.Name = "onTapeValue";
            this.onTapeValue.Size = new System.Drawing.Size(10, 13);
            this.onTapeValue.TabIndex = 15;
            this.onTapeValue.Text = " ";
            // 
            // ParkometerDFATuringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 281);
            this.Controls.Add(this.onTapeValue);
            this.Controls.Add(this.clearButon);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.initializeButton);
            this.Controls.Add(this.currentTapeIndex);
            this.Controls.Add(this.currentTapeIndexLabel);
            this.Controls.Add(this.tapeContentLabel);
            this.Controls.Add(this.onTapeLabel);
            this.Controls.Add(this.readTapeButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.button5PLN);
            this.Controls.Add(this.button2PLN);
            this.Controls.Add(this.button1PLN);
            this.Controls.Add(this.coinToInsertLabel);
            this.Name = "ParkometerDFATuringForm";
            this.Text = "ParkometerDFATuring Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coinToInsertLabel;
        private System.Windows.Forms.Button button1PLN;
        private System.Windows.Forms.Button button2PLN;
        private System.Windows.Forms.Button button5PLN;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button readTapeButton;
        private System.Windows.Forms.Label onTapeLabel;
        private System.Windows.Forms.Label tapeContentLabel;
        private System.Windows.Forms.Label currentTapeIndexLabel;
        private System.Windows.Forms.Label currentTapeIndex;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button clearButon;
        private System.Windows.Forms.Label onTapeValue;
    }
}

