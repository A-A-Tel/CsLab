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
        Console.WriteLine("Starting race...");
        _timer.Start();
        
        while(_timer.Enabled) Console.ReadLine();
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

        if (hasWon) StopRace(wonDogs);

    }

    private void StopRace(ArrayList dogs)
    {
        _timer.Stop();

        Dog? wonDog = null;
        int wonDistance = 0;

        foreach (Dog dog in dogs)
        {
            if (dog.Distance > wonDistance)
            {
                wonDistance = dog.Distance;
                wonDog = dog;
            }
        }

        Console.WriteLine();
        
        // Ik weet dat u dit niet leuk vind, maar ik was gewoon nieuwsgierig of dit zou werken of niet.
        foreach (var guy in _guys) guy.Bet.Payout(wonDog);

        Console.WriteLine("Press any key to stop.");
    }
}