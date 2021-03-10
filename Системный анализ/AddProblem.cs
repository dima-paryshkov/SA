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
    
    public partial class AddProblem : Form
    {
        private List<List<string>> ProblemsFormulation = new List<List<string>>();
        private ComboBox ProblemsComboBox;
        public AddProblem(ref ComboBox ProblemsComboBox, ref List<List<string>> ProblemsFormulation)
        {
            this.ProblemsComboBox = ProblemsComboBox;
            this.ProblemsFormulation = ProblemsFormulation;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ProblemsComboBox.Items.Add(ProblemNameTextBox.Text);

            List<string> Prob = new List<string>();
            Prob.Add(ProblemNameTextBox.Text);
            Prob.Add(ProblemFormulationTextBox.Text);

            ProblemsFormulation.Add(Prob);
            this.Close();
        }
    }
}
