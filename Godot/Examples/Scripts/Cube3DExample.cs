using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Cube3DExample : Node
{
    [Export] public Node3D Pivot;
    [Export] public Node3D Cube;

    public override void _Ready()
    {
        float jumpDuration = 0.5f;
        float fallDuration = 0.3f;

        float initialPivotPositionY = Pivot.Position.Y;
        
        GTween initialSquash = GTweenSequenceBuilder.New()
            .Append(Pivot.TweenScaleY(0.5f, 1.8f).SetEasing(Easing.InOutQuad))
            .Join(Pivot.TweenScaleX(1.5f, 1.8f).SetEasing(Easing.InOutQuad))
            .Join(Pivot.TweenScaleZ(1.5f, 1.8f).SetEasing(Easing.InOutQuad))
            .Build();
        
        GTween jump = GTweenSequenceBuilder.New()
            .Join(Pivot.TweenScaleY(1.5f, 0.1f).SetEasing(Easing.InQuad))
            .Join(Pivot.TweenScaleX(0.5f, 0.1f).SetEasing(Easing.InQuad))
            .Join(Pivot.TweenScaleZ(0.5f, 0.1f).SetEasing(Easing.InQuad))
            .Append(Pivot.TweenPositionY(3.5f, jumpDuration).SetEasing(Easing.OutQuint))
            .JoinSequence(b => b
                .Append(Pivot.TweenScaleY(1.4f, jumpDuration).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleX(0.9f, jumpDuration).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleZ(0.9f, jumpDuration).SetEasing(Easing.OutQuad))
            )
            .Join(Cube.TweenRotationDegreesX(180, jumpDuration).SetEasing(Easing.OutCubic))
            .Build();
        
        GTween fall = GTweenSequenceBuilder.New()
            .Append(Pivot.TweenPositionY(initialPivotPositionY, fallDuration).SetEasing(Easing.InQuad))
            .JoinSequence(b => b
                .Append(Pivot.TweenScaleY(0.8f, fallDuration).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleX(1.2f, fallDuration).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleZ(1.2f, fallDuration).SetEasing(Easing.OutQuad))
            )
            .Join(Cube.TweenRotationDegreesX(360, fallDuration).SetEasing(Easing.InCubic))
            .AppendSequence(b => b
                .Append(Pivot.TweenScaleY(0.5f, 0.2f).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleX(1.5f, 0.2f).SetEasing(Easing.OutQuad))
                .Join(Pivot.TweenScaleZ(1.5f, 0.2f).SetEasing(Easing.OutQuad))
            )
            .AppendSequence(b => b
                .Append(Pivot.TweenScaleY(1f, 0.4f).SetEasing(Easing.InOutQuad))
                .Join(Pivot.TweenScaleX(1f, 0.4f).SetEasing(Easing.InOutQuad))
                .Join(Pivot.TweenScaleZ(1f, 0.4f).SetEasing(Easing.InOutQuad))
            )
            .Build();

        GTween finalSequence = GTweenSequenceBuilder.New()
            .Append(initialSquash)
            .Append(jump)
            .Append(fall)
            .AppendTime(1f)
            .Build()
            .SetMaxLoops();
        
        finalSequence.Play();
    }
}