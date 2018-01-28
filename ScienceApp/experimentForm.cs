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
        Dictionary<String, String> taskRequest;
        string connectionString;

        public experimentForm()
        {
            InitializeComponent();
            connectionString = "Server=185.158.153.126;Database=dissertation;User Id=rental;Password=kirillius1991;";
        }

        private void experimentForm_Load(object sender, EventArgs e)
        {
            List<dictionaries> listDictionaries = context.dictionaries.ToList();
            foreach (var item in listDictionaries)
            {
                dataGridView2.Rows.Add(item.displayName, item.nameTable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView2.CurrentRow;
            if (currentRow != null)
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
            if (currentRow != null)
            {
                if (dataGridView1.Rows[currentRow.Index].Cells[1].Value != null)
                    startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            String parametersRequest = "";
            taskRequest = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                parametersRequest += ("Справочник: " + row.Cells[0].Value + ", количество запросов: " + row.Cells[1].Value + "\n");
                taskRequest.Add(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());
            }
            richTextBox1.Text = "Начата отправка запросов на сервер БД со следующей конфигурацией:\n" + parametersRequest;
            executeTaskRequest();
        }

        private void executeTaskRequest()
        {
            if (taskRequest == null)
                return;

            string selectString = "SELECT * FROM ";
            Task[] tasksQuery = new Task[taskRequest.Keys.Count];

            int i = 0;
            foreach (var key in taskRequest.Keys)
            {
                tasksQuery[i] = new Task(() => sendQuery(selectString + key, Int32.Parse(taskRequest[key])));
                i++;
            }

            foreach (var t in tasksQuery)
                if(t!=null)
                    t.Start();
        }

        private void sendQuery(String query, int count)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int successRequest = 0, errorRequest = 0;
                List<string> errorList = new List<string>();
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += "\nНачата обработка запроса " + query;
                });
                for (var i = 0; i < count; i++)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            /*String text = String.Format("Полученная запись: {0}, {1}", reader["id"], reader["name"]);
                            richTextBox1.Invoke((MethodInvoker)delegate
                            {
                                richTextBox1.Text += "\n" + text;
                            });*/
                            successRequest++;
                        }
                    }
                    catch (Exception exp)
                    {
                        errorList.Add(String.Format("Ошибка: {0}", exp.Message));
                        errorRequest++;
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                        connection.Close();
                    }
                }

                string text = "\nПо запросу " + query + " успешных выполнений: " + successRequest + ", выполнений с ошибкой: " + errorRequest;
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += "\n" + text;
                });

                if (errorRequest>0)
                {
                    string delimiter = "\n";
                    string errorText = "Ошибки:\n"+ errorList.Aggregate((i, j) => i + delimiter + j);
                    richTextBox1.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text += "\n" + errorText;
                    });
                }
            }
        }
    }
}
