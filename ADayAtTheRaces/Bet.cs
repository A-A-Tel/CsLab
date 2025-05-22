using System.Globalization;

namespace ADayAtTheRaces;

public class Bet
{
    private const int BetMultiplier = 0;
    
    public int Amount;
    public int Dog;
    public Guy Bettor;

    public Bet(Guy bettor)
    {
        Bettor = bettor;
    }

    public string GetDescription()
    {
        return Amount == 0
            ? $"{Bettor.Name} has not placed a bet."
            : $"{Bettor.Name} has placed a bet of {Amount} on dog number {Dog}.";
    }

    public int PayOut(int winner)
    {
        return winner == Dog ? Amount * BetMultiplier : -Amount;
    }
}