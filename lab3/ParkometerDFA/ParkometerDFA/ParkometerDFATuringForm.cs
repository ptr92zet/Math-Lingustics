using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFATuring
{
    public partial class ParkometerDFATuringForm : Form
    {
        DFATuring parkometerDFATuring = new DFATuring();
        private List<int> coins = new List<int>();
        public ParkometerDFATuringForm()
        {
            InitializeComponent();
            resultBox.Text = parkometerDFATuring.CurrentState.ToString() + "\n";

        }

        private void AddCoinValueToTape(int coin)
        {
            parkometerDFATuring.AddToTape(coin);
            tapeContentLabel.Text = String.Join(" ", parkometerDFATuring.GetTapeElements());
        }

        private void button1PLN_Click(object sender, EventArgs e)
        {
            AddCoinValueToTape(1);

        }

        private void button2PLN_Click(object sender, EventArgs e)
        {
            AddCoinValueToTape(2);
        }

        private void button5PLN_Click(object sender, EventArgs e)
        {
            AddCoinValueToTape(5);
        }

        private void readTapeButton_Click(object sender, EventArgs e)
        {
            button1PLN.Enabled = false;
            button2PLN.Enabled = false;
            button5PLN.Enabled = false;
            currentTapeIndex.Text = (parkometerDFATuring.CurrentTapeIndex).ToString();
            if (!parkometerDFATuring.MoveToNextState())
            {
                resultBox.Text += parkometerDFATuring.CurrentState.ToString() + "\n";
            }
            else
            {
                resultBox.Text = parkometerDFATuring.RetrieveAllTransitions() + "\n";
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            parkometerDFATuring.Reset();
            resultBox.Text = "";
            tapeContentLabel.Text = "";
            currentTapeIndex.Text = "";
            button1PLN.Enabled = true;
            button2PLN.Enabled = true;
            button5PLN.Enabled = true;
            resultBox.Text = parkometerDFATuring.CurrentState.ToString() + "\n";
        }
    }
}
