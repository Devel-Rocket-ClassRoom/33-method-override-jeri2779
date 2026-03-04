using System;

class Child0 : Parent0
{
    public new void Say()
    {
        Console.WriteLine("자식_안녕하세요.");
    }
    public new void Run()
    {
        Console.WriteLine("자식_달리다.");
    }
    public override void Walk()
    {
        Console.WriteLine("자식_걷다.");
    }
}