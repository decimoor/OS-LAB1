using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Timers;
using System.Threading;
using System.IO;


namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program3
  {
    private static readonly int TIME_TO_CREATE_GHOUL_CLASS_INSTANCE = 3;

    static private void SimulateProccess(string firstToWrite, int howManyDots, float loadingLenght)
    {
      DateTime now = DateTime.Now;

      int dotCount = 0;
      Console.Write(firstToWrite);
      while (DateTime.Now - now < TimeSpan.FromSeconds(loadingLenght))
      {

        for (int i = 0; i < dotCount % (howManyDots + 1); i++)
        {
          Console.Write("\b \b");
        }

        dotCount++;
        for (int i = 0; i < dotCount % (howManyDots + 1); i++)
        {
          Console.Write(".");
        }
        Thread.Sleep(300);
      }
    }
    static public void Run()
    {
      SimulateProccess("Creating Ghoul classe's instance", 3, TIME_TO_CREATE_GHOUL_CLASS_INSTANCE);
      Console.WriteLine();

      Ghoul kaneki = new Ghoul("Ken Kaneki", new string[3]{ "Eyepatch", "Centupede", "Black Reaper" }, new string[2]{"Artificial", "Human"}, 18, "Male", new DateTime(19, 12, 20), 169, 55, "AB", new string[5]{"Kamii University", "Anteiku", "Anti-Aogiri", "Kaneki's group", "Aogiri Tree"});

      string jsonString = JsonSerializer.Serialize(kaneki);

      SimulateProccess("Creating file", 3, 1);
      Console.WriteLine();
      SimulateProccess("Searialising object and writing to Ghoul.txt", 3, 1);
      Console.WriteLine();
      Program2.WriteStringToFileAndRead("Ghoul.txt", jsonString);
      SimulateProccess("Writing Done!", 0, 0.5f);
      Console.WriteLine();
      SimulateProccess("Deleating file", 3, 2);
      Console.WriteLine();
      File.Delete("Ghoul.txt");
      Console.WriteLine("Deleating Done!");
      

    }
  }

  internal class Ghoul
  {
    //properties
    public string _name { get; set; }
    public string[] _alias { get; set; }
    public string[] _species { get; set; }
    public byte _age { get; set; }
    public string _gender { get; set; }
    public DateTime _birthday { get; set; }
    public float _height { get; set; }
    public float _weight { get; set; }
    public string _bloodType { get; set; }
    public string[] _affiliations { get; set; }

    //constructor
    public Ghoul(string name, string[] alias, string[] species, byte age, string gender, DateTime birthday, float height, float weight, string bloodType, string[] affiliations)
    {
      _name = name;
      _alias = alias;
       _species = species;
      _age = age;
      _gender = gender;
      _birthday = birthday;
      _height = height;
      _weight = weight;
      _bloodType = bloodType;
      _affiliations = affiliations;
    }

  }

}
