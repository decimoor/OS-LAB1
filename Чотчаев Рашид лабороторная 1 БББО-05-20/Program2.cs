using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program2
  {
    static public void WriteStringToFileAndRead(string fileName, string str)
    {
      try
      {
        using (FileStream fs = File.Create(fileName))
        {
          byte[] info = new UTF8Encoding(true).GetBytes(str);
          fs.Write(info, 0, info.Length);
        }

        using (StreamReader sr = File.OpenText(fileName))
        {
          string s = "";
          while ((s = sr.ReadLine()) != null)
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
    static public void Run()
    {
      Console.WriteLine("Введите строку");
      string toWrite = Console.ReadLine();
      WriteStringToFileAndRead(toWrite, "newFile.txt");
    }
  }
}
