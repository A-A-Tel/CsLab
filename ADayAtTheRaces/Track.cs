using System.Collections;

namespace ADayAtTheRaces;

using System.Timers;

public class Track
{
    private readonly Timer _timer = new(1000);

    private readonly Greyhound[] _dogs;
    private readonly Guy[] _guys;

    public Track(Greyhound[] dogs, Guy[] guys)
    {
        _dogs = dogs;
        _guys = guys;

        _timer.Elapsed += CycleDogs;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    public void StartRace()
    {
        Console.WriteLine("Starting race...");
        _timer.Start();
        
        while(_timer.Enabled) Console.ReadLine();
    }

    private void CycleDogs(object? source, ElapsedEventArgs? e)
    {
        Console.WriteLine("-------------------------");
        foreach (Greyhound dog in _dogs)
        {
            if (dog.Run())
            {
                StopRace(dog);
                break;
            }
            Console.WriteLine($"Dog {dog.Id}: {dog.Location}/{Greyhound.TrackLength}");
        }
    }

    private void StopRace(Greyhound dog)
    {
        _timer.Stop();
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Dog {dog.Id} has won the Race! ({dog.Location}/{Greyhound.TrackLength})");

        foreach (Guy guy in _guys)
        {
            guy.Collect(dog.Id);
        }
    }
}