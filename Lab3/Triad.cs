using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public abstract class Triad
    {
        public int Value1;
        public int Value2;
        public int Value3;

        public Triad(int v1, int v2, int v3)
        {
            Value1 = v1;
            Value2 = v2;
            Value3 = v3;
        }

        public virtual void Increase()
        {
            Value1++;
            Value2++;
            Value3++;
        }

        public abstract override string ToString();
    }
}
