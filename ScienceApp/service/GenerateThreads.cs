using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceApp.service
{
    class GenerateThreads
    {
        int lambda;
        int delay;
        string connectionString, query;
        List<TaskQuery> tasksQuery;

        public GenerateThreads(int lambda, string query, Random rnd)
        {
            connectionString = "Server=185.158.153.126;Database=dissertation;User Id=rental;Password=kirillius1991;pooling=false";
            this.lambda = lambda;
            this.query = query;
            tasksQuery = new List<TaskQuery>();
            delay = new CalculateTimesThread(lambda, rnd).getDelay();
            Console.WriteLine(String.Format("t={0} мсек", delay));
            generate();
        }

        private void generate()
        {
            for(var i=0; i<lambda; i++)
            {
                if(i==0)
                {
                    Task.Run(() => {
                        TaskQuery obj = new TaskQuery();
                        tasksQuery.Add(obj);
                        obj.startWach();
                        sendQuery(obj);
                    });
                }
                else
                {
                    Task.Run(async () => {
                        await Task.Delay(delay);
                        TaskQuery obj = new TaskQuery();
                        tasksQuery.Add(obj);
                        obj.startWach();
                        sendQuery(obj);
                    });
                }
                
                //tasksQuery[i] = new TaskQuery(query, task);
            }
        }

        private void sendQuery(TaskQuery obj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result = 1;
                string error = null;
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = null;
                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                }
                catch (Exception exp)
                {
                    result = 0;
                    error = exp.Message;
                }
                finally
                {
                    // Always call Close when done reading.
                    if (reader != null)
                        reader.Close();

                    connection.Close();
                    obj.stopWatch();
                    obj.setResult(result, error);
                }
            }
        }

        public List<TaskQuery> getArray()
        {
            return tasksQuery;
        }
    }
}
