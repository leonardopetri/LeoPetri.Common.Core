using System.Collections.Generic;

namespace LeoPetri.Common.Core
{
    public abstract class Entity : IValidatable
    {
        public IList<string> BrokenRules { get; set; }
    }

    public abstract class Entity<TId> : Entity 
        where TId : struct
    {
        public readonly TId Id;

        public Entity(TId id)
        {
            this.Id = id;
            this.BrokenRules = new List<string>();
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<TId>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (compareTo is null) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator == (Entity<TId> a, Entity<TId> b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator != (Entity<TId> a, Entity<TId> b)
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
