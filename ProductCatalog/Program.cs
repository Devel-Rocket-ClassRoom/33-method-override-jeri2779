using System;

// README.md를 읽고 코드를 작성하세요.

Product[] prd = new Product[]
{
      new Electronic{Name = "노트북", Price = 1500000, Warranty = 24},
      new Clothing{Name = "청바지", Price = 89000, Size = "M"},
      new Food{Name = "우유", Price = 3500, ExpirationDate = new DateTime (2026, 4, 4)}

};

foreach(Product p in prd)//배열에서 하나씩 꺼내서 출력
{
    Console.WriteLine(p.ToString());//Tostring으로 p의 정보를 출력
    p.GetDescription();//각 제품의 설명을 출력
    Console.WriteLine();
}
class Product
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name} - ₩{Price:N0}";
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
        return $"{Name} - ₩{Price:N0} (보증: [{Warranty}]개월)";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 전자기기입니다. 취급에 주의하세요.");
    }
}
class Clothing : Product
{
    public string Size;

    public override string ToString()
    {
        return $"{Name} - ₩{Price:N0}:N0 (사이즈: {Size}) ";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 의류입니다. 세탁 방법을 확인하세요.");
    }
}
class Food : Product
{
    public DateTime ExpirationDate;

    public override string ToString()
    {
        return $"{Name} - ₩[{Price:N0}  (유통기한: {ExpirationDate:yyyy-MM-dd})";
    }
    public override void GetDescription()
    {
        Console.WriteLine("→ 식품입니다. 냉장 보관하세요.");
    }
}


