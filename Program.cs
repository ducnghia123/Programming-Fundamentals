﻿using System.Runtime.CompilerServices;

internal class Program
{
    public static void Main(string[] args)
    {
        baiTap01();
        baiTap02();
        baiTap03();
        baiTap04();
        baiTap05();
        baiTap07();
        baiTap08();
        baiTap09();
        baiTap10();

        Console.ReadLine();

    }

    static void baiTap01()
    {
        Console.Write("Moi ban nhap so dau tien:");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        Console.Write("Moi ban nhap so thu hai:");
        string b = Console.ReadLine();
        int y = Convert.ToInt32(b);
        int z = x + y;
        Console.WriteLine("Tong cua hai so {0}+{1}={2}", x, y, z);
    }

    static void baiTap02()
    {
        Console.Write("Moi ban nhap so dau tien:");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        Console.Write("Moi ban nhap so thu hai:");
        string b = Console.ReadLine();
        int y = Convert.ToInt32(b);
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("So dau tien sau thay doi la: {0}", x);
        Console.WriteLine("So thu hai sau thay doi la: {0}", y);
    }
    static void baiTap03()
    {
        Console.Write("Moi ban nhap so dau tien:");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        Console.Write("Moi ban nhap so thu hai:");
        string b = Console.ReadLine();
        int y = Convert.ToInt32(b);
        int z = x * y;
        Console.WriteLine("Tich cua hai so {0}*{1}={2}", x, y, z);
    }
    static void baiTap04()
    {
        Console.Write("Hay nhap so feet ban muon doi sang met:");
        string a = Console.ReadLine();
        double x = Convert.ToDouble(a);
        double y = x / 3.28;
        Console.WriteLine("{0} feet bang {1} met.", x, y);
    }
    static void baiTap05()
    {
        Console.Write("Hay nhap so do Celcius ban muon doi sang Fahrenheit:");
        string a = Console.ReadLine();
        double doC = Convert.ToDouble(a);
        double doF = (doC * 9 / 5) + 32;
        Console.WriteLine("{0} Celcius bang {1} Fahrenheit.", doC, doF);

        Console.Write("Hay nhap so do Fahrenheit ban muon doi sang Celcius:");
        string b = Console.ReadLine();
        double Fahrenheit = Convert.ToDouble(b);
        double Celcius = (Fahrenheit - 32) * 5 / 9;
        Console.WriteLine("{0} Fahrenheit bang {1} Celcius.", Fahrenheit, Celcius);
    }
    static void baiTap07()
    {
        Console.Write("Moi ban nhap ki tu muon doc: ");
        int a = Console.Read();
        Console.WriteLine("ASCii value is: {0}", a);
    }
    static void baiTap08()
    {
        Console.Write("Moi ban nhap ban kinh r: ");
        string a = Console.ReadLine();
        float r = Convert.ToSingle(a);
        float area = r * r;
        Console.WriteLine("Dien tich hinh tron la: {0}", Math.Round(area * Math.PI));
    }
    static void baiTap09()
    {
        Console.Write("Moi ban nhap canh hinh vuong x: ");
        string a = Console.ReadLine();
        float x = Convert.ToSingle(a);
        float area = x * x;
        Console.WriteLine("Dien tich hinh vuong la: {0}", Math.Round(area));
    }
    static void baiTap10()
    {
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);
        Console.WriteLine("This year is: {0}", dateTime.Year);
        Console.WriteLine("Today is: the {0}th of {1} and {2}", dateTime.Day, dateTime.Month, dateTime.DayOfWeek);
    }
}