using System.Windows.Forms;

namespace ADayAtTheRaces;

public class Greyhound
{
    public int StartingPosition;
    public int RacetrackLength
    public int Location { get; private set; } = 0;
    private Random _random = new Random();

    public bool Run()
    {
        // Move forward either 1, 2, 3 or 4 spaces at random
        // Update the position of my PictureBox on the form like this:
        // MyPictureBox.Left = StartingPosition + Location;
        // Return true if I won the race
    }

    public void TakeStartingPosition()
    {
        // Reset my location to 0 and my PictureBox to starting position
    }
}