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
                Connection.Open();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Не удалось открыть базу данных");
            }
            LoadDB();
        }

        private void LoadDB()
        {
            try
            {
                string commandstr = "SELECT S_secname, S_name, S_group FROM Students";

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(commandstr, Connection);
                OleDbDataReader reader = command.ExecuteReader();

                listBox1.Items.Clear();
                while (reader.Read())
                    listBox1.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString() + " ");
                // выполняем запрос и выводим результат в textBox1
                reader.Close();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Не удалось считать данные из базы.", "Ошибка.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BrowserButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
            if (listBox1.SelectedIndex != -1)
            {
                string student = listBox1.Items[listBox1.SelectedIndex].ToString();
                string[] positions = student.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string commandstr = "DELETE FROM Students WHERE S_secname='" + positions[0] +
                                    "' AND S_name='" + positions[1] + "' AND S_group='" + positions[2] + "'";
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
            EditForm editForm = new EditForm();
            editForm.StartPosition = FormStartPosition.CenterParent;
            editForm.ShowDialog(this);
            LoadDB();
        }
    }
}
