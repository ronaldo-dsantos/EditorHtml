using System;

namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black;

      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    public static void DrawScreen()
    {
      var columns = 30;
      var lines = 10;

      DrawColumns(columns);

      DrawLines(lines, columns);

      DrawColumns(columns);
    }

    public static void DrawColumns(int columns)
    {
      Console.Write("+");

      for (int column = 0; column <= columns; column++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");
    }

    public static void DrawLines(int lines, int columns)
    {
      for (int line = 0; line <= lines; line++)
      {
        Console.Write("|");

        for (int column = 0; column <= columns; column++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("-----------");
      Console.SetCursorPosition(3, 5);
      Console.WriteLine("Selecione uma opção abaixo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir arquivo");
      Console.SetCursorPosition(3, 8);
      Console.WriteLine("0 - Sair");
      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}