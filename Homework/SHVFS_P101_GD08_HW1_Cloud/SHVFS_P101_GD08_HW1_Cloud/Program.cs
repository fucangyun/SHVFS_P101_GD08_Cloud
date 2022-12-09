using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;

namespace SHVFS_P101_GD08_C7_SnakesOnATrain
{
    internal class Program
    {
        // caseing
        // camelCase
        // UpperCamelCase
        // etc.
        // _camelCase
        // CAMEL_CASE
        
        // we need to track score
        // we need chars to represent players
        private static Player playerOne = new Player()
        {
            Direction = Vector2.Right,
            
            #region Data structures
            InputDirections = new Dictionary<ConsoleKey, Vector2>()
            {
                {
                    ConsoleKey.W, Vector2.Up  
                },
                {
                    ConsoleKey.S, Vector2.Down  
                },
                {
                    ConsoleKey.A, Vector2.Left  
                },
                {
                    ConsoleKey.D, Vector2.Right  
                }
            }
            #endregion
        };

        private static Player playerTwo = new Player()
        {
            Direction = Vector2.Left,

            #region Data structures
            InputDirections = new Dictionary<ConsoleKey, Vector2>()
            {
                {
                    ConsoleKey.UpArrow, Vector2.Up  
                },
                {
                    ConsoleKey.DownArrow, Vector2.Down  
                },
                {
                    ConsoleKey.LeftArrow, Vector2.Left  
                },
                {
                    ConsoleKey.RightArrow, Vector2.Right  
                }
            }
            #endregion
        };
        
        private static bool[,] usedGridPositions;
        private const int timeScale = 100;
        private const string currentScoreText = "Current Score: ";
        private const string pressAnyKeyText = "Press any key to continue...";
        private static string result = "";
        
        public static void Main(string[] args)
        {
            Vector2 zero = new Vector2(0, 0);
            bool flag1 = false, flag2 = false;
            #region Draw start screen
            var title = "Snakes On A Train";

            Console.CursorLeft = Console.BufferWidth / 2 - title.Length / 2;
            Console.WriteLine(title);

            // Some things you may want to use...
            // Console.CursorTop, Console.ForegroundColor...
            Console.ForegroundColor = ConsoleColor.Yellow;
            // \ -> is called an escape character, \n means "new line"
            Console.WriteLine("Player One's controls:\n\n" +
                              "W - Up\n" +
                              "A - Left\n" +
                              "S - Down\n" +
                              "D - Right");

            var playerTwoControlTitle = "Player Two's controls:";
            var cursorLeft = Console.BufferWidth - playerTwoControlTitle.Length;
            Console.CursorTop = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Player 2's controls:\n");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Up Arrow - Up");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Left Arrow - Left");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Down Arrow - Down");
            Console.CursorLeft = cursorLeft;
            Console.WriteLine("Right Arrow - Right");
            Console.ReadKey();
            Console.Clear();

            #endregion
            
            SetupPlayArea();
            ConsoleKey key;
            while (true)
            {
                

                // Set player positions
                
                // Check if players have lost, adjust the score, write the win/loss message, reset new round
                // Checking for a loss will involve checking this 2D array for "true"
                usedGridPositions[playerOne.Position.x, playerOne.Position.y] = true;
                usedGridPositions[playerTwo.Position.x, playerTwo.Position.y] = true;
                DrawPlayer(playerOne.Position.x, playerOne.Position.y, '*', ConsoleColor.Yellow);
                DrawPlayer(playerTwo.Position.x, playerTwo.Position.y, '*', ConsoleColor.Cyan);


                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.W || key == ConsoleKey.A || key == ConsoleKey.S || key == ConsoleKey.D)
                    {
                        if (playerOne.InputDirections[key] + playerOne.Direction != zero)
                        {
                            playerOne.Direction = playerOne.InputDirections[key];
                        }
                    }
                    else if (key == ConsoleKey.UpArrow || key == ConsoleKey.DownArrow || key == ConsoleKey.LeftArrow || key == ConsoleKey.RightArrow)
                    {
                        if(playerTwo.InputDirections[key]+playerTwo.Direction != zero)
                        {
                            playerTwo.Direction = playerTwo.InputDirections[key];
                        }
                    }
                    // Set player directions
                }
                playerOne.Position = playerOne.Position + playerOne.Direction;
                playerTwo.Position = playerTwo.Position + playerTwo.Direction;
                if (playerOne.Position.x >= Console.WindowWidth || playerOne.Position.x < 0 ||
                   playerOne.Position.y >= Console.WindowHeight || playerOne.Position.y < 0 ||
                   usedGridPositions[playerOne.Position.x, playerOne.Position.y]) flag1 = true;
                if (playerTwo.Position.x >= Console.WindowWidth || playerTwo.Position.x < 0 ||
                   playerTwo.Position.y >= Console.WindowHeight || playerTwo.Position.y < 0 ||
                   usedGridPositions[playerTwo.Position.x, playerTwo.Position.y]) flag2 = true;
                if(flag1 || flag2)
                {
                    Console.CursorLeft = Console.BufferWidth/2;
                    Console.CursorTop = 1;
                    if (flag1 && !flag2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("PlayerTwo Wins!");
                    }
                    else if(!flag1 && flag2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("PlayerOne Wins!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Draw.");
                    }
                    Console.ReadLine();
                    return;
                }

                Thread.Sleep(timeScale);
            }
        }
        
        private static void DrawPlayer(int positionX, int positionY, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }
        
        private static void SetupPlayArea()
        {
            Console.WindowHeight = 30;
            Console.BufferHeight = 30;
            Console.WindowWidth = 100;
            Console.BufferWidth = 100;
            
            usedGridPositions = new bool[Console.WindowWidth, Console.WindowHeight];
            
            playerOne.Direction = Vector2.Right;
            playerOne.Position.x = 0;
            playerOne.Position.y = Console.WindowHeight / 2;
            
            playerTwo.Direction = Vector2.Left;
            playerTwo.Position.x = Console.WindowWidth - 1;
            playerTwo.Position.y = Console.WindowHeight / 2;
        }
    }
}