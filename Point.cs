using System;
namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(int _x, int _y,char _sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }
        public void Draw()
        {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(sym);
        }
    }
}
