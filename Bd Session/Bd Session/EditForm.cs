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
    public partial class EditForm : Form
    {
        private OleDbConnection Connection;
        private string[] DataStr;

        public EditForm(string[] comstr)
        {
            InitializeComponent();
            Connection = MainForm.Connection;
            DataStr = comstr;
            SecNameBox.Text = comstr[0];
            NameBox.Text = comstr[1];
            GroupBox.Text = comstr[2];
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditStudent()
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
                string comstr = "UPDATE Students SET S_secname='" + SecNameBox.Text + "', S_name = '" + NameBox.Text +
                                     "', S_group = '" + GroupBox.Text + "' WHERE S_secname='" + DataStr[0] +
                                    "' AND S_name='" + DataStr[1] + "' AND S_group='"
                                    + DataStr[2] + "'";
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
            EditStudent();
        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
