namespace ADayAtTheRaces;

public class Guy {
    public string Name; 
    public Bet Bet;
    public int Cash;

    public Guy(string name, int cash)
    {
        Name = name;
        Bet = new Bet(this);
        Cash = cash;
    }

    public void ClearBet()
    {
        Bet.Amount = 0;
    }
    
    public bool PlaceBet(int betAmount, int dogToWin)
    {
        if (betAmount > Cash) return false;

        Bet.Amount = betAmount;
        Bet.Dog = dogToWin;
        
        return true;
    }
    
    public void Collect(int winner) 
    { 
        Bet.PayOut(winner);
    }

    public void PrintBetDescription()
    {
        Console.WriteLine(Bet.GetDescription());
    }
}