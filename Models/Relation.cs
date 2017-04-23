using System.Collections.Generic;

namespace RestDossierService.Models
{
    public class ParentChildrenRelation<T>
    {
        public ParentChildrenRelation(T parent, params T[] children)
        {
            Parent = parent;
            Children = new List<T>(children);
        }

        public T Parent {get;}

        public List<T> Children {get; }
    }
}