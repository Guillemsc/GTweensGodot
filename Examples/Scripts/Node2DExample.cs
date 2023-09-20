using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class Node2DExample : Node2D
{
    [Export] public Node2D NodeToMove;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(NodeToMove.TweenGlobalPosition(new Vector2(100, 100), tweenDuration))
            .Append(NodeToMove.TweenGlobalPositionX(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalPositionY(0, tweenDuration))
            .Append(NodeToMove.TweenPosition(new Vector2(100, 100), tweenDuration))
            .Append(NodeToMove.TweenPositionX(0, tweenDuration))
            .Append(NodeToMove.TweenPositionY(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotation(180 * MathExtensions.Deg2Rad, tweenDuration))
            .Append(NodeToMove.TweenRotation(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegrees(180, tweenDuration))
            .Append(NodeToMove.TweenRotationDegrees(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegreesWithin180Range(180, tweenDuration))
            .Append(NodeToMove.TweenRotationDegreesWithin180Range(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalScale(new Vector2(5, 5), tweenDuration))
            .Append(NodeToMove.TweenGlobalScaleX(1, tweenDuration))
            .Append(NodeToMove.TweenGlobalScaleY(1, tweenDuration))
            .Append(NodeToMove.TweenScale(new Vector2(5, 5), tweenDuration))
            .Append(NodeToMove.TweenScaleX(1, tweenDuration))
            .Append(NodeToMove.TweenScaleY(1, tweenDuration))
            .Append(NodeToMove.TweenGlobalSkew(1, tweenDuration))
            .Append(NodeToMove.TweenSkew(0, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}