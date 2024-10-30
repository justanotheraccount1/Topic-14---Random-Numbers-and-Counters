using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_14___Random_Numbers_and_Counters
{
    public partial class FormRandomCounter : Form
    {   
        Random generator = new Random();
        int counter, randNum, numSmallest, numLargest;
        public FormRandomCounter()
        {
            InitializeComponent();
        }

        private void FormRandomCounter_Load(object sender, EventArgs e)
        {
            counter = 0;
            numSmallest = 1000;
            numLargest = 0;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            randNum = generator.Next(1001);
            counter++;
            lblRandomCounter.Text = counter + " Random Numbers made";
            lblRandomNumber.Text = randNum.ToString();
            if (randNum <= numSmallest)
            {
                numSmallest = randNum;
                lblSmallestNum.Text = "Samllest Number: " + numSmallest;
            }
            if (randNum >= numLargest)
            {
                numLargest = randNum;
                lblLargestNum.Text = "Largest Number: " + numLargest;
            }
        }
    }
}
