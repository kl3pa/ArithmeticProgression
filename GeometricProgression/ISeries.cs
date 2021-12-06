using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
