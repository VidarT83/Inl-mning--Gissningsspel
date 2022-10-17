{
    Random rt = new Random(); 
    int söktal = rt.Next(1,101);
    int i = 0;
    int t = 0;
    Console.Write("Skriv ett heltal mellan 1 och 100: ");
    while (true)
    {
        i++;
        while (true)
        {
            t = int.Parse(Console.ReadLine());
            
            if (t > 0 && t < 101)
            {
                break;
            }
            Console.WriteLine("Felaktigt (Skriv ett tal mellan 1 och 100)");
        }
        if (t < söktal)
        {
            Console.WriteLine("Talet är högre");
        }
        if (t > söktal)
        {
            Console.WriteLine("Talet är lägre");
        }
        if (t == söktal)
        {
            break;
        }
        Console.WriteLine("Försök igen");
    }
    Console.WriteLine("Talet är rätt!");
    Console.WriteLine("Antalet gissningar var: " + i);
}