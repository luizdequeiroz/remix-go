﻿using service.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace service.Utilities.Interfaces
{
    public interface IServiceSwitch
    {
        Func<object, Task<dynamic>> SetNewAsync { get; }
        Func<Task<IList<dynamic>>> GetAllAsync { get; }
        Func<object, Task<dynamic>> GetByIdAsync { get; }
        Func<object, Task<dynamic>> AlterAsync { get; }
        Func<object, Task<dynamic>> DeleteAsync { get; }

        IServiceSwitch Case(ServiceType serviceType);
    }
}
