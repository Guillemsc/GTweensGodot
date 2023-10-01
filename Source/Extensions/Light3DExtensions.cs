using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Light3DExtensions
{
    public static GTween TweenLightColor(this Light3D target, Color to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.LightColor,
            current => target.LightColor = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenLightEnergy(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.LightEnergy,
            current => target.LightEnergy = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenLightIndirectEnergy(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.LightIndirectEnergy,
            current => target.LightIndirectEnergy = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenLightVolumetricFogEnergy(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.LightVolumetricFogEnergy,
            current => target.LightVolumetricFogEnergy = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenLightAngularDistance(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.LightAngularDistance,
            current => target.LightAngularDistance = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenShadowBias(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.ShadowBias,
            current => target.ShadowBias = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenShadowNormalBias(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.ShadowNormalBias,
            current => target.ShadowNormalBias = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenShadowTransmittanceBias(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.ShadowTransmittanceBias,
            current => target.ShadowTransmittanceBias = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenShadowOpacity(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.ShadowOpacity,
            current => target.ShadowOpacity = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenShadowBlur(this Light3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.ShadowBlur,
            current => target.ShadowBlur = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}