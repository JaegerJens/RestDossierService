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
    }
}