namespace FinalTest
{
    public class TypeReference
    {
        protected bool Equals(TypeReference other)
        {
            return _valeur == other._valeur;
        }

        public override int GetHashCode()
        {
            return _valeur;
        }

        private int _valeur;

        public TypeReference(int i)
        {
            this._valeur = i;
        }

       public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TypeReference) obj);
        }
    }
}