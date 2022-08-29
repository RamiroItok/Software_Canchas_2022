using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mail
    {
        public string SenderMail{ get; set; }
        public string Contraseña { get; set; }
        public string Servidor { get; set; }
        public string Puerto { get; set; }
        public bool ssl{ get; set; }
    }
}
