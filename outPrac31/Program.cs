using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outPrac31
{
    internal class Program
    {
        static void NextPosition(int x, int y, int vx, int vy,
            out int rx, out int ry)
        {
            rx = x + vx;
            ry = y+vy;
        }
        static void Main(string[] args)
        {
            int x = 0; int y = 0;
            int vx = 1; int vy = 1;

            Console.WriteLine($"현재좌표: {x}, {y}");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine($"다음좌표: {x}, {y}");
        }
    }
}
