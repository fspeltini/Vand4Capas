﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface IEtiqueta: IEntity
    {
        string Nombre { get; set; }
    }
}
