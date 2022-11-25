using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Interface
{
    public interface IKorisniciService
    {
        IEnumerable<Korisnici> Get();
        Korisnici GetById(int id);
    }
}
