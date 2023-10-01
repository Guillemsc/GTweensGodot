using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Sprite2DExample : Node2D
{
    [Export] public Sprite2D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenOffset(new Vector2(100f, 100f), tweenDuration))
            .Append(Target.TweenOffsetX(0f, tweenDuration))
            .Append(Target.TweenOffsetY(0f, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}