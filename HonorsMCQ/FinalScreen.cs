using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonorsMCQ
{
    public partial class FinalScreen : Form
    {

        public int correct_answers;

        public bool[] answers = new bool[10];

        string result = "incorrect";

        public FinalScreen()
        {
            InitializeComponent();
        }
        private string answer_check(bool answers)
        {
            if (answers)
            {
                result = "correct";

            }

            return result;
        }

        public bool[] answer_array { get; set; }

        private void FinalScreen_Load(object sender, EventArgs e)
        {
            labQuest1.Text = answer_check(answers[0]);
            labQuest2.Text = answer_check(answers[1]);
            labQuest3.Text = answer_check(answers[2]);
            labQuest4.Text = answer_check(answers[3]);
            labQuest5.Text = answer_check(answers[4]);
            labQuest6.Text = answer_check(answers[5]);
            labQuest7.Text = answer_check(answers[6]);
            labQuest8.Text = answer_check(answers[7]);
            labQuest9.Text = answer_check(answers[8]);
            labQuest10.Text = answer_check(answers[9]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
