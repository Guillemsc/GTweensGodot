using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class AudioStreamPlayer2DExtensions
{
    public static GTween TweenVolumeDb(this AudioStreamPlayer2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.VolumeDb,
            current => target.VolumeDb = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPitchScale(this AudioStreamPlayer2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.PitchScale,
            current => target.PitchScale = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}