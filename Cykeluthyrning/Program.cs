bool korKod = true;
while(korKod)
{
    Console.WriteLine("\n=== Kajens Cykeluthyrning ===");
    Console.WriteLine("1. Visa fordon  2. Registrera kund  3. Hyr ut");
    Console.WriteLine("4. Lämna tillbaka  5. Ladda  6. Avsluta");
    Console.Write("Val: ");

    string val = Console.ReadLine()!;
    switch(val)
    {
        case "1":
            //Visa fordon
            break;
        case "2":
            //Registrera kund
            break;
        case "3":
            //Hyr ut
            break;
        case "4":
            //Lämna tillbaka
            break;
        case "5":
            //Ladda
            break;
        case "6":
            korKod = false;
            break;
        default:
            Console.WriteLine("Ogiltigt val. Välj mellan 1 och 6");
            break;
    }
}