public abstract class Fordon
{
    public int Nummer { get; set; }
    public decimal Timpris { get; set; }
    public bool ArUthyrd { get; set; }

    protected Fordon (int nummer, decimal timpris)
    {
        Nummer = nummer;
        Timpris = timpris;
        ArUthyrd = false;
    }
}
