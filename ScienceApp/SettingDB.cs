//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scinceAppWF
{
    public partial class SettingDB : Form
    {
        ConnectionDB connectionSetting; 
        public SettingDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*var connectionSetting = new ConnectionDB(tbNameServer.Text, tbUser.Text, tbPassword.Text, tbNameDB.Text, Int32.Parse(tbPort.Text));
            string json = JsonConvert.SerializeObject(connectionSetting, Formatting.Indented);

            using (FileStream fs = new FileStream("connection.json", FileMode.OpenOrCreate))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(json);
                fs.Write(info, 0, info.Length);
                MessageBox.Show("Настройки успешно сохранены");
                Close();
            }*/
        }

        private void SettingDB_Load(object sender, EventArgs e)
        {
            /*using (FileStream fs = File.OpenRead("connection.json"))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                var json = "";
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    json+=temp.GetString(b);
                }

                connectionSetting = JsonConvert.DeserializeObject<ConnectionDB>(json);
                if (connectionSetting!=null)
                {
                    tbNameServer.Text = connectionSetting.nameServer;
                    tbNameDB.Text = connectionSetting.nameDB;
                    tbUser.Text = connectionSetting.user;
                    tbPassword.Text = connectionSetting.password;
                    tbPort.Text = connectionSetting.port.ToString();
                }
            }*/
        }
    }
}
