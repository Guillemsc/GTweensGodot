using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Camera3DExample : Node
{
    [Export] public Camera3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenHOffset(3, tweenDuration))
            .Append(Target.TweenHOffset(0, tweenDuration))
            .Append(Target.TweenVOffset(3, tweenDuration))
            .Append(Target.TweenVOffset(0, tweenDuration))
            .Append(Target.TweenFov(100, tweenDuration))
            .Append(Target.TweenFov(60, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}