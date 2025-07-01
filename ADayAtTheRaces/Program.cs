namespace ADayAtTheRaces;

internal static class Program
{
    private static void Main()
    {
        Greyhound[] hounds =
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

        Track track = new(hounds, guys);

        track.StartRace();
    }
}