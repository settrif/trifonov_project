using System;


public class Contract
{
    public int number;
    public string insurer;
    public string insurant;
    public string insuranceObject;
    public string territory;
    public double sum;
    public double prize;
    public DateTime begins;
    public DateTime ends;
	public Contract(int n, string s1, string s2, string o, string t, double s, double p, DateTime b, DateTime e)
	{
        number = n;
        insurer = s1;
        insurant = s2;
        insuranceObject = o;
        territory = t;
        sum = s;
        prize = p;
        begins = b;
        ends = e;
	}
    public void GetInfo()
    {
        Console.WriteLine($"Договор № " + number);
        Console.WriteLine($"Страховщик: " + insurer);
        Console.WriteLine($"Страхователь: " + insurant);
        Console.WriteLine($"Территория страхования: " + territory);
        Console.WriteLine($"Сумма страхования: " + sum);
        Console.WriteLine($"Сумма страховой премии: " + prize);
        Console.Write($"Действителен с " + begins);
        Console.WriteLine($" По " + ends);
    }
}
