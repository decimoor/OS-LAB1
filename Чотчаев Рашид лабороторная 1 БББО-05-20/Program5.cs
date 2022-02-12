using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program5
  {
    static public string originDirectory = "Folder";
    static public string destinationDirectory = "Folder";
    static public void Run()
    {
      if (!Directory.Exists(originDirectory))
      {
        DirectoryInfo di = Directory.CreateDirectory(originDirectory);
      }

      ZipFile.CreateFromDirectory(originDirectory, destinationDirectory);



      
    }

    public static void Compress(string sourceFile, string compressedFile)
    {
      using (FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate))
      {
        using (FileStream targetStream = File.Create(compressedFile))
        {
          using (GZipStream compressedStream = new GZipStream(targetStream, CompressionMode.Decompress))
          {
            sourceStream.CopyTo(compressedStream);
            Console.WriteLine($"Размер исходного файла: {sourceStream.Length.ToString()}. Размер сжатого файла: {targetStream.Length.ToString()}");
          }
        }
      }
    }
  }
}
