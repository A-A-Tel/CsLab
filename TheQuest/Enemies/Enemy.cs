namespace TheQuest.Enemies;

public abstract class Enemy
{
    
    public int Health { get; private set; }
    public abstract int MaxHealth { get; }

    protected Enemy(int health, int maxHealth)
    {
        Health = health;
        maxHealth = maxHealth;
    }
    
    public abstract void Attack(Player player);
    public abstract void TakeDamage(Player player);
}