using System.Collections.Generic;
using RestDossierService.Models;

namespace RestDossierService.Data
{
    public interface ITreeRepository
    {
        List<TreeItem> GetAll();

        TreeItem Get(int id);

        List<TreeItem> GetChildren(TreeItem parent);
    }
}