using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Sprite2DExtensions
{
    public static GTween TweenOffset(this Sprite2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Offset,
            current => target.Offset = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetX(this Sprite2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Offset.X,
            current => target.Offset = new Vector2(current, target.Offset.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetY(this Sprite2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Offset.Y,
            current => target.Offset = new Vector2(target.Offset.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}