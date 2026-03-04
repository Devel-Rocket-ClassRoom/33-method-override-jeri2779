using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 악기 연주회 ===");

Instrument[] instruments = new Instrument[]
{
    new Piano("피아노"),
    new Guitar("기타"),
    new Drum("드럼")
};
foreach (var instrument in instruments)
{
    instrument.Tune();
    instrument.Play();
    Console.WriteLine();
}


class Instrument
{
    public string _name;
    public Instrument(string name)
    {
        _name = name;
    }   
    public virtual void Play()
    {
        Console.WriteLine($"[{_name}]을(를) 연주합니다");
    }
    public virtual void Tune()
    {
        Console.WriteLine($"[{_name}]을(를) 조율합니다");
    }

}

class Piano : Instrument
{
    public Piano(string name) : base(name) { }

    public override void Play()
    {
        Console.WriteLine("🎹 피아노 건반을 누릅니다 - 딩동댕~");
    }
     
    public override void Tune()
    {
        Console.WriteLine("피아노 현을 조율합니다");
    }

}

class Guitar : Instrument
{
    public Guitar(string name) : base(name)
    {
    }

    public override void Play()
    {
        Console.WriteLine("🎸 기타 줄을 튕깁니다 - 통통통~");
    }

    public override void Tune()
    {
        Console.WriteLine("기타 줄을 조율합니다");
    }
}

class Drum : Instrument
{
    public Drum(string name) : base(name)
    {
    }

    public override void Play()
    {
        Console.WriteLine("🥁 드럼을 두드립니다 - 둥둥둥~");
    }

   
}
 
