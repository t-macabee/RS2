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
    public class ProizvodiService : IProizvodiService
    {
        public EProdajaContext _context { get; set; }
        public IMapper _mapper;

        public ProizvodiService(EProdajaContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Model.Proizvodi> Get()
        {
            var result = _context.Proizvodis.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(result);
        }

        public Model.Proizvodi GetById(int id)
        {
            var result = _context.Proizvodis.Find(id);
            return _mapper.Map<Model.Proizvodi>(result);
        }
    }
}
