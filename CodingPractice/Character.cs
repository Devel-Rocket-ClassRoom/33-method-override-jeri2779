class Character
{
    public string name;
    public int Level;
    public int Health;

    public Character(string name, int level, int health)
    {
        this.name = name;
        Level = level;
        Health = health;
    }

    public override string ToString()
    {
        return $"[{name}] Lv.{Level} HP:{Health}";
    }
}

