using System;
using System.Runtime.InteropServices;

internal class Program
{
    public static void Main(string[] args)
    {
        //baiTap01();
        //baiTap02();
        //baiTap03();
        //baiTap04();
        //baiTap05();
        //baiTap06();
        //baiTap07_1();
        //baiTap07_2();
        //baiTap07_3();
        //baiTap08();
        //baiTap09();
        //baiTap10();
    }

    static void baiTap01()
    {
        Console.Write("Moi ban nhap 1 so: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("Day la so chan.");
        }
        else
        {
            Console.WriteLine("Day la so le.");
        }
    }
    static void baiTap02()
    {
        Console.WriteLine("Nhap 3 so x, y, z: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("x la so lon nhat.");
            }
            else
            {
                Console.WriteLine("z la so lon nhat.");
            }
        }
        else
        
            if (y > z) 
            {
                Console.WriteLine("y la so lon nhat.");
            }
            else 
            {
                Console.WriteLine("z la so lon nhat");
            }
        
    }
    static void baiTap03()
    {
        Console.Write("Moi ban nhap toa do x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Moi ban nhap toa do y:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Toa do cua ban la: ({0},{1})", x, y);

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Toa do cua ban thuoc goc phan tu thu nhat.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Toa do cua ban thuoc goc phan tu thu tu.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Toa do cua ban thuoc goc phan tu thu hai.");
        }
        else
            Console.WriteLine("Toa do cua ban thuoc goc phan tu thu ba.");
    }
    static void baiTap04()
    {
        Console.Write("Moi ban nhap vao do dai canh a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Moi ban nhap vao do dai canh b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Moi ban nhap vao do dai canh c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Day la tam giac deu.");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Day la tam giac can.");
        }
        else
            Console.WriteLine("Day la tam giac thuong.");
    }
    static void baiTap05()
    {
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Moi ban nhap 1 so: ");
            int x = Convert.ToInt32(Console.ReadLine());
            sum += x;
        }
        int average = sum / 10;
        Console.WriteLine("Tong 10 so la: {0}", sum);
        Console.WriteLine("Trung binh 10 so la khoang: {0}", average);
    }
    static void baiTap06()
    {
        Console.Write("Moi ban nhap 1 so: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} * {a} = "+(i*a));
        }
    }
    static void baiTap07_1()
    {
        Console.Write("Moi ban nhap 1 so: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.Write("\n");
        }

    }
    static void baiTap07_2()
    {
        Console.Write("Moi ban nhap 1 so: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 1;
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ",b );
                b++;    
            }
            Console.Write("\n");
        }
    }
    static void baiTap07_3()
    {
        
        Console.WriteLine("Nhap so dong: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = 1;
        for (int i = 1; i <= a; i++)
        {
            for (int c = 1; c <= a - i; c++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{b} ");
                b++;
            }
            Console.Write($"\n");
        }
    }
    static void baiTap08()
    {
        double sum = 0.0;
        Console.Write("Nhap so x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            if (i < x)
            {
                Console.Write($"1/{i} + ");
                sum += (1 / (float)i);
            }
            if (i == x)
            {
                sum +=( 1 / (float)i);
                Console.WriteLine($"1/{i} ");
            }
        }
        Console.WriteLine($"Tong cua day la: {sum}");
    }
    static void baiTap09()
    {
        Console.Write("Moi ban nhap 1 so lon hon 0:");
        int sum=0;
        int soNhapVao = Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine("So ban vua nhap la: {0}",soNhapVao);
        for (int i = 1; i <= (soNhapVao - 1); i++)
        {
            if (soNhapVao % i == 0)
            {
                sum += i;
            }
        }
        if (sum == soNhapVao)
        {
            Console.WriteLine("{0} la so hoan hao.", soNhapVao);
        }
        else Console.WriteLine("{0} khong phai so hoan hao",soNhapVao);
    }
    static void baiTap10()
    {
        int uocSo = 0;
        Console.Write("Hay nhap 1 so: ");
        int x = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                uocSo++;
            }
        }
        if (uocSo == 2)
        {
            Console.WriteLine("Day la so nguyen to.");
        }
        else
            Console.WriteLine("Day khong phai so nguyen to.");

    }

}
