﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Observer
{
    public interface IEtiqueta
    {
        int Id_Etiqueta { get; set; }
        string Nombre { get; set; }
    }
}
