using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersNFA
{
    public partial class Form1 : Form
    {
        private NFA nfa;
        private bool finalFound;
        private string currState = "";
        private string token;
        char[] chars;
        public Form1()
        {
            InitializeComponent();
            nfa = new NFA();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            string path;
            string message = "Tokens to analyze:\n";
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                StreamReader sr = new StreamReader(path);
                nfa.SetFileText(sr.ReadToEnd());
                sr.Close();
                fileNamePath.Text = path;
                string[] tokensArray = nfa.GetFileText().Split('#');
                nfa.SetTokensArray(tokensArray);
                foreach (string token in tokensArray)
                {
                    message += token + '\n';
                }
                tokensComboBox.Items.AddRange(tokensArray);
                MessageBox.Show(message);
            }
        }

        private void tokensComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nfa.Reset();
            finalFound = false;
            nfa.SetCurrentToken(tokensComboBox.SelectedItem.ToString());
            token = nfa.GetCurrentToken();
            chars = token.ToCharArray();
            tokenLengthValueLabel.Text = token.Length.ToString();
            resultTextBox.AppendText("Currently analyzed token: " + token + "\n");
            resultTextBox.SelectionStart = resultTextBox.Text.Length;
            resultTextBox.ScrollToCaret();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            int counter = nfa.GetCurrentTokenCounter();

            if (counter < nfa.GetCurrentToken().Length)
            {
                currentIndexValueLabel.Text = counter.ToString();
                Console.WriteLine("Current token counter: " + counter.ToString());
                currState = nfa.TakeStep(counter);
                Console.WriteLine("Curr state: " + currState);
                resultTextBox.AppendText(nfa.PrintAllStates() + "\n");
                resultTextBox.SelectionStart = resultTextBox.Text.Length;
                resultTextBox.ScrollToCaret();
                counter++;
                nfa.SetCurrentTokenCounter(counter);
                Console.WriteLine("Current counter after counter++ " + nfa.GetCurrentTokenCounter());
                if (currState == State.Final.ToString())
                {
                    Console.WriteLine("\nFOUND FINAL STATE for token: " + nfa.GetCurrentToken() + "\n\n");
                    nfa.PrintAllStates();
                    nfa.Reset();
                    resultTextBox.AppendText("\n\n");
                    resultTextBox.SelectionStart = resultTextBox.Text.Length;
                    resultTextBox.ScrollToCaret();
                    finalFound = true;
                }
            }
            else
            {
                if (!finalFound)
                {
                    Console.Write("\nDID NOT FIND Final state for token: " + nfa.GetCurrentToken() + "\n\n");
                }
                else
                {
                    Console.Write("Take another token to analyze.\n");
                    currentIndexValueLabel.Text = "0";
                    tokenLengthValueLabel.Text = "0";
                }
            }
        }
    }
}
