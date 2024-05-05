using System;
using Windows.DesktopIconController.Core;
/************************************************/
namespace Windows.DesktopIconController
{
  internal sealed class App
  {
    private static int Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.Write(DesktopIcon.IsVisible);
        /************************************************/
        return 1;
      }
      /************************************************/
      if (args.Length == 1 && args[0] == "/Toggle")
      {
        return Convert.ToInt32(DesktopIcon.Toggle());
      }
      /************************************************/
      if (args.Length == 1 && args[0] == "/Show")
      {
        return Convert.ToInt32(DesktopIcon.Show());
      }
      /************************************************/
      if (args.Length == 1 && args[0] == "/Hide")
      {
        return Convert.ToInt32(DesktopIcon.Hide());
      }
      /************************************************/
      return 0;
    }
  }
}