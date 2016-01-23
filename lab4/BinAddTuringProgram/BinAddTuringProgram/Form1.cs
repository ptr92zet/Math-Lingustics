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
        private BinAddTuring incrementMachine;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            incrementMachine = new BinAddTuring("E", "#");
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
            index = incrementMachine.TapeIndex;
            if (loadTapeCheckBox.Checked)
            {
                incrementMachine.CurrentSymbol = onTapeValue.Text[index].ToString();
            }
            else
            {
                incrementMachine.CurrentSymbol = typeYourTapeField.Text[index].ToString();
            }
        }
    }
}
