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
    public partial class FormTable : Form
    {

        public FormTable()
        {
            InitializeComponent();
        }

        public void ReadData()
        {
            // инициализируем соединение
            SqlConnection connection = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True;Pooling=false");
            connection.Open();
            // создаём команду запроса
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM students";
            // выполняем запрос
            SqlDataReader reader = command.ExecuteReader();
            // цикл чтения данных
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader.GetValue(1).ToString());
                item.SubItems.Add(reader.GetValue(2).ToString());
                item.SubItems.Add(reader.GetValue(3).ToString());
                item.SubItems.Add(reader.GetValue(4).ToString());
            }
            connection.Close();
        }

    }

}



