using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Collections;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program5
  {
    static public string directoryPath = "Folder";
    static public string archivePath = "Folder.zip";
    static public string fileName = "file.txt";
    static public string newFile = "newFile.txt";
    static public void Run()
    {
      if(Directory.Exists(directoryPath))
      {
        Directory.Delete(directoryPath);
      }
      
      if(File.Exists(archivePath))
      {
        File.Delete(archivePath);
      }


      Directory.CreateDirectory(directoryPath);
      CreateArchive();
      AddFileToArchive();
      ReArchiveFile();
		}

    static public void DeleteAll()
    {
      File.Delete(archivePath);
      File.Delete(fileName);
    }

    static public void ReArchiveFile()
    {
      using (FileStream fs = new FileStream($@"{archivePath}", FileMode.Open))
      {
        using (ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Read))
        {
          ZipArchiveEntry entry = archive.GetEntry(fileName);
          using (StreamReader sr = new StreamReader(entry.Open()))
          {

            using (StreamWriter sw = new StreamWriter(newFile))
            {
              sw.Write(sr.ReadToEnd());
            }
          }
          Console.WriteLine($"Имя файла: {entry.Name}");
          Console.WriteLine($"Размер файла: {entry.Length}");
          Console.WriteLine($"Расположение файла: {entry.FullName}");
        }
      }
    }
    static public void AddFileToArchive()
    {
      using (FileStream fs = new FileStream($@"{archivePath}", FileMode.Open))
      {

        using (ZipArchive zip = new ZipArchive(fs, ZipArchiveMode.Update))
        {
          ZipArchiveEntry entry = zip.CreateEntry(fileName);
          using (StreamWriter sw = new StreamWriter(entry.Open()))
          {
            string data = File.ReadAllText($@"{fileName}");
            sw.Write(data);

          }
        }

      }
    }
    static public void CreateArchive()
    {
      ZipFile.CreateFromDirectory(directoryPath, archivePath);

    }

  }
}
