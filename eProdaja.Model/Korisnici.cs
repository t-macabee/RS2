﻿using System;
using System.Collections.Generic;

namespace eProdaja.Model
{
    public partial class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; } 
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; } 
        public bool? Status { get; set; }


        //public virtual ICollection<Izlazi> Izlazis { get; } = new List<Izlazi>();
        //public virtual ICollection<KorisniciUloge> KorisniciUloges { get; } = new List<KorisniciUloge>();
        //public virtual ICollection<Ulazi> Ulazis { get; } = new List<Ulazi>();
    }
}
