using System;
// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("## 1. virtual과 override 키워드");
Parent parent = new Parent();
parent.Work();

Child child = new Child();
child.Work();


Console.WriteLine();
Console.WriteLine("### 1-2. 다형성과 오버라이드");

Animal animal = new Animal();
animal.Eat();
Animal cat = new Cat();
cat.Eat();

Console.WriteLine();

Console.WriteLine("## 2. new vs override 동작 비교");

Child0 child0 = new Child0();
child0.Say();
child0.Run();
child0.Walk();
Console.WriteLine();
Parent0 parent1 = child0;
parent1.Say();
parent1.Run();
parent1.Walk();

Console.WriteLine();
Console.WriteLine("### 3-1. 오버로드");

Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(1, 2)); ;
Console.WriteLine(calculator.Add(2.5, 1.5));
Console.WriteLine(calculator.Add(1, 2, 3));

Console.WriteLine();
Console.WriteLine("### 3-2. 오버라이드");

Animal2 anim2 = new Animal2();
anim2.Speak();
Animal2 dog = new Dog2();
dog.Speak();
Animal2 cat2 = new Cat2();
cat2.Speak();

Console.WriteLine();
Console.WriteLine("### 4-1. base 키워드 기본");

Child1 chi1 = new Child1();
chi1.Greet();

Console.WriteLine();
Console.WriteLine("### 4-2. base 키워드 활용");


new Parent2().Work();
new child2().Work();
new GrandChild().Work();


//Console.WriteLine();
//Console.WriteLine("## 5. 메서드 오버라이드 봉인 (sealed)");
//new Parent3().Work();
//new Child3().Work();
//new GrandChild0().Work();
//new GrandChild0().Play();   

////class Parent3
////{
////    public virtual void Work()
////    {
////        Console.WriteLine("프로그래머");
////    }
////}

////class Child3 : Parent3
////{
////    public sealed override void Work()
////    {
////        base.Work();
////    }
////}

////class GrandChild0 : Child3
////{
////    public void Play()
////    {
////        Console.WriteLine("프로게이머");
////    }
////}
//

Console.WriteLine(  );

Console.WriteLine("## 6. ToString() 메서드 오버라이드");
Person person = new Person();
Console.WriteLine(person);
Console.WriteLine(person.ToString());


Console.WriteLine();
Console.WriteLine("### 6-2. ToString() 오버라이드");

Person0 pr = new Person0("박용준");
Console.WriteLine(pr);


Console.WriteLine();
Console.WriteLine("### 6-3. 게임 캐릭터 예제");

Character hero = new Character("용사", 10, 100);
Character mage = new Character("마법사", 8, 70);
Console.WriteLine(hero);
Console.WriteLine(mage);

Console.WriteLine();
Console.WriteLine("### 7-1. RPG 캐릭터 시스템");

Character0 warrior = new Warrior("전사");
Character0 mage1 = new Mage("마법사");
Character0 archer = new Archer("궁수");

// 정보 출력
Console.WriteLine(warrior);
Console.WriteLine(mage1);
Console.WriteLine(archer);
Console.WriteLine();
// 공격 실행
warrior.Attack();
mage1.Attack();
archer.Attack();

class Character0
{
    public string Name;
    public int AttackPower;
    public Character0(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;  
    }


    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다. 대미지: {AttackPower}");
    }

    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}

class Warrior : Character0
{
    public Warrior(string  name) : base(name, 50) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}
class Mage : Character0
{
    public Mage(string name) : base(name, 60) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower}");
    }
}

class Archer : Character0
{
    public Archer(string name) : base(name, 40) { }

    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}

