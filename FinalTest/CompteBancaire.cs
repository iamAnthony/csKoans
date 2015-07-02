using System;
using System.Collections.Generic;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly CompteCréé _compteCréé;
        private readonly DépotRéalisé _dépotRéalisé;
        private readonly String _numCompte;

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            _compteCréé = compteCréé;
            _dépotRéalisé = dépotRéalisé;
            this._numCompte = compteCréé.NuméroDeCompte;
        }

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

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            yield return new RetraitRéalisé(_numCompte, montantRetrait, dateRetrait);
        }
    }
}