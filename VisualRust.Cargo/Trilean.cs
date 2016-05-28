﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualRust.Cargo
{
    enum Trilean : byte
    {
        False = 0,
        True = 1,
        Unknown = 2,
    }

    static class TrileanExtensions
    {
        public static bool? ToBool(this Trilean value)
        {
            switch(value)
            {
                case Trilean.False:
                    return false;
                case Trilean.True:
                    return true;
                case Trilean.Unknown:
                    return null;
            }
            return null;
        }
    }
}
