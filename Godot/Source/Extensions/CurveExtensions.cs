using Godot;
using GTweens.Easings;

namespace GTweensGodot.Extensions;

public static class CurveExtensions
{
    public static EasingDelegate ToEasingDelegate(this Curve curve)
    {
        float Result(float a, float b, float t)
        {
            float newT = curve.Sample(t);

            return a + ((b - a) * newT);
        }

        return Result;
    }
}