using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string content;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(fileDialog.FileName);
                content = reader.ReadToEnd();
                reader.Close();
                loadedStringsComboBox.Items.AddRange(getStringsFromFileContent(content));
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
                currRegexp = recognizeStandardString();
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

        private void standardRegexpComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            typedRegexpField.Text = recognizeStandardString();
        }

        private void loadedStringsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.typedStringField.Text = loadedStringsComboBox.SelectedItem.ToString();
        }

        // OWN HELPERS
        private string[] getStringsFromFileContent(string fileContent)
        {
            string[] stringTokens = fileContent.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < stringTokens.Length; i++)
            {
                stringTokens[i] = stringTokens[i].TrimEnd(';');
            }
            return stringTokens;
        }

        private string recognizeStandardString()
        {
            int item = standardRegexpComboBox.SelectedIndex;
            string regexp = "";
            switch (item)
            {
                case 0:
                    regexp = StandardRegexp.IPv4Regexp();
                    break;
                case 1:
                    regexp = StandardRegexp.SubnetMaskRegexp();
                    break;
                case 2:
                    regexp = StandardRegexp.MACAddressRegexp();
                    break;
                case 3:
                    regexp = StandardRegexp.EmailAddressRegexp();
                    break;
                case 4:
                    regexp = StandardRegexp.IntegersAdditionRegexp();
                    break;
                case 5:
                    regexp = StandardRegexp.ComplexNumbersSubtractionRegexp();
                    break;
                case 6:
                    regexp = StandardRegexp.HTMLTextFormatMarkupsRegexp();
                    break;
                case 7:
                    regexp = StandardRegexp.HTMLTableMarkupsRegexp();
                    break;
            }
            return regexp;
        }
    }
}
