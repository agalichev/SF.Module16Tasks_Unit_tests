﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task16_6_2.Tests
{
    public class PrivateObject
    {
        private readonly object o;

        public PrivateObject(object o)
        {
            this.o = o;
        }

        public object Invoke(string methodName, params object[] args)
        {
            var methodInfo = o.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            if (methodInfo == null)
            {
                throw new Exception($"Method'{methodName}' not found in class '{o.GetType()}'");
            }
            return methodInfo.Invoke(o, args);
        }
    }
}
