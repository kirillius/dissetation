using ScienceApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceApp
{
    public partial class experimentForm : Form
    {
        dissertationEntities context = new dissertationEntities();
        List<Dictionary<String, String>> taskRequest;
        string connectionString;

        public experimentForm()
        {
            InitializeComponent();
            connectionString = "Server=185.158.153.126;Database=dissertation;User Id=rental;Password=kirillius1991;";
        }

        private void experimentForm_Load(object sender, EventArgs e)
        {
            List<dictionaries> listDictionaries = context.dictionaries.ToList(); 
            foreach(var item in listDictionaries)
            {
                dataGridView2.Rows.Add(item.displayName, item.nameTable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView2.CurrentRow;
            if(currentRow!=null)
            {
                dataGridView1.Rows.Add(dataGridView2.Rows[currentRow.Index].Cells[0].Value, 0, dataGridView2.Rows[currentRow.Index].Cells[1].Value);
                dataGridView2.Rows.Remove(currentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;
            if (currentRow != null)
            {
                dataGridView2.Rows.Add(dataGridView1.Rows[currentRow.Index].Cells[0].Value, dataGridView1.Rows[currentRow.Index].Cells[2].Value);
                dataGridView1.Rows.Remove(currentRow);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;
            if(currentRow!=null)
            {
                if (dataGridView1.Rows[currentRow.Index].Cells[1].Value != null)
                    startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            String parametersRequest = "";
            taskRequest = new List<Dictionary<string, string>>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                parametersRequest += ("Справочник: " + row.Cells[0].Value + ", количество запросов: " + row.Cells[1].Value + "\n");

                Dictionary<String, String> item = new Dictionary<string, string>();
                item.Add("nameTable", row.Cells[2].Value.ToString());
                item.Add("countRequest", row.Cells[1].Value.ToString());
                taskRequest.Add(item);
            }
            richTextBox1.Text = "Начата отправка запросов на сервер БД со следующей конфигурацией:\n" + parametersRequest;
            executeTaskRequest();
        }

        private void executeTaskRequest()
        {
            if (taskRequest == null)
                return;

            //берем конфиг запросов, делаем
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                foreach (var item in taskRequest)
                {
                    string queryString = "SELECT * FROM [dbo].[mos]";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            String text = String.Format("Полученная запись: {0}, {1}", reader["id"], reader["name"]);
                            richTextBox1.Text += "\n" + text;
                        }
                    }
                    catch(Exception exp)
                    {
                        String text = String.Format("Ошибка: {0}", exp.Message);
                        richTextBox1.Text += "\n" + text;
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                        connection.Close();
                    }
                }
            }
        }
    }
}
