using System;
using System.Collections.Generic;
using System.Linq;
using RestDossierService.Models;

namespace RestDossierService.Data
{
    public class TreeRepository : ITreeRepository
    {
        public List<TreeItem> GetAll()
        {
            return Data;
        }

        public TreeItem Get(int id)
        {
            return Data.FirstOrDefault(d => d.Id == id);
        }

        public List<TreeItem> GetChildren(TreeItem parent)
        {
            var relation = Relations.FirstOrDefault(r => r.Parent.Id == parent.Id);
            return relation?.Children;
        }

        private static List<TreeItem> Data => new List<TreeItem>
        {
            Root,
            Dossier,
            Sequence0,
            Sequence1,
            Sequence2
        };

        private static TreeItem Root = new TreeItem(1, "root");
        private static TreeItem Dossier = new TreeItem(2, "Extedorin");
        private static TreeItem Sequence0 = new TreeItem(3, "0000");
        private static TreeItem Sequence1 = new TreeItem(4, "0001");
        private static TreeItem Sequence2 = new TreeItem(5, "00002");

        private static List<ParentChildrenRelation<TreeItem>> Relations = new List<ParentChildrenRelation<TreeItem>>
        {
            new ParentChildrenRelation<TreeItem>(Root, Dossier),
            new ParentChildrenRelation<TreeItem>(Dossier, Sequence0, Sequence1, Sequence2)
        };
    }
}