using System;
using System.Diagnostics;
using System.Drawing;
 
namespace RefactorMe
{
	// ## Прочитайте! ##
	//
	// Ваша задача привести код в этом файле в порядок. 
	// Для начала запустите эту программу.
	// Переименуйте всё, что называется неправильно. Это можно делать комбинацией клавиш Ctrl+R, Ctrl+R (дважды нажать Ctrl+R).
	// Повторяющиеся части кода вынесите во вспомогательные методы. Это можно сделать выделив несколько строк кода и нажав Ctrl+R, Ctrl+M
	// Избавьтесь от всех зашитых в коде числовых констант — положите их в переменные с понятными именами.
	// 
	// После наведения порядка проверьте, что ваш код стал лучше. 
	// На сколько проще после ваших переделок стало изменить размер фигуры? Повернуть её на некоторый угол? 
	// Научиться рисовать невозможный треугольник, вместо квадрата?
 
	class Drawer
	{
		static Bitmap image = new Bitmap(800, 600);
		static float x, y;
		static Graphics graphics;
 
		public static void Initialize()
		{
			image = new Bitmap(800, 600);
			graphics = Graphics.FromImage(image);
		}
 
		public static void set_pos(float x0, float y0)
		{
			x = x0;
			y = y0;
		}
 
		public static void MakeStep(double L, double angle)
		{
			//Делает шаг длиной L в направлении angle и рисует пройденную траекторию
			var x1 = (float)(x + L * Math.Cos(angle));
			var y1 = (float)(y + L * Math.Sin(angle));
			graphics.DrawLine(Pens.Yellow, x, y, x1, y1);
			x = x1;
			y = y1;
		}
 
		public static void ShowResult()
		{
			image.Save("result.bmp");
			Process.Start("result.bmp");
		}
	}
 
	public class DrawFigure
	{
        public static void DrawPart (int lengthOfSide, int angle, double turn)
        {
            Drawer.MakeStep(lengthOfSide, angle);
            Drawer.MakeStep(10 * Math.Sqrt(2), turn + Math.PI / 4);
            Drawer.MakeStep(100, turn + Math.PI);
            Drawer.MakeStep(100 - (double)10, turn + Math.PI / 2);
        }
		public static void Main()
		{
			Drawer.Initialize();
 
            //Рисуем четыре одинаковые части невозможного квадрата.
            // Часть первая:
            DrawPart(10, 0, 0);
 
            // Часть вторая:
            DrawPart(120, 10, Math.PI / 2);
 
            // Часть третья:
            DrawPart(110, 120, Math.PI);			
 
            // Часть четвертая:
            DrawPart(0, 110, -Math.PI / 2);			
 
			Drawer.ShowResult();
		}
	}
}
