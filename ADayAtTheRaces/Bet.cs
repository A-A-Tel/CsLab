namespace ADayAtTheRaces;

public readonly struct Bet(Guy guy, int amount, string dogId)
{
    private const int AmountMultiplier = 2;

    public void Payout(Dog? dog)
    {
        if (dog is null) return;
        
        if (dog.Id != dogId) return;
        
        int winAmount = amount * AmountMultiplier;
        Console.WriteLine
        (
            $"{dog.Id} has won the race, making {guy.Name} the winner. He has won {winAmount}."
        );
        guy.GiveMoney(winAmount);
    }
}