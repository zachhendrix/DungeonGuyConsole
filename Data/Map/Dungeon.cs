using System;
using System.Collections.Generic;
using System.Text;

public static class Dungeon
{
    public static string map;

    public static void DrawMap()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(map);
    }
}
