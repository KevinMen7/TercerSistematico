﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICalendarioRepository:IRepository<Calendario>
    {
        int GetLastIdCuota();
    }
}
