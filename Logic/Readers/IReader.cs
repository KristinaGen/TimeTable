﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Transports;

namespace Logic.Readers
{
    public interface IReader
    {
        List<Transport> GetListTransport();
    }
}
