using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Системный_анализ
{
    public partial class ExpertInterface : Form
    {

        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private List<List<string>> Problems = new List<List<string>>();
        private List<List<List<List<string>>>> Matrix = new List<List<List<List<string>>>>();
        private Menu back;
        private login close;
        private int ProblemID;

        public ExpertInterface(Menu back, List<List<string>> solutions, List<List<string>> experts, List<List<string>> Problems, login close, ref List<List<List<List<string>>>> Matrix, int ProblemID)
        {
            this.back = back;
            this.solutions = solutions;
            this.experts = experts;
            this.Problems = Problems;
            this.close = close;
            this.ProblemID = ProblemID;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            close.Close();
            this.Close();
            back.Show();
        }

        private void ExpertInterface_Load(object sender, EventArgs e)
        {

            textBoxFirst.Text = solutions[ProblemID][0];
            textBoxSecond.Text = solutions[ProblemID][1];



        }

        private void checkBoxSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBoth.Checked)
            {
                checkBoxBoth.Checked = false;
                checkBoxFirst.Checked = false;
            }

        }

        private void checkBoxBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFirst.Checked || checkBoxSecond.Checked)
            {
                checkBoxSecond.Checked = false;
                checkBoxFirst.Checked = false;
            }
        }
    }
}
