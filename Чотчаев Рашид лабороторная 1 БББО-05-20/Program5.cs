using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program5
  {
    static public string directoryPath = "Folder";
    static public string archivePath = "Folder.zip";
    static public void Run()
    {
      try
      {
        ZipFile.CreateFromDirectory(directoryPath, archivePath);
      }
      catch (IOException e)
      {
        Console.WriteLine("Такой архив уже существует");
      }

      using (ZipArchive zipArchive = ZipFile.Open(archivePath, ZipArchiveMode.Update))
      {
        const string filePath = @"C:\\Users\\star platinum\\Downloads\\file.txt";
        const string fileName = "brothers.txt";

        zipArchive.CreateEntryFromFile(filePath, fileName);
       }
    }
  }
}
