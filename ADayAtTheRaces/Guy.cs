namespace ADayAtTheRaces;

public class Guy
{
    public string Name { get; private set; }

    public Bet Bet { get; private set; }
    private int _money;

    public Guy(string name, int money, int betAmount, string dogId)
    {
        Name = name;
        _money = money - betAmount;
        Bet = new Bet(this, betAmount, dogId);
    }

    public void GiveMoney(int amount)
    {
        _money += amount;
    }
}