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
    public partial class Methods : Form
    {
        private List<List<List<List<List<string>>>>> Matrix;
        private List<List<string>> solutions;
        private int R;
        private int ProblemID;
        private List<double> C = new List<double>();
        private List<double> V = new List<double>();
        private int expertID;
        public Methods(List<List<List<List<List<string>>>>> Matrix, List<List<string>> solutions, int ProblemID, int expertID)
        {
            this.solutions = solutions;
            this.ProblemID = ProblemID;
            this.expertID = expertID;
            this.Matrix = Matrix;
            var name = expertID;



            R = ((solutions[ProblemID].Count * solutions[ProblemID].Count) - solutions[ProblemID].Count) / 2;
            InitializeComponent();

            for (int i = 0; i < solutions[ProblemID].Count; i++)
            {
                C.Add(0);
                for (int j = 0; j < solutions[ProblemID].Count; j++)
                {
                    if (i == j)
                        continue;

                    C[i] += Convert.ToDouble(Matrix[expertID][ProblemID][0][i][j]);
                }

                V.Add(C[i] / R);
            }

        }

        private void Methods_Load(object sender, EventArgs e)
        {
            List<string> sol = new List<string>();
            int Max = -1;

            for (int i = 0; i < solutions[ProblemID].Count; i++)
            {
                sol.Add(solutions[ProblemID][i]);
            }

            for (int i = 0; i < solutions[ProblemID].Count; i++)
            {
                Max = -1;
                for (int j = 0; j < V.Count; j++)
                {
                    if (V[j] > Max)
                        Max = j;
                }

                V.RemoveAt(Max);
               

                listBox1.Items.Add((i + 1).ToString() + "." + " " + sol[i] + "\n");

            }

            
        }
    }
}
