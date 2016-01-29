using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFATuring
{
    public partial class ParkometerDFATuringForm : Form
    {
        DFATuring parkometerDFATuring;
        private List<string> tape;
        private int stepCouter;
        private Stopwatch timer;

        public ParkometerDFATuringForm()
        {
            InitializeComponent();
            parkometerDFATuring = new DFATuring(256);
            tape = new List<string>();
            timer = new Stopwatch();
            stepCouter = 0;
            timer.Stop();

        }

        private void button1PLN_Click(object sender, EventArgs e)
        {
            tape.Add("1");
            onTapeValue.Text += "1";
        }

        private void button2PLN_Click(object sender, EventArgs e)
        {
            tape.Add("2");
            onTapeValue.Text += "2";
        }

        private void button5PLN_Click(object sender, EventArgs e)
        {
            tape.Add("5");
            onTapeValue.Text += "5";
        }

        private void readTapeButton_Click(object sender, EventArgs e)
        {
            if (parkometerDFATuring.IsTapeInitialized)
            {
                button1PLN.Enabled = false;
                button2PLN.Enabled = false;
                button5PLN.Enabled = false;
                if (parkometerDFATuring.CurrentState != State.Q7F)
                {
                    currentTapeIndex.Text = (parkometerDFATuring.HeadPosition).ToString();
                    parkometerDFATuring.TakeStep();
                    stepCouter++;
                    Console.WriteLine("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter);
                    resultBox.AppendText("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter + "\n");
                    resultBox.SelectionStart = resultBox.TextLength;
                    resultBox.ScrollToCaret();
                }
                else
                {
                    Console.WriteLine("FINAL STATE REACHED !!!");
                    resultBox.AppendText("FINAL STATE REACHED !!!");
                    resultBox.SelectionStart = resultBox.TextLength;
                    resultBox.ScrollToCaret();
                    parkometerDFATuring.IsTapeInitialized = false;
                }
            }
            else
            {
                MessageBox.Show("You need to initialize tape at first");
            }
            
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            parkometerDFATuring.Reset();
            parkometerDFATuring.InitializeTape(tape);
            stepCouter = 0;
            resultBox.Text = "";
            tapeContentLabel.Text = "";
            currentTapeIndex.Text = "";
            button1PLN.Enabled = true;
            button2PLN.Enabled = true;
            button5PLN.Enabled = true;

            currentTapeIndex.Text = (parkometerDFATuring.HeadPosition).ToString();
            Console.WriteLine("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter);
            resultBox.AppendText("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter + "\n");
            resultBox.SelectionStart = resultBox.TextLength;
            resultBox.ScrollToCaret();
        }

        private void clearButon_Click(object sender, EventArgs e)
        {
            tape.Clear();
            parkometerDFATuring.IsTapeInitialized = false;
            onTapeValue.Text = "";
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (parkometerDFATuring.IsTapeInitialized)
            {
                button1PLN.Enabled = false;
                button2PLN.Enabled = false;
                button5PLN.Enabled = false;
                timer.Restart();
                while (parkometerDFATuring.CurrentState != State.Q7F)
                {
                    currentTapeIndex.Text = (parkometerDFATuring.HeadPosition).ToString();
                    parkometerDFATuring.TakeStep();
                    stepCouter++;
                    Console.WriteLine("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter);
                    resultBox.AppendText("Current state: " + parkometerDFATuring.CurrentState + ", coin: " + parkometerDFATuring.CurrentCoin + ", position: " + parkometerDFATuring.HeadPosition + ", step: " + stepCouter + "\n");
                    resultBox.SelectionStart = resultBox.TextLength;
                    resultBox.ScrollToCaret();
                }
                timer.Stop();
                Console.WriteLine("FINAL STATE REACHED! Elapsed time: " + (timer.ElapsedMilliseconds / 1000.0).ToString("F4", CultureInfo.InvariantCulture) + " seconds.");
                resultBox.AppendText("FINAL STATE REACHED! Elapsed time: " + (timer.ElapsedMilliseconds / 1000.0).ToString("F4", CultureInfo.InvariantCulture) + " seconds.");
                resultBox.SelectionStart = resultBox.TextLength;
                resultBox.ScrollToCaret();
                parkometerDFATuring.IsTapeInitialized = false;
            }
            else
            {
                MessageBox.Show("You need to initialize tape at first");
            }

        }
    }
}
