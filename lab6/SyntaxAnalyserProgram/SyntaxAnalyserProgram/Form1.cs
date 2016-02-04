using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyntaxAnalyserProgram
{
    public partial class Form1 : Form
    {
        private SyntaxAnalyser analyser;
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            analyser = new SyntaxAnalyser(inputTextBox.Text);
            analyser.Parse();
            resultValueLabel.Text = analyser.IsCorrect.ToString();
        }
    }
}
