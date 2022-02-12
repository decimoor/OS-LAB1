using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Чотчаев_Рашид_лабороторная_1_БББО_05_20
{
  internal class Program1
  {
    static public void Run()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();

      foreach (DriveInfo drive in drives)
      {
        Console.WriteLine($"Название: {drive.Name} байт.");
        Console.WriteLine($"Общий размер: {drive.TotalSize} байт.");
        Console.WriteLine($"Тип файловой системы: {drive.DriveFormat} байт.");
      }
    }
  }
}
