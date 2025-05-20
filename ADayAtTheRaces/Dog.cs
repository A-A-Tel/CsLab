namespace ADayAtTheRaces;

public class Dog
{
    private const int MinSpeed = 5;
    private const int MaxSpeed = 20;

    public int Distance { get; private set; } = 0;
    
    private readonly Random _random = new Random();
    
    
    public string Id { get; }

    public Dog(string id)
    {
        Id = id;
    }

    public void Run()
    {
        Distance += _random.Next(MinSpeed, MaxSpeed);
    }
} 
