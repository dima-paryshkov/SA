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
    public partial class AnalystInterface : Form
    {
        private Menu back;
        private ToolStripMenuItem Ready = new ToolStripMenuItem("Готово");
        private ToolStripMenuItem NotReady = new ToolStripMenuItem("Не готово");
        private ContextMenuStrip tmp = new ContextMenuStrip();
        private DataGridViewCellMouseEventArgs temp;
        private List<List<string>> solutions = new List<List<string>>();
        private List<List<string>> experts = new List<List<string>>();
        private int k = 0;
        public AnalystInterface(Menu back, ref List<List<string>> solutions, ref List<List<string>> experts)
        {
            this.back = back;
            this.experts = experts;
            this.solutions = solutions;
            InitializeComponent();

            Data.CellValueChanged += Data_CellValueChanged;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.CellMouseClick += dataGridView_CellMouseClick;
            Data.CellMouseClick += Data_CellMouseClick;
            Data.CellDoubleClick += Data_CellDoubleClick;
            Ready.Click += new EventHandler(ChangeStatusReady);
            NotReady.Click += new EventHandler(ChangeStatusТNotReady);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            back.Show();
        }

        private void AnalystInterface_Load(object sender, EventArgs e)
        {
            //список проблем
            Data.Columns.Add("num", "№");
            Data.Columns.Add("name", "Название");
            Data.Columns.Add("status", "Статус");
            Data.Columns.Add("delete", "");
            Data.Columns.Add("formulation", "");
            Data.Columns[0].ReadOnly = true;
            Data.Columns[2].ReadOnly = true;
            Data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Data.Columns[1].Width = 500;
            Data.Columns[3].Width = 22;
            Data.Columns[3].ReadOnly = true;
            Data.Columns[4].Visible = false;

            //список экспретов
            dataGridView.Columns.Add("name","Имя");
            dataGridView.Columns.Add("area", "Область деятельности");
            dataGridView.Columns.Add("experience", "Опыт работы");
            dataGridView.Columns.Add("grade", "Оценка компетенции");
            dataGridView.Columns.Add("problems", "Работает над проблемами");
            dataGridView.Columns.Add("del", "");

            dataGridView.Columns[5].Width = 22;
            dataGridView.Columns[5].ReadOnly = true;
            dataGridView.Columns[0].Width = 150;
            dataGridView.Columns[1].Width = 250;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;

            

        }

        private void Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            Data.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            tmp.Items.AddRange(new[] { Ready, NotReady });
            Data.Rows[e.RowIndex].Cells[2].ContextMenuStrip = tmp;
            Data.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Red;
            Data.Rows[e.RowIndex].Cells[3].Value = " X";
            //Data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            if (k++ == 0)
            {
                List<string> sol = new List<string>();
                solutions.Add(sol);
            }

            if (k == 3)
                k = 0;
        }


        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView.Rows[e.RowIndex].Cells[5].Style.BackColor = Color.Red;
            dataGridView.Rows[e.RowIndex].Cells[5].Value = " X";

        }

        private void Data_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
                if (Data.Rows[e.RowIndex].Cells[1].Value != null)
                     Data.Rows[e.RowIndex].Cells[2].ContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);

            if (e.ColumnIndex == 3 && e.RowIndex != -1)
                if (Data.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    solutions.RemoveAt(e.RowIndex);
                    Data.Rows.Remove(Data.Rows[e.RowIndex]);
                    for (int i = 0; i < Data.Rows.Count - 1; i++)
                        Data.Rows[i].Cells[0].Value = (i + 1);
                    
                }

            temp = e;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
               dataGridView.Rows.Remove(dataGridView.Rows[e.RowIndex]);
        }

        private void Data_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
                if (Data.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Form edit = new ProblemEdit(this, ref Data, e, ref solutions);
                    this.Hide();
                    edit.Show();
                }

        }
            private void ChangeStatusReady(object sender, EventArgs e)
        {
            Data.Rows[temp.RowIndex].Cells[2].Value = "Готово";
        }

        private void ChangeStatusТNotReady(object sender, EventArgs e)
        {
            Data.Rows[temp.RowIndex].Cells[2].Value = "Не готово";
        }

        private void ExpertList_Click(object sender, EventArgs e)
        {
            Data.Visible = false;
            BackButton.Visible = false;
            dataGridView.Visible = true;
            ExpertList.Visible = false;
            ExpertListBack.Visible = true;
        }

        private void ExpertListBack_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                for (int j = 0; j < 2; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Заполните пустые поля 'Именя' и 'Область деятельности'");
                        return;
                    }
                    
                }


            Data.Visible = true;
            BackButton.Visible = true;
            dataGridView.Visible = false;
            ExpertList.Visible = true;
            ExpertListBack.Visible = false;

            solutions.Clear();

            List<string> L = new List<string>();
            int k = 0;
            for (int i = 1; i < dataGridView.Rows.Count; i++)
            {
                solutions.Add(L);
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        solutions[k].Add(dataGridView.Rows[i].Cells[j].Value.ToString());
                        
                    }
                    else
                    {
                        solutions[k].Add("");

                    }
                }
                k++;
            }

        }


    }
}
