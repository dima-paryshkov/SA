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
        public ProblemEdit(AnalystInterface back, ref DataGridView Data, DataGridViewCellEventArgs e, ref List<List<string>> solutions)
        {
            this.Data = Data;
            this.e = e;
            this.back = back;
            this.solutions = solutions;
            InitializeComponent();
            DataSolutions.CellValueChanged += Data_CellValueChanged;
            DataSolutions.CellMouseClick += DataSolutions_CellMouseClick;

        }

        private void ProblemEdit_Load(object sender, EventArgs e)
        {
            if (Data.Rows[this.e.RowIndex].Cells[4].Value != null)
                ProblemTextBox.Text = Data.Rows[this.e.RowIndex].Cells[4].Value.ToString();
            else
                ProblemTextBox.Text = "";

            DataSolutions.Columns.Add("num", "№");
            DataSolutions.Columns.Add("name", "Альтернатива");
            DataSolutions.Columns.Add("del", "");
            DataSolutions.Columns[0].ReadOnly = true;
            DataSolutions.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataSolutions.Columns[1].Width = 500;
            DataSolutions.Columns[2].Width = 22;

            for (int i = 0; i < solutions[this.e.RowIndex].Count; i++)
            {
                DataSolutions.Rows.Add();
                DataSolutions.Rows[i].Cells[1].Value = solutions[this.e.RowIndex][i];
                DataSolutions.Rows[i].Cells[0].Value = i + 1;
                DataSolutions.Rows[i].Cells[2].Style.BackColor = Color.Red;
                DataSolutions.Columns[2].ReadOnly = true;
                DataSolutions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                DataSolutions.Columns[2].Width = 22;
                DataSolutions.Rows[i].Cells[2].Value = " X";
                DataSolutions.Columns[1].Width = 500;
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Data.Rows[this.e.RowIndex].Cells[4].Value = ProblemTextBox.Text;
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
 
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
                if (DataSolutions.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    DataSolutions.Rows.Remove(DataSolutions.Rows[e.RowIndex]);
                    for (int i = 0; i < DataSolutions.Rows.Count - 1; i++)
                        DataSolutions.Rows[i].Cells[0].Value = (i + 1);

                }

        }

        private void Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataSolutions.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            DataSolutions.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Red;
            DataSolutions.Columns[2].ReadOnly = true;
            DataSolutions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataSolutions.Rows[e.RowIndex].Cells[2].Value = " X";
        }

    }
}
