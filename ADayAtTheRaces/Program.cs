namespace ADayAtTheRaces;

internal static class Program
{
    private static void Main(string[] args)
    {
        Dog[] dogs =
        [
            new("Henry"),
            new("Bobby"),
            new("Billy")
        ];

        Guy[] guys =
        [
            new("Messi", 100, 50, "Henry"),
            new("Senna", 100, 50, "Bobby"),
            new("Stark", 100, 50, "Billy")
        ];

        Track track = new(dogs, guys);
        
        track.StartRace();
        
    }
}