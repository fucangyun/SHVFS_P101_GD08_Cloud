﻿using System.Reflection;

class Q07
{
    public struct Position
    {
        public int x;
        public int y;
        public int z;
        public Position (int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
    }
    public class GameObject
    {
        string name;
        Position pos;
        public bool comp (GameObject game)
        {
            if (pos.x == game.pos.x && pos.y == game.pos.y && pos.z == game.pos.z)
                return true;
            else return false;
        }
        public GameObject(string Name, int X, int Y, int Z)
        {
            name = Name;
            pos = new Position(X, Y, Z);
        }
    }
    public static void Main()
    {
        GameObject[] ggame= new GameObject[5];
        ggame[0] = new GameObject("num0", 0, 0, 0);
        ggame[1] = new GameObject("num1", 1, 1, 1);
        ggame[2] = new GameObject("num2", 2, 2, 2);
        ggame[3] = new GameObject("num3", 1, 1, 1);
        ggame[4] = new GameObject("num4", 0, 0, 0);
        int i, j, ans=0;
        for(i=0;i<4;i++)
        {
            for(j=i+1;j<5;j++)
            {
                if (ggame[i].comp(ggame[j])) ans++;
            }
        }
        Console.WriteLine($"The pair in this array is {ans}.");
        Console.ReadLine();
    }
}