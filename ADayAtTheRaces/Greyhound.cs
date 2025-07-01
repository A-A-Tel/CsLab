namespace ADayAtTheRaces;

public class Greyhound
{
    
    private const int MinSpeed = 5;
    private const int MaxSpeed = 20;

    public int Id;
    public int Location; 
    public Random Randomizer = new();
    public int TrackLength;

    public Greyhound(int id)
    {
        Id = id;
    }

    public bool Run()
    {
        Location += Randomizer.Next(MinSpeed, MaxSpeed);
        return Location >= TrackLength;
    }
}