namespace TheQuest.Buffs;

public abstract class AttackBuff : Buff
{
    public abstract int TurnDuration { get; set; }
}