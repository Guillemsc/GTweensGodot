using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class CanvasModulateExample : Node2D
{
    [Export] public CanvasModulate Target;
	
    public override void _Ready()
    {
        float tweenDuration = 1f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenColor(new Color(0, 0, 0), tweenDuration))
            .Append(Target.TweenColorAlpha(0, tweenDuration))
            .Append(Target.TweenColorAlpha(1, tweenDuration))
            .Append(Target.TweenColorRgb(new Color(1, 1, 1, 0), tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}