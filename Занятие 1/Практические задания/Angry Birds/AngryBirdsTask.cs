using System;

namespace AngryBirds;

public static class AngryBirdsTask
{
    public static double FindSightAngle(double v, double distance)
    {
        double g = 9.8;
        
        retrun 0.5 * MathAsin(distance * g / (v * v));
    }
}