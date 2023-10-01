using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class CanvasItemExtensions
{
    public static GTween TweenModulate(this CanvasItem target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Modulate,
            current => target.Modulate = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenModulateRgb(this CanvasItem target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Modulate,
            current => target.Modulate = new Color(current.R, current.G, current.B, target.Modulate.A), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenModulateAlpha(this CanvasItem target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Modulate.A,
            current => target.Modulate = new Color(target.Modulate.R, target.Modulate.G, target.Modulate.B, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSelfModulate(this CanvasItem target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.SelfModulate,
            current => target.SelfModulate = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSelfModulateRgb(this CanvasItem target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.SelfModulate,
            current => target.SelfModulate = new Color(current.R, current.G, current.B, target.SelfModulate.A), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSelfModulateAlpha(this CanvasItem target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.SelfModulate.A,
            current => target.SelfModulate = new Color(target.SelfModulate.R, target.SelfModulate.G, target.SelfModulate.B, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}