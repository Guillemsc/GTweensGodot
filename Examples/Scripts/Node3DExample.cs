using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class Node3DExample : Node
{
    [Export] public Node3D NodeToMove;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(NodeToMove.TweenGlobalPosition(new Vector3(1, 1, 1), tweenDuration))
            .Append(NodeToMove.TweenGlobalPositionX(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalPositionY(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalPositionZ(0, tweenDuration))
            .Append(NodeToMove.TweenPosition(new Vector3(1, 1, 1), tweenDuration))
            .Append(NodeToMove.TweenPositionX(0, tweenDuration))
            .Append(NodeToMove.TweenPositionY(0, tweenDuration))
            .Append(NodeToMove.TweenPositionZ(0, tweenDuration))
            .Append(NodeToMove.TweenPositionY(1, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotation(new Vector3(180 * MathExtensions.Deg2Rad, 180 * MathExtensions.Deg2Rad, 180 * MathExtensions.Deg2Rad), tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationX(180 * MathExtensions.Deg2Rad, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationY(180 * MathExtensions.Deg2Rad, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationZ(180 * MathExtensions.Deg2Rad, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotation(Vector3.Zero, tweenDuration))
            .Append(NodeToMove.TweenRotation(new Vector3(180 * MathExtensions.Deg2Rad, 180 * MathExtensions.Deg2Rad, 180 * MathExtensions.Deg2Rad), tweenDuration))
            .Append(NodeToMove.TweenRotationX(0, tweenDuration))
            .Append(NodeToMove.TweenRotationY(0, tweenDuration))
            .Append(NodeToMove.TweenRotationZ(0, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegrees(new Vector3(180, 180, 180), tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegreesX(180, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegreesY(180, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegreesZ(180, tweenDuration))
            .Append(NodeToMove.TweenGlobalRotationDegrees(Vector3.Zero, tweenDuration))
            .Append(NodeToMove.TweenRotationDegrees(new Vector3(180, 180, 180), tweenDuration))
            .Append(NodeToMove.TweenRotationDegreesX(180, tweenDuration))
            .Append(NodeToMove.TweenRotationDegreesY(180, tweenDuration))
            .Append(NodeToMove.TweenRotationDegreesZ(180, tweenDuration))
            .Append(NodeToMove.TweenScale(new Vector3(2, 2, 2), tweenDuration))
            .Append(NodeToMove.TweenScaleX(1, tweenDuration))
            .Append(NodeToMove.TweenScaleY(1, tweenDuration))
            .Append(NodeToMove.TweenScaleZ(1, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}