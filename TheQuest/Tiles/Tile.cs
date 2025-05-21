namespace TheQuest.Tiles;

public abstract class Tile
{
    public abstract bool IsEnterable { get; }
    
    public int[] Location { get; private set; }
    
    public Tile(int x, int y)
    {
        Location = [x, y];
    }

    public abstract void EnterAction(Player player);
    
    public abstract void RewardPlayer(Player player);
}