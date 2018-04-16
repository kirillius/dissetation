using ScienceApp.db;
using ScienceApp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceApp
{
    public partial class experimentForm : Form
    {
        //dissertationEntities context = new dissertationEntities();
        Dictionary<String, String> taskRequest;
        string connectionString;
        GenerateThreads[] threads;
        List<Dictionary<string, string>> queries;
        int countUsers;

        public experimentForm()
        {
            InitializeComponent();
            connectionString = "Server=185.158.153.126;Database=dissertation;User Id=rental;Password=kirillius1991;pooling=false";
            queries = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"displayName", "Запрос на чтение документа" },
                    {"query", "select * from doctors" }
                },
                new Dictionary<string, string>()
                {
                    {"displayName", "Запрос на запись документа" },
                    {"query", "select * from doctors" }
                },
                new Dictionary<string, string>()
                {
                    {"displayName", "Запрос на чтение объекта с 3-join" },
                    {"query", "select * from doctors" }
                },
                new Dictionary<string, string>()
                {
                    {"displayName", "Запрос на запись объекта с 3-join" },
                    {"query", "select * from doctors" }
                }
            };
        }

        private void experimentForm_Load(object sender, EventArgs e)
        {
            /*List<dictionaries> listDictionaries = context.dictionaries.ToList();*/
            foreach (var item in queries)
            {
                dataGridView2.Rows.Add(item["displayName"], item["query"]);
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
            /*String parametersRequest = "";
            taskRequest = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                parametersRequest += ("Справочник: " + row.Cells[0].Value + ", количество запросов: " + row.Cells[1].Value + "\n");
                taskRequest.Add(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());
            }
            richTextBox1.Text = "Начата отправка запросов на сервер БД со следующей конфигурацией:\n" + parametersRequest;
            executeTaskRequest();*/
            countUsers = Convert.ToInt32(textBox1.Text);
            threads = new GenerateThreads[countUsers];
            Random rnd = new Random();
            for(int i=0; i<countUsers; i++)
            {
                threads[i] = new GenerateThreads(Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value), dataGridView1.Rows[0].Cells[2].Value.ToString(), rnd);
            }
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
                double allTime=0;
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += "\nНачата обработка запроса " + query;
                });
                for (var i = 0; i < count; i++)
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = null;
                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        successRequest++;
                    }
                    catch (Exception exp)
                    {
                        errorList.Add(String.Format("Ошибка: {0}", exp.Message));
                        errorRequest++;
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        if(reader!=null)
                            reader.Close();

                        connection.Close();

                        stopWatch.Stop();
                        // Get the elapsed time as a TimeSpan value.
                        TimeSpan ts = stopWatch.Elapsed;
                        allTime += ts.TotalSeconds;

                        // Format and display the TimeSpan value.
                        string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                            ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);

                        richTextBox1.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text += "\nВремя выполнения запроса: " + elapsedTime;
                        });
                    }
                }

                string avgTime = String.Format("{0:00.0000} сек.", allTime / count);
                string text = "\nПо запросу " + query + " успешных выполнений: " + successRequest + ", выполнений с ошибкой: " + errorRequest + ", среднее время выполнения: "+avgTime;
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

        private void button3_Click(object sender, EventArgs e)
        {
            int user = 1;
            richTextBox1.Text = "";
            foreach (var thread in threads)
            {
                List<TaskQuery> tasks = thread.getArray();
                int i = 1;
                foreach (var item in tasks)
                {
                    string resultText = (item.getResult()==1) ? "выполнился успешно" : item.getResult() == 0 ? "выполнился неуспешно" : "еще выполняется";
                    if (item.getResult()==0)
                        resultText += " ошибка: " + tasks[0].getError();

                    string formatResult= String.Format("Юзер {0}, запрос №{1}, {2}", user, i, resultText);
                    string formatResultPart2 = String.Format(" за {0}", item.getTime());

                    if (item.getResult() != -1)
                        formatResult += formatResultPart2;

                    richTextBox1.Text += formatResult + "\n";
                    i++;
                }

                user++;
            }
        }
    }
}
