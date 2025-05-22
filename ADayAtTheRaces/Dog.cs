namespace ADayAtTheRaces;

public class Greyhound
{
    private const int TrackLength = 250;
    private const int MinSpeed = 5;
    private const int MaxSpeed = 20;

    public int StartingPosition = 0;
    public int Location = 0; 
    public Random Randomizer = new();

    public bool Run()
    {
        Location += Randomizer.Next(MinSpeed, MaxSpeed);
        return Location >= TrackLength;
    }
}