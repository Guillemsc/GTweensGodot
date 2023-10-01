using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class SpriteBase3DExtensions
{
    public static GTween TweenModulate(this SpriteBase3D target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Modulate,
            current => target.Modulate = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenModulateRgb(this SpriteBase3D target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Modulate,
            current => target.Modulate = new Color(current.R, current.G, current.B, target.Modulate.A), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenModulateAlpha(this SpriteBase3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Modulate.A,
            current => target.Modulate = new Color(target.Modulate.R, target.Modulate.G, target.Modulate.B, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffset(this SpriteBase3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Offset,
            current => target.Offset = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetX(this SpriteBase3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Offset.X,
            current => target.Offset = new Vector2(current, target.Offset.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenOffsetY(this SpriteBase3D target, float to, float duration)
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