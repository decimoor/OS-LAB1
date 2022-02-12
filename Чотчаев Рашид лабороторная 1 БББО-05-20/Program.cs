using System;
using System.IO;
using System.Text;
using System.Text.Json;


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
          if (mode < 1 || mode > 5)
          {
            throw new ArgumentException();
          }
          goodInput = true;
        }
        catch (FormatException)
        {
          Console.WriteLine("Неверный ввод");
          goodInput = false;
        }
        catch (ArgumentException)
        {
          Console.WriteLine("Режимов всего 5 оло");
          goodInput = false;
        }
      }
      while (!goodInput);
      
      return mode;
    }

    static void Main(string[] args)
    {
      while (true)
      {


        int mode = GetInput("Введите режим работы от 1-5: ");
        switch (mode)
        {
          case 1:
            Program1.Run();
            break;
          case 2:
            Program2.Run();
            break;
          case 3:
            Program3.Run();
            break;
          case 4:
            Program4.Run();
            break;
          case 5:
            Program5.Run();
            break;

        }
      }


    }
  }
}
