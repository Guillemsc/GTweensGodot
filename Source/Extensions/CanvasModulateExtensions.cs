using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class CanvasModulateExtensions
{
    public static GTween TweenColor(this CanvasModulate target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Color,
            current => target.Color = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenColorRgb(this CanvasModulate target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Color,
            current => target.Color = new Color(current.R, current.G, current.B, target.Color.A), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenColorAlpha(this CanvasModulate target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Color.A,
            current => target.Color = new Color(target.Color.R, target.Color.G, target.Color.B, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}