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
    public partial class AddExpert : Form
    {
        private List<List<string>> Experts = new List<List<string>>();
        private ComboBox ExpertComboBox;
        public AddExpert(ref ComboBox ExpertComboBox, ref List<List<string>> Experts)
        {
            this.Experts = Experts;
            this.ExpertComboBox = ExpertComboBox;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ExpertComboBox.Items.Add(ExpertNametextBox.Text);

            List<string> Expert = new List<string>();

            Expert.Add(ExpertNametextBox.Text);
            Expert.Add(ExpertLoginTextBox.Text);
            Expert.Add(ExpertAgeTextBox.Text);
            Expert.Add(ExpertSexTextBox.Text);

            Experts.Add(Expert);
            this.Close();
        }
    }
}
