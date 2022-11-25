using AutoMapper;
using eProdaja.Model;
using eProdaja.Services.Database;
using eProdaja.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Service
{
    public class KorisniciService : IKorisniciService
    {
        public EProdajaContext _context { get; set; }
        public IMapper _mapper { get; set; }

        public KorisniciService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Korisnici> Get()
        {
            var result = _context.Korisnicis.ToList();
            return _mapper.Map<List<Model.Korisnici>>(result);
        }

        public Model.Korisnici GetById(int id)
        {
            var result = _context.Korisnicis.Find(id);
            return _mapper.Map<Model.Korisnici>(result);
        }
    }
}
