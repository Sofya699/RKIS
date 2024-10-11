using System;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Drawer
    {
        static float X, Y;
        static IGraphics Grafika;

        public static void Initialize(IGraphics novayaGrafika)
        {
            Grafika = novayaGrafika;
            ClearScreen();
        }

        public static void SetPosition(float x0, float y0)
        {
            X = x0;
            Y = y0;
        }

        public static void DrawLine(Pen ruchka, double dlina, double ugol)
        {
            var x1 = (float)(X + dlina * Math.Cos(ugol));
            var y1 = (float)(Y + dlina * Math.Sin(ugol));
            Grafika.DrawLine(ruchka, X, Y, x1, y1);
            X = x1;
            Y = y1;
        }

        public static void Change(double dlina, double ugol)
        {
            X = (float)(X + dlina * Math.Cos(ugol));
            Y = (float)(Y + dlina * Math.Sin(ugol));
        }

        private static void ClearScreen()
        {
            Grafika.Clear(Colors.Black);
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int shirina, int visota, double ugolPovorota, IGraphics grafika)
        {
            
            Drawer.Initialize(grafika);

            const float SIDE_LENGTH = 0.375f;
            const float THICKNESS = 0.04f;

            var diagonalLength = Math.Sqrt(2) * ((SIDE_LENGTH + THICKNESS) / 2);
            var x0 = (float)(diagonalLength * Math.Cos(Math.PI / 4 + Math.PI)) + shirina / 2f;
            var y0 = (float)(diagonalLength * Math.Sin(Math.PI / 4 + Math.PI)) + visota / 2f;

            Drawer.SetPosition(x0, y0);
            // Рисуем первую сторону
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, 0);
            Drawer.DrawLine(new Pen(Brushes.Yellow), THICKNESS * Math.Sqrt(2), Math.PI / 4);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, Math.PI);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH - THICKNESS, Math.PI / 2);

            Drawer.Change(THICKNESS, -Math.PI);
            Drawer.Change(THICKNESS * Math.Sqrt(2), 3 * Math.PI / 4);

            // Рисуем вторую сторону
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, -Math.PI / 2);
            Drawer.DrawLine(new Pen(Brushes.Yellow), THICKNESS * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, -Math.PI / 2 + Math.PI);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH - THICKNESS, -Math.PI / 2 + Math.PI / 2);

            Drawer.Change(THICKNESS, -Math.PI / 2 - Math.PI);
            Drawer.Change(THICKNESS * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);

            // Рисуем третью сторону
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, Math.PI);
            Drawer.DrawLine(new Pen(Brushes.Yellow), THICKNESS * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, Math.PI + Math.PI);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH - THICKNESS, Math.PI + Math.PI / 2);

            Drawer.Change(THICKNESS, Math.PI - Math.PI);
            Drawer.Change(THICKNESS * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);

            // Рисуем четвертую сторону
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, Math.PI / 2);
            Drawer.DrawLine(new Pen(Brushes.Yellow), THICKNESS * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH, Math.PI / 2 + Math.PI);
            Drawer.DrawLine(new Pen(Brushes.Yellow), SIDE_LENGTH - THICKNESS, Math.PI / 2 + Math.PI / 2);

            Drawer.Change(THICKNESS, Math.PI / 2 - Math.PI);
            Drawer.Change(THICKNESS * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}