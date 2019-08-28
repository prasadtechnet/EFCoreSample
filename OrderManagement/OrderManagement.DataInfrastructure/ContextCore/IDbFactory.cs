﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrderManagement.DataInfrastructure.ContextCore
{
    public interface IDbFactory
    {

        DataContext GetDataContext { get; }
    }
}
