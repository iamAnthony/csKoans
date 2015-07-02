using System;
using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;
        private readonly String _numCompte;

        public CompteBancaire(CompteCréé compteCréé)
        {
            _compteCréé = compteCréé;
            this._numCompte = compteCréé.NuméroDeCompte;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(_numCompte, montantDepot, dateDepot);
        }
    }
}