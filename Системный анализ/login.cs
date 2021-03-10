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
    public partial class login : Form
    {
        private List<List<string>> Experts = new List<List<string>>();
        private Menu back;
        private List<List<string>> ProblemsFormulation = new List<List<string>>();
        private List<string> Solutions = new List<string>();
        public login(ref List<List<string>> Experts, Menu back, ref List<List<string>> ProblemsFormulation, ref List<string> Solutions)
        {
            this.ProblemsFormulation = ProblemsFormulation;
            this.Experts = Experts;
            this.back = back;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < Experts.Count; i++)
                if (Experts[i][1].ToString() == LoginTextBox.Text)
                {
                    flag = true;
                    break;
                }

            if(flag)
            {
                Form Expert = new ExpertInterface(ref ProblemsFormulation, ref Solutions, ref Experts, back);
                back.Hide();
                this.Close();
                Expert.Show();
            }
        }
    }
}
