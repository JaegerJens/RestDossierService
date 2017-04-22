using System;
using System.Collections.Generic;
using RestDossierService.Models;

namespace RestDossierService.Data
{
    public class TreeRepository : ITreeRepository
    {
        public List<TreeItem> GetAll() {
            var root = new TreeItem
            {
              Id = 1,
              Name = "root",
            };
            return new List<TreeItem>{root};
        }
    }

    public interface ITreeRepository
    {
        List<TreeItem> GetAll();
    }
}