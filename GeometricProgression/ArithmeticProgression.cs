using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    class ArithmeticProgression:IIndexableSeries
    {
        public double this[int index] => _start + (index - 1) * _step;
        public double _start;
        double _step;
        double _value;
        void ISeries.Reset()
        {
            _step = _start;
        }
        bool ISeries.MoveNext()
        {
            _value += _step;
            return true;
        }

        double ISeries.GetCurrent()
        {
            return _value;
        }
        public ArithmeticProgression(double step, double start)
        {
            _step = step;
            _start = start;
            _value = start;
        }


    }
}
