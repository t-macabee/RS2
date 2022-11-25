using eProdaja.Model;
using eProdaja.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Service
{
    public class DummyProizvodiService : IProizvodiService
    {        
        public DummyProizvodiService()
        {            
        }

        public List<Proizvodi> ProizvodiList = new List<Proizvodi>()
        {
            new Proizvodi() { ProizvodId = 1, Naziv = "Mis" },
            new Proizvodi() { ProizvodId = 2, Naziv = "Tastatura"}
        };

        public IEnumerable<Proizvodi> Get()
        {
            ProizvodiList.Add(new Proizvodi() { ProizvodId = 3, Naziv = "Monitor" });
            return ProizvodiList;
        }

        public Proizvodi GetById(int id)
        {
            return ProizvodiList.FirstOrDefault(x => x.ProizvodId == id);
        }
    }
}
