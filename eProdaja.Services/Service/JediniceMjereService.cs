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
    public class JediniceMjereService : IJediniceMjereService
    {
        public EProdajaContext _context { get; set; }
        public IMapper _mapper { get; set; }

        public JediniceMjereService(EProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public IEnumerable<Model.JediniceMjere> Get()
        {
            var result = _context.JediniceMjeres.ToList();
            return _mapper.Map<List<Model.JediniceMjere>>(result);
        }

        public Model.JediniceMjere GetById(int id)
        {
            var result = _context.JediniceMjeres.Find(id);
            return _mapper.Map<Model.JediniceMjere>(result);
        }
    }
}
