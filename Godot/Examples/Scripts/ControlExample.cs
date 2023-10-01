using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class ControlExample : Node2D
{
    [Export] public Control Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenGlobalPosition(new Vector2(100, 100), tweenDuration))
            .Append(Target.TweenGlobalPositionX(0, tweenDuration))
            .Append(Target.TweenGlobalPositionY(0, tweenDuration))
            .Append(Target.TweenPosition(new Vector2(100, 100), tweenDuration))
            .Append(Target.TweenPositionX(0, tweenDuration))
            .Append(Target.TweenPositionY(0, tweenDuration))
            .Append(Target.TweenRotation(180 * MathExtensions.Deg2Rad, tweenDuration))
            .Append(Target.TweenScale(new Vector2(5, 5), tweenDuration))
            .Append(Target.TweenScaleX(1, tweenDuration))
            .Append(Target.TweenScaleY(1, tweenDuration))
            .Append(Target.TweenSize(new Vector2(200, 200), tweenDuration))
            .Append(Target.TweenSizeX(100, tweenDuration))
            .Append(Target.TweenSizeY(100, tweenDuration))
            .Append(Target.TweenPivotOffset(new Vector2(100, 100), tweenDuration))
            .Append(Target.TweenPivotOffsetX(0, tweenDuration))
            .Append(Target.TweenPivotOffsetY(0, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}