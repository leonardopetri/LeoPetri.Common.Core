namespace LeoPetri.Common.Entities
{
    public abstract class BaseEntity<T>
    {
        public readonly T Id;

        public BaseEntity(T id)
        {
            this.Id = id;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as BaseEntity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator == (BaseEntity<T> a, BaseEntity<T> b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator != (BaseEntity<T> a, BaseEntity<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.GetType().GetHashCode();
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }
    }
}
