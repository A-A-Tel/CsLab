namespace ADayAtTheRaces;

internal static class Program
{
    private static void Main()
    {
        Guy[] guys =
        [
            new Guy("Hank", 100),
            new Guy("Bob", 100),
            new Guy("Hudson", 100),
            new Guy("Jack", 100),
        ];

        Greyhound[] dogs =
        [
            new Greyhound(0),
            new Greyhound(1),
            new Greyhound(2),
            new Greyhound(3),
        ];

        Track track = new(dogs, guys);


        for (int i = 0; i < guys.Length; i++)
        {
            guys[i].PlaceBet(50, i);
            Console.WriteLine(guys[i].Bet.GetDescription());
        }
        track.StartRace();
    }
}