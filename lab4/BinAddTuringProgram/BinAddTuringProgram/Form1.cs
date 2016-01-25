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

namespace BinAddTuringProgram
{
    public partial class Form1 : Form
    {
        private BinAddTuring turing;
        private string fullTapeContent;
        private int headPos = 0;
        private int previousHeadPos = 0;
        private bool isTuringInitialized = false;


        private string[] positionArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void showHeadPosition()
        {
            Console.WriteLine("previousHeadPos: " + previousHeadPos.ToString());
            Console.WriteLine("headPos: " + headPos.ToString());
            positionArray[previousHeadPos] = "";
            positionArray[headPos] = "^";
            tapePositionLabel.Text = String.Join("", positionArray);
        }

        private void loadTapeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (loadTapeCheckBox.Checked)
            {
                loadTapeButton.Enabled = true;
                onTapeLabel.Enabled = true;
                onTapeValue.Enabled = true;
            }
            else
            {
                loadTapeButton.Enabled = false;
                onTapeLabel.Enabled = false;
                onTapeValue.Enabled = false;
            }
        }

        private void loadTapeButton_Click(object sender, EventArgs e)
        {
            string content;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(fileDialog.FileName);
                content = reader.ReadToEnd();
                reader.Close();
                onTapeValue.Text = content;
            }
        }

        private void takeStepButton_Click(object sender, EventArgs e)
        {
            if (isTuringInitialized)
            {
                previousHeadPos = turing.HeadPosition;
                if (turing.CurrentState != State.QF)
                {
                    turing.TakeStep();
                    Console.WriteLine("I am in: " + turing.CurrentState + ", symbol is: " + turing.CurrentSymbol + "position: " + turing.HeadPosition.ToString());

                }
                else
                {
                    Console.WriteLine("FINAL STATE REACHED!");
                }
                consoleBox.Text += "\n" + turing.CurrentState.ToString();
                headPos = turing.HeadPosition;
                showHeadPosition();
            }
            else
            {
                MessageBox.Show("You have to initialize Turing Machine first!");
            }
        }

        private void initializeTapeButton_Click(object sender, EventArgs e)
        {
            if (loadTapeCheckBox.Checked)
            {
                fullTapeContent = onTapeValue.Text;
            }
            else
            {
                fullTapeContent = typeYourTapeField.Text;
            }
            tapeStateLabel.Text = fullTapeContent;
            Console.WriteLine("fullTapeContent: " + fullTapeContent);
            turing = new BinAddTuring("#", fullTapeContent);
            Console.WriteLine("turing.CurrentState: " + turing.CurrentState + ", turing.CurrentSymbol: " + turing.CurrentSymbol + ", turing.HeadPosition: " + turing.HeadPosition.ToString());
            positionArray = new string[turing.MaxTapeLength];
            showHeadPosition();
            isTuringInitialized = true;
        }
    }
}
