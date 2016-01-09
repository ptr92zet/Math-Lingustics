using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkometerDFA
{
    public partial class ParkometerDFAForm : Form
    {
        DFA parkometerDFA = new DFA(State.Empty);
        public ParkometerDFAForm()
        {
            InitializeComponent();

        }

        public void MoveToNextStateAndUpdate(int word)
        {
            State currState = parkometerDFA.MoveToNextState(word);
            if (currState == State.Full)
            {
                resultBox.Text =  parkometerDFA.ListAllTransitions();
            }
            else
            {
                resultBox.Text = parkometerDFA.GetCurrentState().ToString();
            }
        }

        private void button1PLN_Click(object sender, EventArgs e)
        {
            MoveToNextStateAndUpdate(1);

        }

        private void button2PLN_Click(object sender, EventArgs e)
        {
            MoveToNextStateAndUpdate(2);
        }

        private void button5PLN_Click(object sender, EventArgs e)
        {
            MoveToNextStateAndUpdate(5);
        }
    }
}
