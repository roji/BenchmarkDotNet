﻿using System;

namespace BenchmarkDotNet.Attributes
{
    /// <summary>
    /// Marks method to be executed before benchmark.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class SetupAttribute : Attribute
    {
        public SetupAttribute()
        {
        }
    }
}
