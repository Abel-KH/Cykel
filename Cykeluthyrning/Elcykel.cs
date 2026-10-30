public class Elcykel : Fordon
{
    public int Batteriniva { get; set; }

    public Elcykel(int nummer, int startBatteriniva) : base(nummer, 70m)
    {
        Batteriniva = startBatteriniva;
    }
}
