using System;
using System.IO;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

// README.md를 읽고 코드를 작성하세요.

Vehicle[] vehi = new Vehicle[]
{
    new Car("스포츠카"),
    new AirPlane("보잉747"),
    new Boat("요트")
};
foreach(Vehicle v in vehi)
{
    v.Move();
}
class Vehicle
{
    public string Name { get; protected set; }
    public int Speed { get; protected set; }

    public virtual void Move()
    {
        Console.WriteLine($"[{Name}]이(가) 이동합니다. 속도: [{Speed}]km/h");
    }

}

class Car : Vehicle
{
    public int Speed { get; protected set; } = 120;

    public Car(string name)
    {
        Name = name;
        
    }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}
class AirPlane : Vehicle
{
    public int Speed { get; protected set; } = 900;
    public AirPlane(string name)
    {
            Name = name;

    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}]m/h");
    }
}
class Boat : Vehicle
{
    public int Speed { get; protected set; } = 60;

    public Boat(string name)
    {
        Name = name;

    }

    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}

