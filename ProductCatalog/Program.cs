using System;

// README.md를 읽고 코드를 작성하세요.

Product[] prd = new Product[]
{
      new Electronic{},
      new Clothing{ },
      new Food{ }

};
class Product
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[{Name}] - ₩[{Price}:N0]";
    }

    public virtual void GetDescription()
    {
        Console.WriteLine("");
        }
}

class Electronic : Product
{
    public int Warranty;

    public override string ToString()
    {
        return $"[{Name}] - ₩[{Price}:N0] (보증: [{Warranty}]개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 전자기기입니다. 취급에 주의하세요.");
    }
}
class Clothing : Product
{
    public int Size;

    public override string ToString()
    {
        return $"[{Name}] - ₩[{Price}:N0] (사이즈: {Size}) ";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 의류입니다. 세탁 방법을 확인하세요.");
    }
}
class Food : Product
{
    public int ExpirationDate;

    public override string ToString()
    {
        return $"[{Name}] - ₩[{Price}:N0]  (유통기한: [{ExpirationDate}])";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 식품입니다. 냉장 보관하세요.");
    }
}


