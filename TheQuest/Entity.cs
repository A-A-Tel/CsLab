using Microsoft.VisualBasic.CompilerServices;

namespace TheQuest;

public abstract class Entity
{
    public string Name { get; }
    
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    
    public int[] Location { get; protected set; }

    protected Entity(string name, int[] location)
    {
        Name = name;
        Location = location;
    }
    
    
}