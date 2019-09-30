using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bd_Session
{
    public partial class MainForm : Form
    {
        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Session.mdb;";
        public static OleDbConnection Connection;

        public MainForm()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connectString);
            try
            {
                Connection.Open();// Подключаемся к БД
            }
            catch (OleDbException)
            {
                MessageBox.Show("Не удалось открыть базу данных", "Ошибка.");
            }
            LoadDB();
        }

        private void LoadDB() //Выводит содержимое БД на экран
        {
            try
            {
                string commandstr = "SELECT S_secname, S_name, S_group FROM Students";

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(commandstr, Connection);
                OleDbDataReader reader = command.ExecuteReader();

                StData.Rows.Clear();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = "";
                    data[data.Count - 1][1] = reader[0].ToString();
                    data[data.Count - 1][2] = reader[1].ToString();
                    data[data.Count - 1][3] = reader[2].ToString();
                }
                reader.Close();
                foreach (string[] s in data)
                    StData.Rows.Add(s);
                StData.Sort(StData.Columns["StSecName"], ListSortDirection.Ascending);
                for (int i = 0; i < StData.RowCount; i++)
                    StData[0, i].Value = (i + 1).ToString();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Не удалось считать данные из базы.", "Ошибка.");
            }
        }

        private int GetStId()
        {
            //Строка команды SQL
            string GetIdComStr = "SELECT S_id FROM Students WHERE S_secname='" + StData[1, StData.SelectedCells[0].RowIndex].Value.ToString() +
                            "' AND S_name='" + StData[2, StData.SelectedCells[0].RowIndex].Value.ToString() + "' AND S_group='"
                            + StData[3, StData.SelectedCells[0].RowIndex].Value.ToString() + "'";
            ///**********Получаем ID студента**************
            int Sid = 0;
            try
            {
                OleDbCommand GetId = new OleDbCommand(GetIdComStr, Connection);
                OleDbDataReader reader = GetId.ExecuteReader();
                while (reader.Read())
                    Sid = Convert.ToInt32(reader[0]);
                //*********************************************
                return Sid;
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось считать данные из базы.", "Ошибка.");
                return -1;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < StData.RowCount; i++)//Проход по строкам
            {
                StData.Rows[i].Selected = false;                //Снимаем выделение со строки
                if (!String.IsNullOrWhiteSpace(SearchBox.Text)) //Если строка поиска не пустая, то выполняем поиск
                    for (int j = 0; j < StData.ColumnCount; j++)//Проход ко столбцам
                        if (StData[j, i].Value != null)         //Если ячейка не пустая, то проверям содержит ли она строку поиска
                            if (StData[j, i].Value.ToString().Contains(SearchBox.Text))//Если да, то выделяем ряд
                            {
                                StData.Rows[i].Selected = true;//Выделение ряда
                                StData.FirstDisplayedScrollingRowIndex = i;//Пролистываем таблицу до искомого студента
                                break;//Выход из цикла
                            }
            }
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchLabel.Visible = false;
        }

        private void SearchBox_Leave(object sender, EventArgs e)
        {
            SearchLabel.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.StartPosition = FormStartPosition.CenterParent;
            addForm.ShowDialog(this);
            LoadDB();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StData.SelectedCells[0].RowIndex != -1)
            {
                string student = StData.SelectedCells.ToString();
                //Комманда для SQL
                string commandstr = "DELETE FROM Students WHERE S_secname='" + StData[1, StData.SelectedCells[0].RowIndex].Value.ToString() +
                                    "' AND S_name='" + StData[2, StData.SelectedCells[0].RowIndex].Value.ToString() + "' AND S_group='"
                                    + StData[3, StData.SelectedCells[0].RowIndex].Value.ToString() + "'";
                try
                {
                    OleDbCommand command = new OleDbCommand(commandstr, Connection);
                    command.ExecuteNonQuery();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Не удалось удалить элемент.", "Ошибка.");
                }
                LoadDB();
            }
            else
            {
                MessageBox.Show("Элемент не выбран.", "Ошибка.");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            string[] commandstr = { StData[1, StData.SelectedCells[0].RowIndex].Value.ToString(),
                                    StData[2, StData.SelectedCells[0].RowIndex].Value.ToString(),
                                    StData[3, StData.SelectedCells[0].RowIndex].Value.ToString() };
            EditForm editForm = new EditForm(commandstr);
            editForm.StartPosition = FormStartPosition.CenterParent;
            editForm.ShowDialog(this);
            LoadDB();
        }

        private void StData_Click(object sender, EventArgs e)
        {
            ExData.Rows.Clear();//Очищаем таблицу экзаменов
            int Sid = GetStId();//Получаем id Студента
            //***********Извлекаем даннные выбранного студента из таблицы**********
            string FullExDataComStr = "SELECT ExName, ExScore FROM Exams WHERE s_id=" + Sid.ToString();
            try
            {
                OleDbCommand FullExData = new OleDbCommand(FullExDataComStr, Connection);
                OleDbDataReader reader = FullExData.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[2]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                }
                reader.Close();
                //*********************************************************
                //Заполняем таблицу
                foreach (string[] s in data)
                    ExData.Rows.Add(s);
            }
            catch (OleDbException)
            {
                MessageBox.Show("Не прочитать БД.", "Ошибка.");
            }

        }

        private void SearchLabel_Click(object sender, EventArgs e)
        {
            SearchLabel.Visible = false;
            SearchBox.Focus();
        }
    }
}
