using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEncriptar
    {
        string Encriptar_AES(string decrpyted);
        string Decrypt_AES(string encrypted);
        string Encriptar_MD5(string cadena);
    }
}
