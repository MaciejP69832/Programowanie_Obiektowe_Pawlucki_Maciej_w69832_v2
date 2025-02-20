using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSprzetuNarciarskiego.Modele
{
    public class Sprzet
    {
        public string producent { get; set; }
        public string typ { get; set; }
        public string numer_inw { get; set; }
        public int rozmiar_buta { get; set; }
        public int twardosc_buta { get; set; }

    }
    public class SprzetNarciarski : Sprzet
    {
        public int nr_sprzetN { get; set; }
        public int dlugosc_nart { get; set; }
        public int twardosc_nart { get; set; }
        public int dlugosc_kijkow { get; set; }
        public decimal koszt_wypozyczenia { get; set; }
    }
    public class SprzetSnowboard : Sprzet
    {
        public int nr_sprzetS { get; set; }
        public int dlugosc_deski { get; set; }
        public int twardosc_deski { get; set; }
        public int ksztalt_deski { get; set; }
        public decimal koszt_wypozyczenia { get; set; }
    }
}
