namespace TheQuest;

public class Player
{
    private const int MaxHealth = 100;
    
    public string Name { get; }
    
    public int Health { get; private set; }

    public Player(string name)
    {
        Name = name;
    }
}