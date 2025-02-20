using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSprzetuNarciarskiego.Modele
{
    public class Pracownik
    {
        public int nr_pracownika { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string data_urodzenia { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string stanowisko { get; set; }
    }
}
