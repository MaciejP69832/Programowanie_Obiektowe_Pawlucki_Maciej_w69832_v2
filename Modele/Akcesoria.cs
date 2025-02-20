using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSprzetuNarciarskiego.Modele
{
    public class Akcesoria
    {
        public int nr_akcesoria { get; set; }
        public string producent { get; set; }
        public string typ { get; set; }
        public string numer_inw { get; set; }
        public string rozmiar { get; set; }
        public string opis { get; set; }
        public decimal koszt_wypozyczenia { get; set; }

    }
}
