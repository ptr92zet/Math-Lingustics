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
            this.resultBox.Location = new System.Drawing.Point(16, 59);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(299, 96);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 43);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(90, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Parkometer state:";
            // 
            // ParkometerDFATuringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 167);
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
    }
}

