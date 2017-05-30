﻿using HQ.Interfaces;
using System;

namespace HQ.ObjectConverters
{
    /// <summary>
    /// Converts a string or string[] into an int
    /// </summary>
    public sealed class IntObjectConverter : IObjectConverter
    {
        public Type ConversionType => typeof(int);

        public object ConvertFromArray<T>(string[] arguments, T context)
        {
            if (!int.TryParse(string.Join(" ", arguments), out int res))
            {
                return null;
            }
            return res;
        }

        public object ConvertFromString<T>(string argument, T context)
        {
            if (!int.TryParse(argument, out int res))
            {
                return null;
            }
            return res;
        }
    }
}
