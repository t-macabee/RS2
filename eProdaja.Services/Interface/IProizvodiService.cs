﻿using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Interface
{
    public interface IProizvodiService
    {
        IEnumerable<Proizvodi> Get();
        Proizvodi GetById(int id);
    }
}
