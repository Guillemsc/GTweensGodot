using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class CanvasItemExample : Node2D
{
    [Export] public CanvasItem Target;
	
    public override void _Ready()
    {
        float tweenDuration = 1f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenModulate(new Color(0, 0, 0), tweenDuration))
            .Append(Target.TweenModulateAlpha(0, tweenDuration))
            .Append(Target.TweenModulateAlpha(1, tweenDuration))
            .Append(Target.TweenModulateRgb(new Color(1, 1, 1, 0), tweenDuration))
            .Append(Target.TweenSelfModulate(new Color(0, 0, 0), tweenDuration))
            .Append(Target.TweenSelfModulateAlpha(0, tweenDuration))
            .Append(Target.TweenSelfModulateAlpha(1, tweenDuration))
            .Append(Target.TweenSelfModulateRgb(new Color(1, 1, 1, 0), tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}