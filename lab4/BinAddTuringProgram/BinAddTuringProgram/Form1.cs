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
        private char[] positionArray;
        private string tape;
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            turing = new BinAddTuring("#", "#");
        }

        private void showHeadPosition()
        {
            positionArray = tapeStateLabel.Text.ToCharArray();
            positionArray[index] = '^';
            tapePositionLabel.Text = positionArray[index].ToString();
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
            string tapeSymbol;
            index = turing.TapeIndex;
            if (turing.InitialTapeContent != null)
            {
                tapeSymbol = turing.InitialTapeContent[index].ToString();
                turing.CurrentSymbol = tapeSymbol;
            }

        }

        private void initializeTapeButton_Click(object sender, EventArgs e)
        {
            if (loadTapeCheckBox.Checked)
            {
                turing.InitialTapeContent = onTapeValue.Text;
            }
            else
            {
                turing.InitialTapeContent = typeYourTapeField.Text;
            }
            tapeStateLabel.Text = turing.InitialTapeContent;
            showHeadPosition();
        }
    }
}
