﻿using eProdaja.Services;
using eProdaja.Model;
using eProdaja.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {
        private IProizvodiService _proizvodiService;

        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public IEnumerable<Proizvodi> Get()
        {
            return _proizvodiService.Get();
        }

        [HttpGet("{id}")]
        public Proizvodi GetById(int id)
        {
            return _proizvodiService.GetById(id);
        }
    }
}
