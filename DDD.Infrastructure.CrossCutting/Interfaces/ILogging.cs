﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infrastructure.CrossCutting.Interfaces
{
    public interface ILogging
    {
        void Debug(string message, params object[] p);
        void Info(string message, params object[] p);
        void Warn(string message, params object[] p);
        void Error(Exception ex, string message, params object[] p);
    }
}