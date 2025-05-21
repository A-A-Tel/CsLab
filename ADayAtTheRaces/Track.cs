using System.Collections;

namespace ADayAtTheRaces;

using System.Timers;

public class Track
{
    private const int TrackLength = 250;

    private readonly Timer _timer = new(1000);

    private readonly Dog[] _dogs;
    private readonly Guy[] _guys;

    public Track(Dog[] dogs, Guy[] guys)
    {
        _dogs = dogs;
        _guys = guys;

        _timer.Elapsed += CycleDogs;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    public void StartRace()
    {
        Console.WriteLine("Starting race, input any key to stop the program.");
        _timer.Start();
        Console.ReadLine();
    }

    private void CycleDogs(object? source, ElapsedEventArgs? e)
    {
        bool hasWon = false;
        ArrayList wonDogs = new();

        Console.WriteLine("--------------------------");
        foreach (var dog in _dogs)
        {
            dog.Run();
            Console.WriteLine($"Dog {dog.Id}: {dog.Distance}/{TrackLength}");

            if (dog.Distance < TrackLength) continue;
            
            hasWon = true;
            wonDogs.Add(dog);
        }

        if (!hasWon) return;
        Console.WriteLine("--------------------------");
        _timer.Stop();

        // Ik weet dat u dit niet leuk vind, maar ik was gewoon nieuwsgierig of dit zou werken of niet.
        foreach (var guy in _guys) foreach (Dog dog in wonDogs) guy.Bet.Payout(dog);
    }

    private void StopRace(ArrayList dogs)
    {
        
    }
}