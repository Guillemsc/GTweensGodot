using Godot;
using GTweens.Delegates;
using GTweens.Tweeners;
using GTweensGodot.Interpolators;

namespace GTweensGodot.Tweeners;

public sealed class GodotColorTweener : Tweener<Color>
{
    public GodotColorTweener(
        Getter getter,
        Setter setter,
        Getter to,
        float duration,
        ValidationDelegates.Validation validation
    )
        : base(
            getter,
            setter,
            to,
            duration,
            GodotColorInterpolator.Instance, 
            validation
        )
    {
    }
}