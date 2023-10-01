using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Camera2DExample : Node
{
    [Export] public Camera2D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenOffset(new Vector2(100, 100), tweenDuration))
            .Append(Target.TweenOffsetX(0, tweenDuration))
            .Append(Target.TweenOffsetY(0, tweenDuration))
            .Append(Target.TweenZoom(new Vector2(5, 5), tweenDuration))
            .Append(Target.TweenZoomX(2, tweenDuration))
            .Append(Target.TweenZoomY(2, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}