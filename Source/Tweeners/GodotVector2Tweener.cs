using Godot;
using GTweens.Delegates;
using GTweens.Interpolators;
using GTweens.Tweeners;
using GTweensGodot.Source.Interpolators;

namespace GTweensGodot.Source.Tweeners;

public sealed class GodotVector2Tweener : Tweener<Vector2>
{
    public GodotVector2Tweener(
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
            GodotVector2Interpolator.Instance, 
            validation
        )
    {
    }
}