using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class BaseMaterial3DExtensions
{
    public static GTween TweenAlbedoColor(this BaseMaterial3D target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.AlbedoColor,
            current => target.AlbedoColor = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenAlbedoColorRgb(this BaseMaterial3D target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.AlbedoColor,
            current => target.AlbedoColor = new Color(current.R, current.G, current.B, target.AlbedoColor.A), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenAlbedoColorAlpha(this BaseMaterial3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.AlbedoColor.A,
            current => target.AlbedoColor = new Color(target.AlbedoColor.R, target.AlbedoColor.G, target.AlbedoColor.B, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenMetallic(this BaseMaterial3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Metallic,
            current => target.Metallic = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenMetallicSpecular(this BaseMaterial3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.MetallicSpecular,
            current => target.MetallicSpecular = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRoughness(this BaseMaterial3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Roughness,
            current => target.Roughness = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}