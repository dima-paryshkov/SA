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
        private List<List<string>> Problems = new List<List<string>>();
        private List<string> Formulations = new List<string>();

        private bool status = false, load_status = false;
        private int count;
        private int k = 0;

        public AnalystInterface(Menu back, ref List<List<string>> solutions, ref List<List<string>> experts, ref List<List<string>> Problems, ref List<string> Formulations)
        {
            this.back = back;
            this.experts = experts;
            this.solutions = solutions;
            this.Formulations = Formulations;
            this.Problems = Problems;
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
            {
                Data.Columns.Add("num", "№");
                Data.Columns.Add("name", "Название");
                Data.Columns.Add("status", "Статус");
                Data.Columns.Add("delete", "");
                Data.Columns.Add("formulation", "");
                Data.Columns[0].ReadOnly = true;
                Data.Columns[2].ReadOnly = true;
                Data.Columns[4].ReadOnly = true;
                Data.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                Data.Columns[1].Width = 500;
                Data.Columns[3].Width = 22;
                Data.Columns[3].ReadOnly = true;
                Data.Columns[4].Visible = false;
            }

            //список экспретов
            {
                dataGridView.Columns.Add("name", "Имя");
                dataGridView.Columns.Add("area", "Область деятельности");
                dataGridView.Columns.Add("experience", "Опыт работы");
                dataGridView.Columns.Add("grade", "Оценка компетенции");
                dataGridView.Columns.Add("problems", "");
                dataGridView.Columns.Add("del", "");

                dataGridView.Columns[5].Width = 22;
                dataGridView.Columns[5].ReadOnly = true;
                dataGridView.Columns[4].ReadOnly = true;
                dataGridView.Columns[4].Visible = false;
                dataGridView.Columns[0].Width = 150;
                dataGridView.Columns[1].Width = 250;
                dataGridView.Columns[2].Width = 100;
                dataGridView.Columns[3].Width = 100;
            }

            count = Problems.Count;

           //загрузка списка проблем в таблицу
            for (int i = 0; i < Problems.Count - 1; i++)
           {
                Data.Rows.Add();
                Data.Rows[i].Cells[0].Value = i + 1;
                Data.Rows[i].Cells[1].Value = Problems[i][0];
                Data.Rows[i].Cells[2].Value = Problems[i][1];
                Data.Rows[i].Cells[3].Value = " X";
                Data.Rows[i].Cells[3].Style.BackColor = Color.Red;
                Data.Rows[i].Cells[4].Value = Formulations[i];
                tmp.Items.AddRange(new[] { Ready, NotReady });
                Data.Rows[i].Cells[2].ContextMenuStrip = tmp;
           }

            //загрузка списка экспертов
            for (int i = 0; i < experts.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = experts[i][0];
                dataGridView.Rows[i].Cells[1].Value = experts[i][1];
                dataGridView.Rows[i].Cells[2].Value = experts[i][2];
                dataGridView.Rows[i].Cells[3].Value = experts[i][3];
                dataGridView.Rows[i].Cells[4].Value = experts[i][4];
                dataGridView.Rows[i].Cells[5].Value = " X";
                dataGridView.Rows[i].Cells[5].Style.BackColor = Color.Red;
            }

            load_status = true;

        }

        private void Data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (load_status)
            {
                var a = 1;
                if (Data.Rows.Count == 2)
                    a = 2;
                for (int i = 0; i < Data.Rows.Count - a; i++)
                {
                    if (i == e.RowIndex)
                        continue;
                    if (Data.Rows[i].Cells[1].Value.ToString() == Data.Rows[e.RowIndex].Cells[1].Value.ToString())
                    {
                        Data.Rows.Remove(Data.Rows[e.RowIndex]);
                        MessageBox.Show("Проблема с таким название уже существует!");
                        return;
                    }
                }


                Data.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
                tmp.Items.AddRange(new[] { Ready, NotReady });
                Data.Rows[e.RowIndex].Cells[2].ContextMenuStrip = tmp;
                Data.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.Red;
                Data.Rows[e.RowIndex].Cells[3].Value = " X";

                if (count < Data.Rows.Count)
                {
                    List<string> sol = new List<string>();
                    solutions.Add(sol);
                    Problems.Add(new List<string>());
                    Problems[e.RowIndex].Add(Data.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Problems[e.RowIndex].Add("");
                    Formulations.Add("");
                    count++;
                }

                if (!status)
                {
                    Data.Rows[e.RowIndex].Cells[2].Value = "Не готово";
                    Problems[e.RowIndex][1] = ("Не готово");
                }

            }

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

                    var substr = Data.Rows[e.RowIndex].Cells[1].Value.ToString() + " ";

                    Data.Rows.Remove(Data.Rows[e.RowIndex]);

                    Problems.RemoveAt(e.RowIndex);

                    Formulations.RemoveAt(e.RowIndex);

                    count--;

                    for (int i = 0; i < experts.Count; i++)
                        if (experts[i][4].Contains(substr))
                            experts[i][4] = experts[e.RowIndex][4].Replace(substr, "");

                    load_status = false;
                    for (int i = 0; i < Data.Rows.Count - 1; i++)
                        Data.Rows[i].Cells[0].Value = (i + 1);
                    load_status = true;
                    
                }

            temp = e;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            if (e.ColumnIndex == 5 && e.RowIndex != -1 && dataGridView.Rows[e.RowIndex].Cells[5].Value != null)
               dataGridView.Rows.Remove(dataGridView.Rows[e.RowIndex]);
        }

        private void Data_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
                if (Data.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    Form edit = new ProblemEdit(this, ref Data, e, ref solutions, ref experts, ref Formulations);
                    this.Hide();
                    edit.Show();
                }

        }
        private void ChangeStatusReady(object sender, EventArgs e)
        {
            status = !status;
            Data.Rows[temp.RowIndex].Cells[2].Value = "Готово";
            Problems[temp.RowIndex][1] = "Готово";
            status = !status;
        }

        private void ChangeStatusТNotReady(object sender, EventArgs e)
        {
            status = !status;
            Data.Rows[temp.RowIndex].Cells[2].Value = "Не готово";
            Problems[temp.RowIndex][1] = "Не готово";
            status = !status;
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
                for (int j = 0; j < 4; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("Заполните пустые поля");
                        return;
                    }
                    
                }


            Data.Visible = true;
            BackButton.Visible = true;
            dataGridView.Visible = false;
            ExpertList.Visible = true;
            ExpertListBack.Visible = false;

            experts.Clear();


            int k = 0;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                experts.Add(new List<string>());
                for (int j = 0; j < 5; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        experts[k].Add(dataGridView.Rows[i].Cells[j].Value.ToString());
                        
                    }
                    else
                    {
                        experts[k].Add("");
                        experts[k].Add("");
                    }
                }

                k++;
            }

        }


    }
}
