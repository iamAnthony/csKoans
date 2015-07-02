using System;

namespace FinalTest
{
    public class Somme:IOperation
    {
        public bool PeutCalculer(string p0)
        {
            return p0.Contains("+") && !p0.Contains("/") && !p0.Contains("-") && !p0.Contains("*");
        }

        public int Calculer(string s)
        {
            if (PeutCalculer(s))
            {
                var a = int.Parse(s.Split('+').GetValue(0).ToString());
                var b = int.Parse(s.Split('+').GetValue(1).ToString());
                return a + b;
            }
            else
            {
                return 0;
            }
        }
    }
}