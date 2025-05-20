namespace ADayAtTheRaces;

using System.Timers;



public class Track
{
    private const int TrackLength = 500;

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

    private void CycleDogs(object? source, ElapsedEventArgs? e)
    {
        bool hasWon = false;
        Dog[] wonDogs = new Dog[_dogs.Length];
        
        foreach (var dog in _dogs)
        {
            dog.Run();

            if (dog.Distance >= TrackLength)
            {
                hasWon = true;
            }
        }

        if (hasWon)
        {
            _timer.Stop();

            foreach (var guy in _guys)
            {
                foreach (var dog in wonDogs)
                {
                    guy.Bet.Payout(dog);
                }
            }
        }
    }

    public void StartRace()
    {
        Console.WriteLine("Starting race");
        _timer.Start();
    }
}