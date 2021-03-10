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
    public partial class ExpertEdit : Form
    {
        private List<List<string>> Experts = new List<List<string>>();
        private ComboBox ExpertComboBox;
        private string selectedState;
        private Label tmp, temp;
        public ExpertEdit(ref ComboBox ExpertComboBox, ref List<List<string>> Experts, string selectedState, ref Label tmp)
        {
            this.selectedState = selectedState;
            this.Experts = Experts;
            this.ExpertComboBox = ExpertComboBox;
            InitializeComponent();
        }

        private void ExpertEdit_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Experts.Count; i++)
                if (Experts[i][0] == selectedState)
                {
                    ExpertAgeTextBox.Text = Experts[i][2];
                    ExpertSexTextBox.Text = Experts[i][3];
                    ExpertNameTextBox.Text = Experts[i][0];
                    break;
                }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < Experts.Count; i++)
                if (Experts[i][0] == selectedState)
                {
                    Experts[i][2] = ExpertAgeTextBox.Text;
                    Experts[i][3] = ExpertSexTextBox.Text;
                    Experts[i][0] = ExpertNameTextBox.Text;
                    ExpertComboBox.Items[i] = Experts[i][0]; 
                    break;
                }


            for (int i = 0; i < Experts.Count; i++)
                if (Experts[i][0] == selectedState)
                {
                    temp.Text = "Имя: " + Experts[i][0].ToString() + "\t\t" + "Логин: " + Experts[i][1].ToString() + "\n\n" + "Возраст: " + Experts[i][2].ToString() + "\t\t" + "Пол: " + Experts[i][3].ToString();
                    break;
                }

            this.Close();
        }
    }
}
