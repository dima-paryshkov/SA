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
        private List<List<string>> Experts = new List<List<string>>();
        private Menu back;
        private List<List<string>> ProblemsFormulation = new List<List<string>>();
        private List<string> Solutions = new List<string>();
        public ExpertInterface(ref List<List<string>> ProblemsFormulation, ref List<string> Solutions, ref List<List<string>> Experts, Menu back)
        {
            this.Experts = Experts;
            this.ProblemsFormulation = ProblemsFormulation;
            this.Solutions = Solutions;
            this.back = back;
            InitializeComponent();

            ProblemsComboBox.SelectedIndexChanged += ProblemsComboBox_SelectedIndexChanged;

            for (int i = 0; i < ProblemsFormulation.Count; i++)
            {
                ProblemsComboBox.Items.Add(ProblemsFormulation[i][0]);
            }
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }
    }
}
