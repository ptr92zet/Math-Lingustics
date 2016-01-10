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

namespace RegexpTesterProgram
{
    public partial class Form1 : Form
    {
        private RegexpTester regexpTester;
        public Form1()
        {
            InitializeComponent();
            regexpTester = new RegexpTester();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string fileContent;
            string message = "Strings to test:\n";
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(fileDialog.FileName);
                fileContent = reader.ReadToEnd();
                reader.Close();
                regexpTester.SetStringsToTest(fileContent);
                loadedStringsComboBox.Items.AddRange(regexpTester.GetStringsToTest());
                MessageBox.Show(message + regexpTester.GetStringsToTest(), "Loaded strings");
            }

        }

        private void typeStringCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (typeStringCheckBox.Checked)
            {
                typedStringField.Enabled = true;
                loadedStringsComboBox.Enabled = false;
            }
            else
            {
                typedStringField.Enabled = false;
                loadedStringsComboBox.Enabled = true;
            }
        }

        private void typeRegexpCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (typeRegexpCheckBox.Checked)
            {
                typedRegexpField.Enabled = true;
                standardRegexpComboBox.Enabled = false;
            }
            else
            {
                typedRegexpField.Enabled = false;
                standardRegexpComboBox.Enabled = true;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            string currRegexp;
            string currString;
            if (typeRegexpCheckBox.Checked)
            {
                currRegexp = typedRegexpField.Text;
            }
            else
            {
                currRegexp = standardRegexpComboBox.SelectedItem.ToString();
            }
            if (typeStringCheckBox.Checked)
            {
                currString = typedStringField.Text;
            }
            else
            {
                currString = loadedStringsComboBox.SelectedItem.ToString();
            }

            regexpTester.CurrentRegexp = currRegexp;
            if (regexpTester.Test(currString))
            {
                resultLabel.Text = "MATCH!";
            }
            else
            {
                resultLabel.Text = "NO MATCH!";
            }
        }

    }
}
