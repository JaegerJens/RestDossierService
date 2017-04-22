using System.Collections.Generic;

namespace RestDossierService.Models
{
    public class TreeItem
    {
        public TreeItem()
        {
            Children = new List<TreeItem>();
        }

        public int Id {get; set;}
        public string Name {get; set;}
        public TreeItem Parent {get; set;}
        public List<TreeItem> Children {get; set;}
    }
}
