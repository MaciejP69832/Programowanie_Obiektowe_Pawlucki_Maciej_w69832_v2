using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSprzetuNarciarskiego.Modele
{
    public class Wypozyczenia
    {
        public int nr_wypozyczenia { get; set; }
        public int pk_klienta { get; set; }
        public int pk_pracownika { get; set; }
        public int pk_sprzetN { get; set; }
        public int pk_sprzetS { get; set; }
        public int pk_akcesoria { get; set; }
        public decimal koszt_wypozyczenia { get; set; }
        public DateTime data_wypozyczenia { get; set; }
        public string data_oddanie { get; set; }
        
    }
}
