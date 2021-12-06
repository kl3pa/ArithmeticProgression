using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    public interface IIndexable
    {
        double this[int index] { get; }
    }
}
