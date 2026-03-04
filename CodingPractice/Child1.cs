using System;

class Child1 : Parent1
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다");
    }
}
