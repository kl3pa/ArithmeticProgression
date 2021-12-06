using System;
using System.Collections.Generic;
using System.Text;

namespace ArithmeticProgression
{
    class GeometricProgression: IIndexableSeries
    {


        public double this[int index] => _start * Math.Pow(_step, (index - 1));

        int _step;
        double _start;
        double _value;
        public double GetCurrent()
        {

            return _value;
        }

        public bool MoveNext()
        {
            _value *= _step;
            return true;
        }

        public void Reset()
        {
            _value = _start;
        }
        public GeometricProgression(int step, double start)
        {
            _step = step;
            _start = start;
            _value = start;
        }


    }
}
