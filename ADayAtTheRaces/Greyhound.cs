namespace ADayAtTheRaces;

public class Greyhound
{
    private const int MinSpeed = 5;
    private const int MaxSpeed = 20;

    private readonly Random _random = new();

    public Greyhound(string id)
    {
        Id = id;
    }

    public int Distance { get; private set; }

    public string Id { get; }

    public void Run()
    {
        Distance += _random.Next(MinSpeed, MaxSpeed);
    }

    public void ResetDistance()
    {
        Distance = 0;
    }
}