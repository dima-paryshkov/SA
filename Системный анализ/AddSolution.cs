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
    public partial class AddSolution : Form
    {
        private List<string> Solutions = new List<string>();
        private ComboBox SolutionsComboBox;
        public AddSolution(ref ComboBox SolutionsComboBox, ref List<string> Solutions)
        {
            this.Solutions = Solutions;
            this.SolutionsComboBox = SolutionsComboBox;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSolutionButton_Click(object sender, EventArgs e)
        {
            SolutionsComboBox.Items.Add(AddSolutionTextBox.Text);

            Solutions.Add(AddSolutionTextBox.Text);
            this.Close();
        }
    }
}
