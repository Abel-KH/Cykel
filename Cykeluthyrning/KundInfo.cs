public class KundInfo
{
    public string Namn {  get; set; }
    public int Alder { get; set; }
    public bool Medlemskap { get; set; }

    public KundInfo(string namn, int alder, bool medlemskap)
    {
        Namn = namn;
        Alder = alder;
        Medlemskap = medlemskap;
    }
}