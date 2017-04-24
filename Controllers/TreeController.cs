using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestDossierService.Data;
using RestDossierService.Models;

namespace RestDossierService.Controllers
{
    [Route("api/[controller]")]
    public class TreeController : Controller
    {
        private readonly ITreeRepository _repo;

        public TreeController(ITreeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<TreeItem> Get() {
            return _repo.GetAll();
        }

        [HttpGetAttribute("{id}")]
        public TreeItem Get(int id)
        {
            return _repo.Get(id);
        }

        [Route("{id}/children")]
        public List<TreeItem> GetChildren(int id)
        {
            var parent = _repo.Get(id);
            if (parent == null)
                return null;
            var children = _repo.GetChildren(parent);
            foreach(var child in children)
            {
                child.Parent = parent;
            }
            return children;
        }
    }
}