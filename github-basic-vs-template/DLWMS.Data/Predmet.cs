namespace DLWMS.Data
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int ECTS { get; set; }
        public int Semestar { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return $"{Naziv} ({ECTS})";
        }
    }
}