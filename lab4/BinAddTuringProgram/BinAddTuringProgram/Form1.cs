using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private int stepCouter = 0;
        private Stopwatch timer = new Stopwatch();

        private string[] positionArray;

        public Form1()
        {
            InitializeComponent();
            timer.Stop();
        }

        private void showHeadPosition()
        {
            Console.WriteLine("previousHeadPos: " + previousHeadPos.ToString());
            Console.WriteLine("headPos: " + headPos.ToString());
            positionArray[previousHeadPos] = " ";
            positionArray[headPos] = "^";
            tapeStateLabel.Text = turing.Tape;
            tapePositionLabel.Text = String.Join("", positionArray);

        }

        private void takeStepAndPrintInfo()
        {
            previousHeadPos = turing.HeadPosition;
            turing.TakeStep();
            stepCouter++;
            Console.WriteLine("I am in: " + turing.CurrentState + ", symbol is: " + turing.CurrentSymbol + "position: " + turing.HeadPosition.ToString());
            consoleBox.AppendText("Current state: " + turing.CurrentState.ToString() + ", symbol: " + turing.CurrentSymbol + ", position: " + turing.HeadPosition + ", step: " + stepCouter + "\n");
            consoleBox.SelectionStart = consoleBox.TextLength;
            consoleBox.ScrollToCaret();
            headPos = turing.HeadPosition;
            showHeadPosition();
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
                if (turing.CurrentState != State.QF)
                {
                    takeStepAndPrintInfo();
                }
                else
                {
                    Console.WriteLine("FINAL STATE REACHED!");
                    consoleBox.AppendText("FINAL STATE REACHED!\n");
                }
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
            tapePositionLabel.Text = "";
            positionArray = new string[turing.MaxTapeLength];
            stepCouter = 0;
            showHeadPosition();
            isTuringInitialized = true;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (isTuringInitialized)
            {
                timer.Restart();
                while (turing.CurrentState != State.QF)
                {
                    takeStepAndPrintInfo();
                }
                timer.Stop();
                Console.WriteLine("FINAL STATE REACHED! Elapsed time: " + (timer.ElapsedMilliseconds/1000.0).ToString("F4", CultureInfo.InvariantCulture) + " seconds.");
                consoleBox.AppendText("FINAL STATE REACHED! Elapsed time: " + (timer.ElapsedMilliseconds/1000.0).ToString("F4", CultureInfo.InvariantCulture) + " seconds.");
            }
            else
            {
                MessageBox.Show("You have to initialize Turing Machine first!");
            }
        }
    }
}
