using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class AudioStreamPlayer3DExtensions
{
    public static GTween TweenVolumeDb(this AudioStreamPlayer3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.VolumeDb,
            current => target.VolumeDb = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPitchScale(this AudioStreamPlayer3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.PitchScale,
            current => target.PitchScale = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenAttenuationFilterDb(this AudioStreamPlayer3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.AttenuationFilterDb,
            current => target.AttenuationFilterDb = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenAttenuationFilterCutoffHz(this AudioStreamPlayer3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.AttenuationFilterCutoffHz,
            current => target.AttenuationFilterCutoffHz = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}