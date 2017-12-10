using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scinceAppWF
{
    class ConnectionDB
    {
        public String nameServer { get; set; }
        public String user { get; set; }
        public String password { get; set; }
        public String nameDB { get; set; }
        public int port { get; set; }

        public ConnectionDB(String nameServer, String user, String password, String nameDB, int port)
        {
            this.nameServer = nameServer;
            this.nameDB = nameDB;
            this.user = user;
            this.password = password;
            this.port = port;
        }

        
    }
}
