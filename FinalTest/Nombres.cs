using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get { return _keyValuePairs.Where(valeur => (valeur.Value%2 == 0)).Select(valeur=>valeur.Value); }
        }
    }
}