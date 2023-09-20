using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Source.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class PlayTweenSequenceExample : Node
{
    [Export] public Node2D NodeToMove;
	
    public override void _Ready()
    {
        GTween tween = GTweenSequenceBuilder.New()
            .Append(NodeToMove.TweenGlobalPositionX(100, 1))
            .Append(NodeToMove.TweenGlobalPositionY(100, 1))
            .Append(NodeToMove.TweenGlobalPositionX(0, 1))
            .Append(NodeToMove.TweenGlobalPositionY(0, 1))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}