using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOQA
{
    public partial class userInput : Form
    {
        

        public userInput()
        {
            InitializeComponent();
        }

        public string resultText;

        
        private void okButton_Click(object sender, EventArgs e)
        {
            resultText = textResult.Text;
            this.Close();
        }
    }
}
