using scinceAppWF;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void новыйЭкспериментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            experimentForm expForm = new experimentForm();
            expForm.MdiParent = this;
            expForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            experimentForm expForm = new experimentForm();
            expForm.MdiParent = this;
            expForm.Show();
        }

        private void историяЭкспериментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyForm history = new historyForm();
            history.MdiParent = this;
            history.Show();
        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingDB setting = new SettingDB();
            setting.MdiParent = this;
            setting.Show();
        }

        private void справочникиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dictionariesForm dictionaries = new dictionariesForm();
            dictionaries.MdiParent = this;
            dictionaries.Show();
        }
    }
}
