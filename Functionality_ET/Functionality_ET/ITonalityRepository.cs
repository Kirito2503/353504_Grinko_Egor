﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public interface ITonalityRepository
    {
        IEnumerable<Tonality> GetAllTonalities();
    }
}
