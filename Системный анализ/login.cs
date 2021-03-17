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
        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private List<List<string>> Problems = new List<List<string>>();
        private List<List<List<List<string>>>> Matrix = new List<List<List<List<string>>>>();
        private Menu back;

        public login(Menu back, ref List<List<string>> experts, ref List<List<string>> solutions, ref List<List<string>> Problems, ref List<List<List<List<string>>>> Matrix)
        {
            this.back = back;
            this.experts = experts;
            this.solutions = solutions;
            this.Problems = Problems;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isAuth = false;
            bool AnyTasks = false;

            if (LoginTextBox.Text == "")
            {
                MessageBox.Show("Введит ваше имя");
                return;
            }

            for (int i = 0; i < experts.Count; i++)
            {
                if (experts[i][0] == LoginTextBox.Text)
                {
                    isAuth = true;
                    break;
                }
            }

            if (!isAuth)
            {
                MessageBox.Show("Вас нет в базе экспертов");
                return;
            }


            for (int i = 0; i < experts.Count; i++)
            {
                if (experts[i][4].Contains(Problems[i][0]) && Problems[i][1] == "Готово")
                {
                    AnyTasks = true;
                    break;
                }
            }

            if (!AnyTasks)
            {
                MessageBox.Show("Нет проблем готовых к ршению, попробуйте позже");
                return;
            }


            if (AnyTasks && isAuth)
            {
                Form ExpertInterface = new ExpertInterface(back, solutions, experts, Problems, this, ref Matrix);
                ExpertInterface.Show();
                this.Hide();
                back.Hide();

            }

        }
    }
}
