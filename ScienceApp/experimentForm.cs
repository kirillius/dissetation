﻿using ScienceApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public experimentForm()
        {
            InitializeComponent();
        }

        private void experimentForm_Load(object sender, EventArgs e)
        {
            List<dictionaries> listDictionaries = context.dictionaries.ToList(); 
            foreach(var item in listDictionaries)
            {
                dataGridView2.Rows.Add(item.displayName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView2.CurrentRow;
            if(currentRow!=null)
            {
                dataGridView1.Rows.Add(dataGridView2.Rows[currentRow.Index].Cells[0].Value);
                dataGridView2.Rows.Remove(currentRow);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;
            if (currentRow != null)
            {
                dataGridView2.Rows.Add(dataGridView1.Rows[currentRow.Index].Cells[0].Value);
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
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                parametersRequest += ("Справочник: " + row.Cells[0].Value + ", количество запросов: " + row.Cells[1].Value + "\n");
            }
            MessageBox.Show(parametersRequest);
        }
    }
}
