using Godot;
using GTweens.Delegates;
using GTweens.Tweeners;
using GTweensGodot.Interpolators;

namespace GTweensGodot.Tweeners;

public sealed class GodotColorTweener : Tweener<Color>
{
    public GodotColorTweener(
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
            GodotColorInterpolator.Instance, 
            validation
        )
    {
    }
}