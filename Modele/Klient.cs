namespace WypozyczalniaSprzetuNarciarskiego.Modele
{
    public class Klient
    {
        public int nr_klienta { get; set; } 
        public string imie { get; set; }  
        public string nazwisko { get; set; } 
        public string ulica { get; set; } 
        public string miasto { get; set; } 
        public string numerDomu { get; set; } 
        public string postal { get; set; }
        public string pesel { get; set; } 
        public string? nip { get; set; } 
        public string? nrTelefonu { get; set; }
    }
}
