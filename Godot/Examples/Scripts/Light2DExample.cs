using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Light2DExample : Node
{
    [Export] public DirectionalLight2D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 1f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .AppendTime(tweenDuration)
            .Append(Target.TweenEnergy(1, tweenDuration))
            .Append(Target.TweenColor(new Color(2, 0, 0), tweenDuration))
            .Append(Target.TweenColor(new Color(1, 1, 1), tweenDuration))
            .Append(Target.TweenEnergy(0, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}