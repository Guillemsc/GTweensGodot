using Godot;
using GTweens.Delegates;
using GTweens.Tweeners;
using GTweensGodot.Interpolators;

namespace GTweensGodot.Tweeners;

public sealed class GodotVector3Tweener : Tweener<Vector3>
{
    public GodotVector3Tweener(
        Getter currentValueGetter,
        Setter setter,
        Getter finalValueGetter,
        float duration,
        ValidationDelegates.Validation validation
    )
        : base(
            currentValueGetter,
            setter,
            finalValueGetter,
            duration,
            GodotVector3Interpolator.Instance, 
            validation
        )
    {
    }
}