using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(80, 25); //не работает на  macos

			//Отрисовка рамки
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
			VerticalLine rigtLine = new VerticalLine(0, 24, 78, '+');
			upLine.Drow();
			downLine.Drow();
			leftLine.Drow();
			rigtLine.Drow();

			//Отрисовка точки
			Point p = new Point(4, 5, '#');
			p.Draw();

			Console.ReadLine();

		}
	}

}
