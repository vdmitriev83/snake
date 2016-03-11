using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            
            Walls walls = new Walls(80,25);
            walls.Draw();
            Point p = new Point(10,10,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80,25,'$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood(snake);
                    food.Draw();

                }
                else
                {
                    food.Draw();
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key != ConsoleKey.Escape)
                    {
                        snake.HandleKey(key.Key);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            
            
            Console.ReadLine();
        }

        
    }
}
