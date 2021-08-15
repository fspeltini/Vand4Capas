﻿using Abstractions;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CreatorCassette : Creator
    {
        public override ICopia FactoryMethod()
        {
            return new Cassette();
        }
    }
}
