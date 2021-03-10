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
    public partial class AnalystInterface : Form
    {
        private List<List<string>> ProblemsFormulation = new List<List<string>>();
        private List<string> Solutions = new List<string>();
        private List<List<string>> Experts = new List<List<string>>();
        private Menu back;
        public AnalystInterface(ref List<List<string>> ProblemsFormulation, ref List<string> Solutions, ref List<List<string>> Experts, Menu back)
        {
            this.ProblemsFormulation = ProblemsFormulation;
            this.Solutions = Solutions;
            this.Experts = Experts;
            this.back = back;
            InitializeComponent();

            ProblemsComboBox.SelectedIndexChanged += ProblemsComboBox_SelectedIndexChanged;
            SolutionsComboBox.SelectedIndexChanged += SolutionsComboBox_SelectedIndexChanged;
            ExpertComboBox.SelectedIndexChanged += ExpertComboBox_SelectedIndexChanged;
        }

        void ProblemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ProblemsComboBox.SelectedItem.ToString();

            for (int i = 0; i < ProblemsFormulation.Count; i++)
                if (ProblemsFormulation[i][0].ToString() == selectedState)
                {
                    CurrentProblemFormulation.Text = ProblemsFormulation[i][1].ToString();
                    break;
                }
        }

        void SolutionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = SolutionsComboBox.SelectedItem.ToString();

            for (int i = 0; i < Solutions.Count; i++)
                if (Solutions[i] == selectedState)
                {
                    SolutionFormulationLabel.Text = Solutions[i].ToString();
                    break;
                }
                    
        }

        void ExpertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ExpertComboBox.SelectedItem.ToString();

            for (int i = 0; i < Experts.Count; i++)
                if (Experts[i][0] == selectedState)
                {
                    ExpertDiscriptionLabel.Text = "Имя: " + Experts[i][0].ToString() + "\t\t" + "Логин: " + Experts[i][1].ToString() + "\n\n" + "Возраст: " + Experts[i][2].ToString() + "\t\t" + "Пол: " + Experts[i][3].ToString();
                    break;
                }

        }

        private void AddProblemButton_Click_1(object sender, EventArgs e)
        {
            Form AddProblem = new AddProblem(ref ProblemsComboBox, ref ProblemsFormulation);
            AddProblem.ShowDialog();
        }

        private void ProblemChangeButton_Click_1(object sender, EventArgs e)
        {

            string selectedState = ProblemsComboBox.SelectedItem.ToString();
            Form problem = new ProblemEdit(ref ProblemsFormulation, selectedState, ref CurrentProblemFormulation);
            problem.ShowDialog();

        }

        private void DelProblemButton_Click(object sender, EventArgs e)
        {
            string selectedState = ProblemsComboBox.SelectedItem.ToString();
            for (int i = 0; i < ProblemsFormulation.Count; i++)
                if (ProblemsFormulation[i][0].ToString() == selectedState)
                {
                    ProblemsFormulation.RemoveAt(i);
                    ProblemsComboBox.Items.RemoveAt(i);
                    break;
                }

            CurrentProblemFormulation.Text = "";
        }

        private void AddSolutionButton_Click(object sender, EventArgs e)
        {
            Form AddSolution = new AddSolution(ref SolutionsComboBox, ref Solutions);
            AddSolution.ShowDialog();
        }

        private void EditSolutionButton_Click(object sender, EventArgs e)
        {
            string selectedState = SolutionsComboBox.SelectedItem.ToString();
            Form problem = new SolutionEdit(ref Solutions, selectedState, ref SolutionFormulationLabel, ref SolutionsComboBox);
            problem.ShowDialog();
        }

        private void DelSolutionButton_Click(object sender, EventArgs e)
        {
            string selectedState = SolutionsComboBox.SelectedItem.ToString();
            for (int i = 0; i < Solutions.Count; i++)
            {
                if (Solutions[i].ToString() == selectedState)
                {
                    Solutions.RemoveAt(i);
                    SolutionsComboBox.Items.RemoveAt(i);
                    break;
                }
            }

            SolutionFormulationLabel.Text = "";
        }

        private void ExpertAddButton_Click(object sender, EventArgs e)
        {
            Form AddProblem = new AddExpert(ref ExpertComboBox, ref Experts);
            AddProblem.ShowDialog();
        }

        private void ExpertEditButton_Click(object sender, EventArgs e)
        {
            string selectedState = ExpertComboBox.SelectedItem.ToString();
            Form problem = new ExpertEdit(ref ExpertComboBox, ref Experts, selectedState, ref ExpertDiscriptionLabel);
            problem.ShowDialog();
        }

        private void ExpertDelButton_Click(object sender, EventArgs e)
        {
            string selectedState = ExpertComboBox.SelectedItem.ToString();
            for (int i = 0; i < Experts.Count; i++)
            {
                if (Experts[i][0].ToString() == selectedState)
                {
                    Experts.RemoveAt(i);
                    ExpertComboBox.Items.RemoveAt(i);
                    break;
                }
            }

            ExpertDiscriptionLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }
    }
}
