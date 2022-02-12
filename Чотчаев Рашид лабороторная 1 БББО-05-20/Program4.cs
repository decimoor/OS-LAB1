using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program4
  {
    static private string fileName = "XmlDocument.xml";

    static private void AddUser(string name, string age, string favAnime)
    {
      using (FileStream fs = File.Create(fileName))
      { }

      XElement xUser = new XElement("user");
      xUser.Add(new XAttribute("name", name));

      XElement xAge = new XElement("age", age);
      xUser.Add(xAge);

      XElement xFavAnime = new XElement("fav-anime", favAnime);
      xUser.Add(xFavAnime);

      XDocument xDoc = new XDocument(new XElement("users", xUser));
      xDoc.Save(fileName);
    }

    static private void RedLines(string filename)
    {
      using (StreamReader sr = File.OpenText(filename))
      {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
          Console.WriteLine(s);
        }
      }
    }

    
    static public void Run()
    {
      Console.WriteLine("Добавление пользователей в систему");
      Console.Write("Введите имя ползователя: ");
      string name = Console.ReadLine();
      Console.Write("Введите возраст пользователя: ");
      string age = Console.ReadLine();
      Console.Write("Введите ваше любимое аниме: ");
      string favAnime = Console.ReadLine();

      AddUser(name, age, favAnime);
      RedLines(fileName);

      Program3.SimulateProccess("Удаление файла", 3, 1);
      Console.WriteLine();
      File.Delete(fileName);
      
    }
  }
}
