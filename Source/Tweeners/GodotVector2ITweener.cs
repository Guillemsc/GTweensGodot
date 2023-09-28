using Godot;
using GTweens.Delegates;
using GTweens.Tweeners;
using GTweensGodot.Interpolators;

namespace GTweensGodot.Tweeners;

public sealed class GodotVector2ITweener : Tweener<Vector2I>
{
    public GodotVector2ITweener(
        Getter getter,
        Setter setter,
        Vector2I to,
        float duration,
        ValidationDelegates.Validation validation
    )
        : base(
            getter,
            setter,
            to,
            duration,
            GodotVector2IInterpolator.Instance, 
            validation
        )
    {
    }
}