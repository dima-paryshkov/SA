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

        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private List<List<string>> Problems = new List<List<string>>();
        private List<List<List<List<string>>>> Matrix = new List<List<List<List<string>>>>();
        private Menu back;
        private login close;

        public ExpertInterface(Menu back, List<List<string>> solutions, List<List<string>> experts, List<List<string>> Problems, login close, ref List<List<List<List<string>>>> Matrix)
        {
            this.back = back;
            this.solutions = solutions;
            this.experts = experts;
            this.Problems = Problems;
            this.close = close;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            close.Close();
            this.Close();
            back.Show();
        }

        private void ExpertInterface_Load(object sender, EventArgs e)
        {
            

            for (int i = 0; i < experts.Count; i++)
            {
                if (experts[i][4].Contains(Problems[i][0]) && Problems[i][1] == "Готово")
                {
                   

                }
            }


        }
    }
}
