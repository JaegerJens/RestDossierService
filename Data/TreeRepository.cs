using System;
using System.Collections.Generic;
using System.Linq;
using RestDossierService.Models;

namespace RestDossierService.Data
{
    public interface ITreeRepository
    {
        List<TreeItem> GetAll();

        TreeItem Get(int id);
    }

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

        private static List<TreeItem> Data => new List<TreeItem>{
            Root,
            Dossier,
            Sequence0,
            Sequence1,
            Sequence2
        };

        private static TreeItem Root = new TreeItem
        {
            Id = 1,
            Name = "root",
            Children = Children(Dossier)
        };

        private static TreeItem Dossier = new TreeItem
        {
            Id = 2,
            Name = "Extedorin",
            Parent = Root,
            Children = Children(Sequence0, Sequence1, Sequence2)
        };

        private static TreeItem Sequence0 = new TreeItem
        {
            Id = 3,
            Name = "0000",
            Parent = Dossier
        };

        private static TreeItem Sequence1 = new TreeItem
        {
            Id = 4,
            Name = "0001",
            Parent = Dossier
        };

        private static TreeItem Sequence2 = new TreeItem
        {
            Id = 5,
            Name = "00002",
            Parent = Dossier
        };

        private static List<T> Children<T>(params T[] children)
        {
            return new List<T>(children);
        }
    }
}