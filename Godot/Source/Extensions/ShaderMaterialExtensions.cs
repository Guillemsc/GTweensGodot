using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class ShaderMaterialExtensions
{
    public static GTween TweenPropertyInt(this ShaderMaterial target, StringName property, int to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GetShaderParameter(property).AsInt32(),
            current => target.SetShaderParameter(property, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyFloat(this ShaderMaterial target, StringName property, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GetShaderParameter(property).AsSingle(),
            current => target.SetShaderParameter(property, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyVector2(this ShaderMaterial target, StringName property, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GetShaderParameter(property).AsVector2(),
            current => target.SetShaderParameter(property, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyVector2I(this ShaderMaterial target, StringName property, Vector2I to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GetShaderParameter(property).AsVector2I(),
            current => target.SetShaderParameter(property, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyColor(this ShaderMaterial target, StringName property, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GetShaderParameter(property).AsColor(),
            current => target.SetShaderParameter(property, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyColorRgb(this ShaderMaterial target, StringName property, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GetShaderParameter(property).AsColor(),
            current => target.SetShaderParameter(
                property, 
                new Color(current.R, current.G, current.B, target.GetShaderParameter(property).AsColor().A)
                ),
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPropertyColorAlpha(this ShaderMaterial target, StringName property, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GetShaderParameter(property).AsColor().A,
            current => 
            {
                Color previous = target.GetShaderParameter(property).AsColor();
                target.SetShaderParameter(property, new Color(previous.R, previous.G, previous.B, current));
            }, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}