using TheQuest.Tiles;

namespace TheQuest;

public class World
{
    public Tile[][] Tiles { get; }

    public World(int width, int height)
    {
        Tile[][] tiles = new Tile[width][];
        for (int i = 0; i < width; i++)
        {
            tiles[i] = new Tile[height];
        }
        Tiles = tiles;
    }
}