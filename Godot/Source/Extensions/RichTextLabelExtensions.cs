using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class RichTextLabelExtensions
{
    public static GTween TweenDisplayedTextVisibleRatio(this RichTextLabel target, float value, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.VisibleRatio,
            current => target.VisibleRatio = current,
            value,
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}