using eProdaja.Model;
using eProdaja.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : ControllerBase
    {
        private IKorisniciService _korisniciService { get; set; }

        public KorisniciController(IKorisniciService korisniciService)
        {
            _korisniciService = korisniciService;
        }

        [HttpGet]
        public IEnumerable<Korisnici> Get()
        {
            return _korisniciService.Get();
        }

        [HttpGet("{id}")]
        public Korisnici GetById(int id)
        {
           return _korisniciService.GetById(id);
        }
    }
}
