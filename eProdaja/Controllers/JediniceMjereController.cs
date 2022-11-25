using eProdaja.Model;
using eProdaja.Services.Interface;
using eProdaja.Services.Service;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : ControllerBase
    {
        private IJediniceMjereService _jediniceMjere;

        public JediniceMjereController(IJediniceMjereService jediniceMjere)
        {
            _jediniceMjere = jediniceMjere;
        }

        [HttpGet]
        public IEnumerable<JediniceMjere> Get()
        {
            return _jediniceMjere.Get();
        }

        [HttpGet("{id}")]
        public JediniceMjere GetById(int id)
        {
            return _jediniceMjere.GetById(id);
        }
    }
}
