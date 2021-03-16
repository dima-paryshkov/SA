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
    public partial class Menu : Form
    {

        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private List<List<string>> Problems = new List<List<string>>();
        private List<string> Formulations = new List<string>();

        public Menu()
        {
            InitializeComponent();
        }

        private void AnalystInterfaceButton_Click(object sender, EventArgs e)
        {
            Form Analyst = new AnalystInterface(this, ref solutions, ref experts, ref Problems, ref Formulations);
            this.Hide();

            Analyst.Show();

        }

        private void ExpertInterfaceButton_Click(object sender, EventArgs e)
        {
            Form login = new login(this, ref experts, ref solutions, ref Problems);
            login.ShowDialog();
        }
    }
}
