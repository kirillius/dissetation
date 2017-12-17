using ScienceApp.db;
using ScienceApp.interfaces;
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
    public partial class dictionariesForm : Form, onCreateDictionary
    {
        dissertationEntities context = new dissertationEntities();
        public dictionariesForm()
        {
            InitializeComponent();
        }

        private void dictionariesForm_Load(object sender, EventArgs e)
        {
            var dictionaries = context.dictionaries.ToList();
            dataGridView1.DataSource = dictionaries;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newDictionary newD = new newDictionary(this);
            newD.ShowDialog();
        }

        public void onFinalCreate(dictionaries newItem)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells[0].Value = newItem.idDict;
            row.Cells[1].Value = newItem.nameTable;
            row.Cells[2].Value = newItem.displayName;

            dataGridView1.Rows.Add(row);
        }
    }
}
