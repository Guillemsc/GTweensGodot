using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class ProgressBarExtensions
{
    public static GTween TweenValue(this ProgressBar bar, float targetValue, float duration)
    {
        GTween result = GTweenExtensions.Tween(
                    () => (float)bar.Value,
                    (newVal) => bar.Value = newVal,
                    targetValue,
                    duration
                );
        return result;
    }

    public static GTween TweenMaxValue(this ProgressBar bar, float targetMaxValue, float duration)
    {
        GTween result = GTweenExtensions.Tween(
                    () => (float)bar.MaxValue,
                    (newVal) => bar.MaxValue = newVal,
                    targetMaxValue,
                    duration
                );
        return result;
    }
}
