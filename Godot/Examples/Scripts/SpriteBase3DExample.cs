using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class SpriteBase3DExample : Node
{
    [Export] public Sprite3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenModulate(new Color(0, 0, 0), tweenDuration))
            .Append(Target.TweenModulateAlpha(0, tweenDuration))
            .Append(Target.TweenModulateAlpha(1, tweenDuration))
            .Append(Target.TweenModulateRgb(new Color(1, 1, 1, 0), tweenDuration))
            .Append(Target.TweenOffset(new Vector2(50f, 50f), tweenDuration))
            .Append(Target.TweenOffsetX(0f, tweenDuration))
            .Append(Target.TweenOffsetY(0f, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}