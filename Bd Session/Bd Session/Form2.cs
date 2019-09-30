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
    public partial class AddForm : Form
    {
        private string connectstr;
        private OleDbConnection Connection;

        public AddForm()
        {
            InitializeComponent();
            Connection = MainForm.Connection;
        }

        private void AddStudent()
        {

            if (String.IsNullOrWhiteSpace(SecNameBox.Text))
            {
                MessageBox.Show("Введите фамилию студента.", "Не все данные введены.");
            }
            else if (String.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Введите имя студента.", "Не все данные введены.");
            }
            else if (String.IsNullOrWhiteSpace(GroupBox.Text))
            {
                MessageBox.Show("Введите группу студента.", "Не все данные введены.");
            }
            else
            {
                string comstr = "INSERT INTO Students ( S_secname, S_name, S_group) VALUES " +
                                "('" + SecNameBox.Text + "' , '" + NameBox.Text + "', '" + GroupBox.Text + "')";
                try
                {
                    OleDbCommand command = new OleDbCommand(comstr, Connection);
                    command.ExecuteNonQuery();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Ошибка");
                }
                this.Close();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) == true)
            {
                if (e.KeyChar == (char)Keys.Enter)
                    AddStudent();
                if (e.KeyChar == (char)Keys.Escape)
                    this.Close();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
