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
            /*experimentForm expForm = new experimentForm();
            expForm.MdiParent = this;
            expForm.Show();*/
        }

        private void историяЭкспериментовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            experimentWithStored experimentStored = new experimentWithStored();
            experimentStored.MdiParent = this;
            experimentStored.Show();
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

        private void экспериментСИндексамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            experimentWithIndex experimentIndex = new experimentWithIndex();
            experimentIndex.MdiParent = this;
            experimentIndex.Show();
        }

        private void хранимыеПроцедурыБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listStoredProcedures procedures = new listStoredProcedures();
            procedures.MdiParent = this;
            procedures.Show();
        }
    }
}
