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
        private List<List<List<List<List<string>>>>> Matrix = new List<List<List<List<List<string>>>>>();
        private List<string> Formulations = new List<string>();
        private Menu back;
        private List<List<bool>> ready = new List<List<bool>>();
        private login close;
        private int ProblemID, ID, Page = 1, Zx = 0, Zy = 1;
        private bool end = true;

        public ExpertInterface(Menu back, List<List<string>> solutions, List<List<string>> experts, List<List<string>> Problems, login close, ref List<List<List<List<List<string>>>>> Matrix, int ProblemID, int ID, List<string> Formulations, ref List<List<bool>> ready)
        {
            this.back = back;
            this.solutions = solutions;
            this.experts = experts;
            this.Problems = Problems;
            this.close = close;
            this.ProblemID = ProblemID;
            this.ID = ID;
            this.Formulations = Formulations;
            this.ready = ready;
            this.Matrix = Matrix;
            InitializeComponent();

            textBoxFirst.Click += new EventHandler(setFirst);
            textBoxSecond.Click += new EventHandler(setSecond);
            LabelBoth.Click += new EventHandler(setBoth);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            close.Close();
            this.Close();
            back.Show();
        }

        private void ExpertInterface_Load(object sender, EventArgs e)
        {

            textBoxFirst.Text = solutions[ProblemID][Zx];
            textBoxSecond.Text = solutions[ProblemID][Zy];
            ProblemFormulation.Text = Formulations[ProblemID];
            ListLabel.Text = Page.ToString() + "/" + (((solutions[ProblemID].Count * solutions[ProblemID].Count) - solutions[ProblemID].Count)/2).ToString();
            EndButton.Visible = false;
            PreviousButton.Enabled = false;
            if (Zy == solutions[ProblemID].Count - 1)
            {
                NextButton.Enabled = false;
            }

        }

        private void setFirst(object sender, EventArgs e)
        {
             Matrix[ID][ProblemID][0][Zx][Zy] = "1";
             Matrix[ID][ProblemID][0][Zy][Zx] = "0";

            textBoxFirst.BackColor = Color.Green;
            textBoxSecond.BackColor = Color.White;

            if (Zx == solutions[ProblemID].Count - 2)
            {
                BackButton.Visible = false;
                NextButton.Enabled = false;

                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }
                 
                    }
                }
                if (end) EndButton.Visible = true;
            }

            if (!NextButton.Enabled)
            {
                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }

                    }
                }
                if (end) { EndButton.Visible = true; BackButton.Visible = false; }
            }

            end = true;

        }

        private void EndButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Problems.Count; i++)
            {
                if (experts[ID][4].Contains(Problems[i][0]))
                {
                    ready[ID][ProblemID] = true;
                    var substr = Problems[i][0];
                    experts[ID][4] = experts[ID][4].Replace(substr, "");
                    break;
                }
            }

            for (int i = 0; i < Problems.Count; i++)
            {
                if (experts[ID][4].Contains(Problems[i][0]))
                {
                    MessageBox.Show("У вас есть доступные проблемы для оценки, вы можете зайти под своим логином и продолжить оценивание.");
                    break;
                }
            }

            this.Close();
            back.Show();
        }

        private void setSecond(object sender, EventArgs e)
        {
            Matrix[ID][ProblemID][0][Zx][Zy] = "0";
            Matrix[ID][ProblemID][0][Zy][Zx] = "1";

            textBoxFirst.BackColor = Color.White;
            textBoxSecond.BackColor = Color.Green;

            if (Zx == solutions[ProblemID].Count - 2)
            {
                BackButton.Visible = false;
                NextButton.Enabled = false;

                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }

                    }
                }
                if (end) { EndButton.Visible = true; BackButton.Visible = false; }
            }

            if (!NextButton.Enabled)
            {
                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }

                    }
                }
                if (end) { EndButton.Visible = true; BackButton.Visible = false; }
            }

            end = true;
        }

        private void setBoth(object sender, EventArgs e)
        {
            Matrix[ID][ProblemID][0][Zx][Zy] = "0,5";
            Matrix[ID][ProblemID][0][Zy][Zx] = "0,5";

            textBoxFirst.BackColor = Color.Green;
            textBoxSecond.BackColor = Color.Green;

            if (Zx == solutions[ProblemID].Count - 2)
            {
                BackButton.Visible = false;
                NextButton.Enabled = false;

                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }

                    }
                }
                if (end) { EndButton.Visible = true; BackButton.Visible = false; }
            }

            if (!NextButton.Enabled)
            {
                for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                {
                    if (!end)
                        break;
                    for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (Matrix[ID][ProblemID][0][i][j] == "")
                        {
                            end = false;
                            break;
                        }

                    }
                }
                if (end) { EndButton.Visible = true; BackButton.Visible = false; }
            }
            end = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PreviousButton.Enabled = true;

            textBoxFirst.BackColor = Color.White;
            textBoxSecond.BackColor = Color.White;

            if (Zy == solutions[ProblemID].Count - 1)
            {
                Zx++;
                Zy = Zx + 1;

                textBoxFirst.Text = solutions[ProblemID][Zx];

                if (Zx == solutions[ProblemID].Count - 2)
                {
                    
                    NextButton.Enabled = false;

                    for (int i = 0; i < Matrix[ID][ProblemID][0].Count; i++)
                    {
                        if (!end)
                            break;
                        for (int j = 0; j < Matrix[ID][ProblemID][0].Count; j++)
                        {
                            if (i == j)
                                continue;

                            if (Matrix[ID][ProblemID][0][i][j] == "")
                            {
                                end = false;
                                break;
                            }

                        }
                    }
                    if (end) { EndButton.Visible = true; BackButton.Visible = false; }
                }
                end = true;
                textBoxSecond.Text = solutions[ProblemID][Zy];

            }
            else
            {
                Zy++;
                textBoxSecond.Text = solutions[ProblemID][Zy];

            }

            if (Matrix[ID][ProblemID][0][Zx][Zy] == "0,5")
            {
                textBoxFirst.BackColor = Color.Green;
                textBoxSecond.BackColor = Color.Green;
            }

            if (Matrix[ID][ProblemID][0][Zx][Zy] == "1")
            {
                textBoxFirst.BackColor = Color.Green;
                textBoxSecond.BackColor = Color.White;
            }

            if (Matrix[ID][ProblemID][0][Zx][Zy] == "0")
            {
                textBoxFirst.BackColor = Color.White;
                textBoxSecond.BackColor = Color.Green;
            }

            Page++;
            ListLabel.Text = Page.ToString() + "/" + (((solutions[ProblemID].Count * solutions[ProblemID].Count) - solutions[ProblemID].Count) / 2).ToString();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            textBoxFirst.BackColor = Color.White;
            textBoxSecond.BackColor = Color.White;
            NextButton.Enabled = true;
            EndButton.Visible = false;
            BackButton.Visible = true;

            if (Zy - 1 == Zx)
            {
                Zx--;
                Zy = solutions[ProblemID].Count - 1;

                textBoxFirst.Text = solutions[ProblemID][Zx];
                textBoxSecond.Text = solutions[ProblemID][Zy];
            }
            else
            {
                Zy--;
                textBoxSecond.Text = solutions[ProblemID][Zy];
            }

            if (Zy == 1)
            {
                PreviousButton.Enabled = false;
            }


            if (Matrix[ID][ProblemID][0][Zx][Zy] == "0,5")
            {
                textBoxFirst.BackColor = Color.Green;
                textBoxSecond.BackColor = Color.Green;
            }

            if (Matrix[ID][ProblemID][0][Zx][Zy] == "1")
            {
                textBoxFirst.BackColor = Color.Green;
                textBoxSecond.BackColor = Color.White;
            }

            if (Matrix[ID][ProblemID][0][Zx][Zy] == "0")
            {
                textBoxFirst.BackColor = Color.White;
                textBoxSecond.BackColor = Color.Green;
            }

            Page--;
            ListLabel.Text = Page.ToString() + "/" + (((solutions[ProblemID].Count * solutions[ProblemID].Count) - solutions[ProblemID].Count) / 2).ToString();
        }


    }
}
