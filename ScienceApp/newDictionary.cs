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
    public partial class newDictionary : Form
    {
        dissertationEntities context = new dissertationEntities();
        onCreateDictionary listener;

        public newDictionary(onCreateDictionary listener)
        {
            InitializeComponent();
            this.listener = listener;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dictionaries newItem = new dictionaries();
            newItem.nameTable = textBox2.Text;
            newItem.displayName = textBox1.Text;

            context.dictionaries.Add(newItem);
            context.SaveChanges();
            this.listener.onFinalCreate(newItem);
            this.Close();
        }
    }
}
