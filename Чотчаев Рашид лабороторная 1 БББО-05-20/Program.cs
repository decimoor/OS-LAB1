using System;
using System.IO;
using System.Text;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  class Program
  {
     static int GetInput(string output)
    {
      bool goodInput = true;
      int mode = 1;
      do
      {
        try
        {
          Console.Write(output);
          mode = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
          Console.WriteLine("Неверный ввод");
          goodInput = false;
        }
      }
      while (!goodInput && mode >= 1 && mode <= 5);
      
      return mode;
    }

    static void Program1()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();

      foreach(DriveInfo drive in drives)
      {
        Console.WriteLine($"Название: {drive.Name} байт.");
        Console.WriteLine($"Общий размер: {drive.TotalSize} байт.");
        Console.WriteLine($"Тип файловой системы: {drive.DriveFormat} байт.");
      }
    }

    static void Program2()
    {
      Console.WriteLine("Введите строку");
      string toWrite = Console.ReadLine();
      try
      {
        using (FileStream fs = File.Create("newfile.txt"))
        {
          byte[] info = new UTF8Encoding(true).GetBytes(toWrite);
          fs.Write(info, 0, info.Length);
        }

        using (StreamReader sr = File.OpenText("newfile.txt"))
        {
          string s = "";
          while (( s = sr.ReadLine()) != null)
          {
            Console.WriteLine(s);
          }
        }
      }

      catch (Exception ex)
      {
        Console.WriteLine("Что-то пошло не так но я вам не скажу");
      }
    }

    static void Program3()
    {
      Console.WriteLine("This is program3");
    }

    static void Program4()
    {
      Console.WriteLine("This is program4");
    }

    static void Program5()
    {
      Console.WriteLine("This is program5");
    }

    static void Main(string[] args)
    {
      int mode = GetInput("Введите режим работы от 1-5: ");
      switch(mode)
      {
        case 1:
          Program1();
          break;
        case 2:
          Program2();
          break;
        case 3:
          Program3();
          break;
        case 4:
          Program4();
          break;
        case 5:
          Program5();
          break;

      }


    }
  }
}
