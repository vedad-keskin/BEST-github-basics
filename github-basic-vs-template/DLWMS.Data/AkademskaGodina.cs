namespace DLWMS.Data
{
    public class AkademskaGodina
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}