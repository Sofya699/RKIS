using System;
using System.Net.Http.Headers;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Risovatel
    {
        static float x, y;
        static IGraphics graphics;

        public static void Initialization ( IGraphics newGraphics)
        {
            graphics = newGraphics;
            //grafika.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Colors.Black);
        }

        public static void SetPosition(float x0, float y0)
        {x = x0; y = y0;}

        public static void MakeIt(Pen brush, double length, double angle)
        {
        //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
        var x1 = (float)(x + length * Math.Cos(angle));
        var y1 = (float)(y + length * Math.Sin(angle));
        graphics.DrawLine(brush, x, y, x1, y1);
        x = x1;
        y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle)); 
           y = (float)(y + length * Math.Sin(angle));
           }
    }
    
    public class ImpossibleSquare
{
    public static void Draw(int width, int height, double rotationAngle, IGraphics graphics)
    {
        // ugolPovorota пока не используется, но будет использоваться в будущем
        Risovatel.Initialization(graphics);

        var size = Math.Min(width, height);

        var diagonalLength = Math.Sqrt(2) * (size * 0.375f + size * 0.04f) / 2;
        var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
        var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

        Risovatel.SetPosition(x0, y0);

        DrawSide(size, 0);
        DrawSide(size, -Math.PI / 2);
        DrawSide(size, Math.PI);
        DrawSide(size, Math.PI / 2);

        }
       public static void DrawSide(int size, double angle)
        {
            Risovatel.MakeIt(new Pen(Brushes.Yellow), size * 0.375f, angle);
            Risovatel.MakeIt(new Pen(Brushes.Yellow), size * 0.04f * Math.Sqrt(2), angle + Math.PI / 4);
            Risovatel.MakeIt(new Pen(Brushes.Yellow), size * 0.375f, angle + Math.PI);
            Risovatel.MakeIt(new Pen(Brushes.Yellow), size * 0.375f - size * 0.04f, angle + Math.PI / 2);
            Risovatel.Change(size * 0.04f, angle + Math.PI);
            Risovatel.Change(size * 0.04f * Math.Sqrt(2), angle + 3 * Math.PI / 4);
        }
}
}