using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Time : Triad
    {
        public Time(int hour, int minute, int second) : base(hour, minute, second) { }

        public override void Increase()
        {
            Value3++;
            if (Value3 >= 60)
            {
                Value3 = 0;
                Value2++;
            }
            if (Value2 >= 60)
            {
                Value2 = 0;
                Value1++;
            }
            if (Value1 >= 24) Value1 = 0;
        }

        public override string ToString() => $"Час: {Value1:D2}:{Value2:D2}:{Value3:D2}";
    }
}
