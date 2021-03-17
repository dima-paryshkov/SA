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
    public partial class ProblemEdit : Form
    {
        private AnalystInterface back;

        private DataGridView Data = new DataGridView();
        private DataGridViewCellEventArgs e;
        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private List<string> Formulations = new List<string>();
        private List<List<List<List<string>>>> Matrix = new List<List<List<List<string>>>>();

        public ProblemEdit(AnalystInterface back, ref DataGridView Data, DataGridViewCellEventArgs e, ref List<List<string>> solutions, ref List<List<string>> experts, ref List<string> Formulations, ref List<List<List<List<string>>>> Matrix)
        {
            this.Data = Data;
            this.e = e;
            this.back = back;
            this.experts = experts;
            this.Formulations = Formulations;
            this.solutions = solutions;
            this.Matrix = Matrix;
            InitializeComponent();
            DataSolutions.CellValueChanged += Data_CellValueChanged;
            DataSolutions.CellMouseClick += DataSolutions_CellMouseClick;
            DataExperts.CellMouseClick += DataExperts_CellMouseClick;

        }

        private void ProblemEdit_Load(object sender, EventArgs e)
        {
            if (Data.Rows[this.e.RowIndex].Cells[4].Value != null)
                ProblemTextBox.Text = Data.Rows[this.e.RowIndex].Cells[4].Value.ToString();
            else
                ProblemTextBox.Text = "";

            //список альтернатив выбранной проблемы
            {
                DataSolutions.Columns.Add("num", "№");
                DataSolutions.Columns.Add("name", "Альтернатива");
                DataSolutions.Columns.Add("show", "");
                DataSolutions.Columns.Add("del", "");
                DataSolutions.Columns[0].ReadOnly = true;
                DataSolutions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DataSolutions.Columns[1].Width = 953;
                DataSolutions.Columns[2].Width = 22;
                DataSolutions.Columns[3].Width = 22;
                DataSolutions.Columns[2].ReadOnly = true;
                DataSolutions.Columns[3].ReadOnly = true;
            }

            //список экспертов
            { 
                DataExperts.Columns.Add("name", "Имя");
                DataExperts.Columns.Add("area", "Область деятельности");
                DataExperts.Columns.Add("experience", "Опыт работы");
                DataExperts.Columns.Add("grade", "Оценка компетенции");
                DataExperts.Columns.Add("problems", "Участвует");
                DataExperts.Columns.Add("add", "");
                DataExperts.Columns.Add("del", "");
          
                DataExperts.Columns[5].Width = 22;
                DataExperts.Columns[6].Width = 22;
                DataExperts.Columns[5].ReadOnly = true;
                DataExperts.Columns[4].ReadOnly = true;
                DataExperts.Columns[3].ReadOnly = true;
                DataExperts.Columns[2].ReadOnly = true;
                DataExperts.Columns[1].ReadOnly = true;
                DataExperts.Columns[0].ReadOnly = true;
                DataExperts.Columns[6].ReadOnly = true;
                DataExperts.Columns[0].Width = 220;
                DataExperts.Columns[1].Width = 300;
                DataExperts.Columns[2].Width = 180;
                DataExperts.Columns[3].Width = 190;
            }


            for (int i = 0; i < solutions[this.e.RowIndex].Count; i++)
            {
                DataSolutions.Rows.Add();
                DataSolutions.Rows[i].Cells[1].Value = solutions[this.e.RowIndex][i];
                DataSolutions.Rows[i].Cells[0].Value = i + 1;
                DataSolutions.Rows[i].Cells[3].Style.BackColor = Color.Red;
                DataSolutions.Columns[2].ReadOnly = true;
                DataSolutions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataSolutions.Columns[2].Width = 22;
                DataSolutions.Columns[3].Width = 22;
                DataSolutions.Rows[i].Cells[2].Value = " ...";
                DataSolutions.Rows[i].Cells[3].Value = " X";
                DataSolutions.Columns[1].Width = 500;
            }

            for (int i = 0; i < experts.Count; i++)
            {
                DataExperts.Rows.Add();
                DataExperts.Rows[i].Cells[0].Value = experts[i][0];
                DataExperts.Rows[i].Cells[1].Value = experts[i][1];
                DataExperts.Rows[i].Cells[2].Value = experts[i][2];
                DataExperts.Rows[i].Cells[3].Value = experts[i][3];

                DataExperts.Rows[i].Cells[5].Value = " V";
                DataExperts.Rows[i].Cells[6].Value = " X";
                DataExperts.Rows[i].Cells[5].Style.BackColor = Color.Green;
                DataExperts.Rows[i].Cells[6].Style.BackColor = Color.Red;

                if (experts[i][4].Contains(Data.Rows[this.e.RowIndex].Cells[1].Value.ToString()))
                    DataExperts.Rows[i].Cells[4].Value = "Да";
                else
                    DataExperts.Rows[i].Cells[4].Value = "Нет";

            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Data.Rows[this.e.RowIndex].Cells[4].Value = ProblemTextBox.Text;
            Formulations[this.e.RowIndex] = ProblemTextBox.Text;
            solutions[this.e.RowIndex].Clear();

            for (int i = 0; i < DataSolutions.Rows.Count - 1; i++)
            {
                if (DataSolutions.Rows[i].Cells[1].Value == null)
                    continue;

                solutions[this.e.RowIndex].Add(DataSolutions.Rows[i].Cells[1].Value.ToString());
            }

            this.Close();
            back.Show();
        }

        private void  DataSolutions_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
 
            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                if (DataSolutions.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DataSolutions.Rows.Remove(DataSolutions.Rows[e.RowIndex]);
                    for (int i = 0; i < DataSolutions.Rows.Count - 1; i++)
                        DataSolutions.Rows[i].Cells[0].Value = (i + 1);

                }

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
                if (DataSolutions.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Form editor = new editformulation(ref solutions, ref DataSolutions, e, this.e);
                    editor.ShowDialog();
                }

        }

        private void DataExperts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex != -1)
            {

                if (DataExperts.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    if (experts[e.RowIndex][4].Contains(Data.Rows[this.e.RowIndex].Cells[1].Value.ToString()))
                        return;


                    experts[e.RowIndex][4] += Data.Rows[this.e.RowIndex].Cells[1].Value.ToString() + "  ";
                    DataExperts.Rows[e.RowIndex].Cells[4].Value = "Да";

                    Matrix[this.e.RowIndex].Add(new List<List<string>>());

                }
            }

            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                if (DataExperts.Rows[e.RowIndex].Cells[6].Value != null)
                {
                    if (!experts[e.RowIndex][4].Contains(Data.Rows[this.e.RowIndex].Cells[1].Value.ToString()))
                        return;

                    var substr = Data.Rows[this.e.RowIndex].Cells[1].Value.ToString() + "  ";
                    experts[e.RowIndex][4] = experts[e.RowIndex][4].Replace(substr, "");
                    DataExperts.Rows[e.RowIndex].Cells[4].Value = "Нет";

                    Matrix[this.e.RowIndex].RemoveAt(e.RowIndex);
                }
            }

        }

        private void Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataSolutions.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            DataSolutions.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Red;
            DataSolutions.Columns[2].ReadOnly = true;
            DataSolutions.Columns[3].ReadOnly = true;
            DataSolutions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataSolutions.Rows[e.RowIndex].Cells[3].Value = " X";
            DataSolutions.Rows[e.RowIndex].Cells[2].Value = " ...";
        }

    }
}
