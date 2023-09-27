using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class PlayTweenSequenceExample : Node
{
    [Export] public Node2D Target;
	
    public override void _Ready()
    {
        GTween tween = GTweenSequenceBuilder.New()
            .Append(Target.TweenPositionX(100, 0.5f))
                .Join(Target.TweenScale(new Vector2(2, 2), 1))
            .Append(Target.TweenPositionY(100, 1))
            .AppendTime(0.5f)
            .Append(Target.TweenPositionX(0, 1))
            .Append(Target.TweenPositionY(0, 1))
            .AppendCallback(() => GD.Print("I'm finished!"))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}