namespace ADayAtTheRaces;

public class Guy
{
    private int _cash;

    public Guy(string name, int money, int betAmount, string dogId)
    {
        Name = name;
        _cash = money - betAmount;
        Bet = new Bet(this, betAmount, dogId);
    }

    public string Name { get; private set; }

    public Bet Bet { get; private set; }
}