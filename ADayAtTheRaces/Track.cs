using System.Timers;
using Timer = System.Timers.Timer;

namespace ADayAtTheRaces;

public class Track
{
    private const int TrackLength = 250;
    private readonly Guy[] _guys;

    private readonly Greyhound[] _hounds;

    private readonly Timer _timer = new(1000);

    public Track(Greyhound[] hounds, Guy[] guys)
    {
        _hounds = hounds;
        _guys = guys;

        _timer.Elapsed += CycleHounds;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    public void StartRace()
    {
        Console.WriteLine("Starting race...");
        _timer.Start();

        foreach (Greyhound hound in _hounds) hound.ResetDistance();

        while (_timer.Enabled) Console.ReadLine();
    }

    private void CycleHounds(object? source, ElapsedEventArgs? e)
    {
        bool hasWon = false;

        Console.WriteLine("--------------------------");
        foreach (Greyhound hound in _hounds)
        {
            hound.Run();
            Console.WriteLine($"Dog {hound.Id}: {hound.Distance}/{TrackLength}");

            if (hound.Distance < TrackLength) continue;

            hasWon = true;
            if (hasWon) StopRace(hound);
            break;
        }
    }

    private void StopRace(Greyhound wonHound)
    {
        _timer.Stop();

        Console.WriteLine();

        foreach (Guy guy in _guys) guy.Bet.Payout(wonHound);

        Console.WriteLine("Press any key to stop.");
    }
}