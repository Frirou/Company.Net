﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        CompanyDBContext DataContext { get; }
    }
}