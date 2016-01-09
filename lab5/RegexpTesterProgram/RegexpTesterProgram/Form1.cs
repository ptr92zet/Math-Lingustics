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
                MessageBox.Show(message + regexpTester.GetStringsToTest());
            }

        }
    }
}
