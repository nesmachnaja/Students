using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormStud : Form
    {
        public FormStud()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();

        private void подклюитьсяКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Data Source=LENOVO-PC\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=False";
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных");
            }

        }

        private void закрытьСоединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void FormStud_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void button_kol_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе данных");
                return;
            }
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM students", connection);
            int number = (int)command.ExecuteScalar();
            MessageBox.Show(number.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "") | (tbFam.Text == "") | (tbGroup.Text == "") | (tbCourse.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
            // создаём соединение
            SqlConnection connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=false");
            connection.Open();
            // начало транзакции
            SqlTransaction transaction = connection.BeginTransaction();
            // создаём объект SqlCommand
            SqlCommand command = connection.CreateCommand();
            // связываем команду с транзакцией
            command.Transaction = transaction;

            // выполняем две отдельные команды
            command.CommandText = "SELECT Id FROM students WHERE Id = (SELECT MAX(Id) FROM students)";
            int id = (int)command.ExecuteScalar();
            command.CommandText = "INSERT INTO students (Id, Имя, Фамилия, Группа, Курс) VALUES ('" + ++id + "' , '" + tbName.Text + "' , '" + tbFam.Text + "' , '" + tbGroup.Text + "' , '" + tbCourse.Text + "' )";
            command.ExecuteNonQuery();

            // сохраняем изменения, совершённые в транзакции
            transaction.Commit();
            // закрываем соединение
            connection.Close();
            }
        }

        private void btAllTable_Click(object sender, EventArgs e)
        {
            FormTable FormTable = new FormTable();
            FormTable.ReadData();
            FormTable.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "") & (tbFam.Text == "") & (tbGroup.Text == "") & (tbCourse.Text == ""))
            {
                MessageBox.Show("Заполните хотя бы одно из полей!");
            }
            else
            {
                FormTable FormTable = new FormTable();
                SqlConnection connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=false");
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM students WHERE Имя='" + tbName.Text + "'; SELECT * FROM students WHERE Фамилия='" + tbFam.Text + "'; SELECT * FROM students WHERE Группа='" + tbGroup.Text + "'; SELECT * FROM students WHERE Курс='" + tbCourse.Text + "' ";
                SqlDataReader reader = command.ExecuteReader();
                do // цикл просмотра результатов
                {
                    while (reader.Read()) // цикл просмотра данных   
                    {
                        ListViewItem item = FormTable.listView1.Items.Add(reader.GetValue(1).ToString());
                        item.SubItems.Add(reader.GetValue(2).ToString());
                        item.SubItems.Add(reader.GetValue(3).ToString());
                        item.SubItems.Add(reader.GetValue(4).ToString());
                    }
                } while (reader.NextResult());
                connection.Close();
                FormTable.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((tbName.Text == "") | (tbFam.Text == ""))
            {
                MessageBox.Show("Введите имя и фамилию!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=false");
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Faculty";
                command.CommandType = CommandType.StoredProcedure;

                // создание выходного параметра
                command.Parameters.Add("@faculty", SqlDbType.NChar);
                command.Parameters[0].Direction = ParameterDirection.ReturnValue;

                // задаем значение и направление параметра
                command.Parameters.Add("@name", SqlDbType.NChar);
                command.Parameters[1].Value = tbName.Text;
                command.Parameters[1].Direction = ParameterDirection.Input;
                command.Parameters.Add("@fam", SqlDbType.NChar);
                command.Parameters[2].Value = tbFam.Text;
                command.Parameters[2].Direction = ParameterDirection.Input;

                // выполнение запроса
                command.ExecuteNonQuery();
                if (command.Parameters[0].Value.ToString() == "")
                {
                    MessageBox.Show("Такого студента нет в списке!");
                }
                else
                {
                    MessageBox.Show(command.Parameters[0].Value.ToString());
                }
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if ((tbName.Text == "") | (tbFam.Text == "") | (tbGroup.Text == "") | (tbCourse.Text == ""))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                SqlConnection connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=false");
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Update_stud";
                command.CommandType = CommandType.StoredProcedure;

                // задаем значение и направление параметра
                command.Parameters.Add("@name", SqlDbType.NChar);
                command.Parameters[0].Value = tbName.Text;
                command.Parameters[0].Direction = ParameterDirection.Input;
                command.Parameters.Add("@fam", SqlDbType.NChar);
                command.Parameters[1].Value = tbFam.Text;
                command.Parameters[1].Direction = ParameterDirection.Input;
                command.Parameters.Add("@group", SqlDbType.NChar);
                command.Parameters[2].Value = tbGroup.Text;
                command.Parameters[2].Direction = ParameterDirection.Input;
                command.Parameters.Add("@course", SqlDbType.NChar);
                command.Parameters[3].Value = tbCourse.Text;
                command.Parameters[3].Direction = ParameterDirection.Input;

                // выполнение запроса
                command.ExecuteNonQuery();

                if ((int)command.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Такого студента в списке нет! Проверьте правильность введённых имени и фамилии");
                }
            }
        }
    }
}
