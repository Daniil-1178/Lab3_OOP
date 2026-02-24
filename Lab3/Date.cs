using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Date : Triad
    {
        public Date(int day, int month, int year) : base(day, month, year) { }

        public override void Increase()
        {
            Value1++;
            if (Value1 > 31)
            {
                Value1 = 1;
                Value2++;
            }
            if (Value2 > 12)
            {
                Value2 = 1;
                Value3++;
            }
        }

        public override string ToString() => $"Дата: {Value1:D2}.{Value2:D2}.{Value3}";
    }
}
