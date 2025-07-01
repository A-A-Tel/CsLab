namespace ADayAtTheRaces;

public class Bet
{
    private const int AmountMultiplier = 2;
    private readonly int _amount;
    private readonly string _dogId;
    private readonly Guy _guy;

    public Bet(Guy guy, int amount, string dogId)
    {
        _guy = guy;
        _amount = amount;
        _dogId = dogId;
    }

    public string GetDescription()
    {
        return _amount == 0
            ? $"{_guy.Name} has not placed a bet."
            : $"{_guy.Name} has placed a bet of {_amount} on {_dogId}";
    }

    public int Payout(Greyhound dog)
    {
        if (dog.Id != _dogId) return 0;

        int winAmount = _amount * AmountMultiplier;

        Console.WriteLine("--------------------------");
        Console.WriteLine($"{dog.Id} has won the race, making {_guy.Name} the winner. He has won {winAmount}.");
        return winAmount;
    }
}