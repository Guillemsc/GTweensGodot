using Godot;
using GTweens.Easings;
using GTweens.Interpolators;

namespace GTweensGodot.Interpolators;

public sealed class GodotVector3Interpolator : IInterpolator<Vector3>
{
    public static readonly GodotVector3Interpolator Instance = new();

    GodotVector3Interpolator()
    {

    }

    public Vector3 Evaluate(
        Vector3 initialValue, 
        Vector3 finalValue, 
        float time, 
        EasingDelegate easingDelegate
    )
    {
        return new Vector3(
            easingDelegate(initialValue.X, finalValue.X, time),
            easingDelegate(initialValue.Y, finalValue.Y, time),
            easingDelegate(initialValue.Z, finalValue.Z, time)
        );
    }

    public Vector3 Subtract(Vector3 initialValue, Vector3 finalValue)
    {
        return finalValue - initialValue;
    }

    public Vector3 Add(Vector3 initialValue, Vector3 finalValue)
    {
        return finalValue + initialValue;
    }
}