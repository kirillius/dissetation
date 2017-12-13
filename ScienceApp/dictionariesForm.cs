using ScienceApp.db;
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
    public partial class dictionariesForm : Form
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
    }
}
