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
    public partial class SolutionEdit : Form
    {
        private List<string> Solutions = new List<string>();
        private string selectedState;
        private Label tmp;
        private ComboBox SolutionsComboBox;
        public SolutionEdit(ref List<string> Solutions, string selectedState, ref Label tmp, ref ComboBox SolutionsComboBox)
        {
            this.selectedState = selectedState;
            this.Solutions = Solutions;
            this.tmp = tmp;
            this.SolutionsComboBox = SolutionsComboBox;
            InitializeComponent();

            for (int i = 0; i < Solutions.Count; i++)
                if (Solutions[i].ToString() == selectedState)
                    SolutionTextBox.Text = Solutions[i].ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Solutions.Count; i++)
                if (Solutions[i].ToString() == selectedState)
                {
                    Solutions[i] = SolutionTextBox.Text;
                    SolutionsComboBox.Items[i] = SolutionTextBox.Text; 
                }

            tmp.Text = SolutionTextBox.Text;
            this.Close();
        }
    }
}
