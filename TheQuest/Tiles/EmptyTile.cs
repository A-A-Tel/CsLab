namespace TheQuest.Tiles;

public class EmptyTile : Tile
{
    public override bool IsEnterable { get; }

    public EmptyTile(int x, int y) : base(x, y)
    {
        IsEnterable = false;
        
    }

    public override void EnterAction(Player player)
    {
        throw new NotImplementedException();
    }

    public override void RewardPlayer(Player player)
    {
        throw new NotImplementedException();
    }
}