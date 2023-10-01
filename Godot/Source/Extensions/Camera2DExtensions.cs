using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Camera2DExtensions
{
    public static GTween TweenOffset(this Camera2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Offset,
            current => target.Offset = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetX(this Camera2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Offset.X,
            current => target.Offset = new Vector2(current, target.Offset.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetY(this Camera2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Offset.Y,
            current => target.Offset = new Vector2(target.Offset.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenZoom(this Camera2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Zoom,
            current => target.Zoom = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenZoomX(this Camera2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Zoom.X,
            current => target.Zoom = new Vector2(current, target.Zoom.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenZoomY(this Camera2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Zoom.Y,
            current => target.Zoom = new Vector2(target.Zoom.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}