﻿class Risovatel
    {
        static float x, y;
        static IGraphics Graphics;
        public static void Initialization(IGraphics newGraphics)
        {
            graphics = newGraphics;
            graphics.Clear(Colors.Black);
        }
        public static void SetPosition(float x0, float y0)
        { x = x0; y = y0; }
        public static void MakeStep(Pen pen, double lenght, double corner)
        {
            var x1 = (float)(x + lenght * Math.Cos(corner));
            var y1 = (float)(y + lenght * Math.Sin(corner));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void ChangePosition(double lenght, double corner)
        {
            x = (float)(x + lenght * Math.Cos(corner)); 
            y = (float)(y + lenght * Math.Sin(corner));
            public class ImpossibleSquare
        }
    {
    public static void Draw(int width, int height, double angle, IGraphics graphics)
    {
        var drawer = new Risovatel();
        Risovatel.Initialization(graphics);
         DrawSide(size, Math.PI);
        DrawSide(size, Math.PI / 2);
    }
    private static void DrawSide(Risovatel drawer, float size, double angle)
    {
            var pen1 = new Pen(Brushes.Blue);
            var pen2 = new Pen(Brushes.White);
            var pen3 = new Pen(Brushes.LightBlue);
            var pen4 = new Pen(Brushes.DeepSkyBlue);
            Risovatel.MakeStep(pen1, Size * 0.375f, 0 + Angle);
            Risovatel.MakeStep(pen2, Size * 0.04f * Math.Sqrt(2), Math.PI / 4 + Angle);
            Risovatel.MakeStep(pen3, Size * 0.375f, Math.PI + Angle);
            Risovatel.MakeStep(pen4, Size * 0.375f - Size * 0.04f, Math.PI / 2 + Angle);
            Risovatel.ChangePosition(Size * 0.04f, Math.PI + Angle);
            Risovatel.ChangePosition(Size * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4 + Angle);
    }
    }
}