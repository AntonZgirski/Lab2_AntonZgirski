using System;
using System.Text;

namespace Lab2_AntonZgirski
{
  class Program
  {
    static void Main()
    {
      // №0
      for (int i = 0; i <= 99; i++)
      {
        if ((i != 0) & ((i % 2) != 0)) Console.WriteLine(i);
      }

      // №1
      for (int i = 5; i > 0; i--)
      {
        Console.WriteLine(i);
      }

      SumOfNum();
      FoundInArgs();
      MinMaxInArgs();
      PrintTwoArg();
      PrintFibo();
      RemoveArg();
      SortName();

      //№2
      void SumOfNum()
      {
        Scanner scan = new Scanner();
        while (true)
        {
          int numsum = 0;
          char ch;
          int num;
          string s;
          Console.Write("Введите любое положительное число, кроме 0: ");
          s = scan.ReadStr();
          try
          {
            num = Convert.ToInt32(s);
            if (num > 0)
            {
              for (int i = 1; i <= num; i++)
              {
                numsum += i;
              }
              Console.WriteLine($"Результат: {numsum}");
            }
            else if (num <= 0) Console.WriteLine("Вы ввели отрицательное число, либо 0. Попробуйте еще раз.");
          }
          catch
          {
            ch = Convert.ToChar(s[0]);
            if (ch == 'Y')
            {
              Console.WriteLine("Конец работы.");
              break;
            }
            else if (ch != 'Y') Console.WriteLine("Вы ввели не число. Попробуйте еще раз.");
          }
        }
      }

      // №3
      void FoundInArgs()
      {
        Scanner scan = new Scanner();
        int[] mass = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine();
        Console.Write("Введите число: ");
        int found = scan.ReadInt();
        if (Array.IndexOf(mass, found) != -1) Console.WriteLine($"Число {found} входит в заданную последовательность.");
        else Console.WriteLine($"Число {found} не входит в заданную последовательность.");
      }

      // №4
      void MinMaxInArgs()
      {
        Scanner scan = new Scanner();
        Console.WriteLine();
        Console.Write("Введите количество элементов массива: ");
        int size = scan.ReadInt();
        int[] mass = new int[size];
        var rnd = new Random();
        for (int i = 0; i < size; i++)
        {
          mass[i] = rnd.Next(-100, 100);
        }

        scan.PrintMas(size, mass);        

        var max = MaxAr(mass);
        Console.WriteLine($"max = {max}");

        var min = MinAr(mass);
        Console.WriteLine($"min = {min}");

        var arifm = GetArifm(mass);
        Console.WriteLine($"arifm = {arifm}");

        double GetArifm(int[] mass)
        {
          int sum = 0;
          foreach (var zeroDem in mass)
          {
            sum += zeroDem;
          }

          return sum / mass.Length;
        }

        double MaxAr(int[] mass)
        {
          int max = mass[0];
          foreach (var ink in mass)
          {
            if (ink > max) max = ink;
          }

          return max;
        }

        double MinAr(int[] mass)
        {
          int min = mass[0];
          foreach (var ink in mass)
          {
            if (ink < min) min = ink;
          }

          return min;
        }
      }

      // №5
      void PrintTwoArg()
      {
        Scanner printmas = new Scanner();
        Console.WriteLine();
        int[] mass = new int[5];
        int[] mass1 = new int[5];
        var rnd = new Random();
        for (int i = 0; i < 5; i++)
        {
          mass[i] = rnd.Next(-100, 100);
        }
        for (int i = 0; i < 5; i++)
        {
          mass1[i] = rnd.Next(-100, 100);
        }

        printmas.PrintMas(5, mass);
        printmas.PrintMas(5, mass1);
      }

      // №6
      void PrintFibo()
      {
        Console.WriteLine();
        Console.Write("Введите количество членов последовательности Фибоначи: ");
        Scanner scan = new Scanner();
        int numfib = scan.ReadInt();
        int[] mass = new int[numfib];
        mass[0] = 0;
        mass[1] = 1;
        for (int i = 2; i < numfib; i++)
        {
          mass[i] = mass[i - 1] + mass[i - 2];
        }

        scan.PrintMas(numfib, mass);
      }

      //№7
      void RemoveArg()
      {
        Console.WriteLine();
        Scanner print = new Scanner();
        int[] mass = new int[27];
        var rnd = new Random();

        for (int i = 0; i < 20; i++)
        {
          mass[i] = rnd.Next(-100, 100);
        }

        print.PrintMas(20, mass);

        for (int i = 0; i < 20; ++i)
        {
          if (i % 2 != 0) mass[i] = 0;
        }

        print.PrintMas(20, mass);
      }


      // №8
      void SortName()
      {
        Console.WriteLine();
        Scanner scan = new Scanner();
        string[] name = new string[5] { "Елена", "Денис", "Антон", "Максим", "Михаил" };
        Array.Sort(name);
        foreach (var num in name)
        {
          Console.Write(num + "\t");
        }
        Console.WriteLine();
      }

      // string
      Console.WriteLine("String");
      string numdoc = "5554-fff-5678-kbG-9F0n";
      string letters, numbers;
      StringBuilder sb1 = new StringBuilder();
      StringBuilder sb2 = new StringBuilder();

      foreach (var num in numdoc)
      {
        if ((Char.IsDigit(num)) & (!Char.IsControl(num))) sb1.Append(num);
        else if ((Char.IsLetter(num)) & (!Char.IsControl(num))) sb2.Append(num);
      }

      letters = sb2.ToString();
      numbers = sb1.ToString();

      PrintNum();
      PrintNumDoc();
      PrintLetLow();
      PrintLetUp();
      FoundABC();
      CheckBegin();
      CheckEnd();

      void PrintNum()
      {
        Console.WriteLine("№1");
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 8; i++)
        {
          if (i == 4)
          {
            str.Append("-");
            str.Append(numbers[i]);
          }
          else str.Append(numbers[i]);
        }
        Console.WriteLine(str);
      }

      void PrintNumDoc()
      {
        Console.WriteLine("№2");
        StringBuilder s = new StringBuilder(numdoc);
        int j = 1;
        for (int i = 0; i < numdoc.Length; i++)
        {

          if (j > 6) break;

          if (Char.IsLetter(s[i]))
          {
            s.Replace(s[i], '*');
            j++;
          }
        }
        Console.WriteLine(s);
      }

      void PrintLetLow()
      {
        StringBuilder sb = new StringBuilder(letters.ToLower());
        sb.Insert(3, '/');
        sb.Insert(7, '/');
        sb.Insert(9, '/');        
        Console.WriteLine("№3\n" + sb.ToString());
      }

      void PrintLetUp()
      {
        StringBuilder sb = new StringBuilder(letters.ToUpper());
        sb.Insert(3, '/');
        sb.Insert(7, '/');
        sb.Insert(9, '/');
        Console.WriteLine("№4\n" + sb.ToString());
      }

      void FoundABC()
      {
        string s = "abc";
        int index = numdoc.IndexOf(s);
        int indexu = numdoc.IndexOf(s.ToUpper());
        if ((index != -1) | (indexu != -1)) Console.WriteLine("№5\nНомер документа содержит последовательность.");
        else Console.WriteLine("№5\nНомер документа не содержит последовательность.");
      }

      void CheckBegin()
      {
        if (numdoc.StartsWith("555")) Console.WriteLine("№6\nНомер документа начинается с последовательности 555");
        else Console.WriteLine("№6\nНомер документа не начинается с последовательности 555");
      }

      void CheckEnd()
      {
        if (numdoc.EndsWith("1a2b")) Console.WriteLine("№7\nНомер документа заканчивается последовательностью 1a2b");
        else Console.WriteLine("№7\nНомер документа не заканчивается последовательностью 1a2b");
      }

    }
  }

  class Scanner
  {
    public string readstr;
    public int readint;
    public string ReadStr()
    {
      readstr = Console.ReadLine();
      return readstr;
    }
    public int ReadInt()
    {
      readint = Convert.ToInt32(Console.ReadLine());
      return readint;
    }
    public void PrintMas(int numline, int[] args)
    {
      for (int i = 0; i < numline; i++)
      {
        Console.Write(args[i] + "\t ");
      }
      Console.WriteLine();
    }

  }
}