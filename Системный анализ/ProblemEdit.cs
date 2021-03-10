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
    public partial class ProblemEdit : Form
    {
        private List<List<string>> ProblemsFormulation = new List<List<string>>();
        private string selectedState;
        private Label tmp;
        public ProblemEdit(ref List<List<string>> ProblemsFormulation, string selectedState, ref Label tmp)
        {
            this.tmp = tmp;
            this.ProblemsFormulation = ProblemsFormulation;
            this.selectedState = selectedState;
            InitializeComponent();

            for (int i = 0; i < ProblemsFormulation.Count; i++)
                if (ProblemsFormulation[i][0].ToString() == selectedState)
                    ProblemTextBox.Text = ProblemsFormulation[i][1].ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveProblemButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ProblemsFormulation.Count; i++)
                if (ProblemsFormulation[i][0].ToString() == selectedState)
                    ProblemsFormulation[i][1] = ProblemTextBox.Text;

            tmp.Text = ProblemTextBox.Text;
            this.Close();           
        }
    }
}
