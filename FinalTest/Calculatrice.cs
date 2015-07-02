using System;
using System.Linq;

namespace FinalTest
{
    public class Calculatrice
    {
        private readonly IOperation[] _operation;

        public Calculatrice(IOperation[] operation)
        {
            _operation = operation;
        }

        public int Calculer(string p0)
        {
            return _operation.Where(operation => operation.PeutCalculer(p0)).Select(operation => operation.Calculer(p0)).FirstOrDefault();
        }
    }
}