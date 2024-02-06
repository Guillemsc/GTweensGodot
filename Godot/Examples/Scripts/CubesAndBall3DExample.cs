using Godot;
using Godot.Collections;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Enums;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class CubesAndBall3DExample : Node
{
    [Export] public Node3D GeometryPivot;
    [Export] public Array<Node3D> Cubes;
    [Export] public Node3D BallPivot;
    [Export] public Node3D ShakePivot;
    [Export] public Curve BaseShakeCurve;
    
    public override void _Ready()
    {
        PlayBallRotation();
        PlayJump();
    }

    void PlayBallRotation()
    {
        GTween tween = GTweenSequenceBuilder.New()
            .Append(BallPivot.TweenRotationDegreesY(-360, 2, RotationMode.TotalDistance)
                .SetMaxLoops())
            .Build();

        tween.SetEasing(Easing.Linear);
        tween.Play();
    }

    void PlayJump()
    {
        float jumpDuration = 0.5f;
        
        GTween moveUpTween = GTweenSequenceBuilder.New()
            .Append(GeometryPivot.TweenGlobalPositionY(2, jumpDuration * 0.55f)
                .SetEasing(Easing.OutQuad))
            .Append(GeometryPivot.TweenGlobalPositionY(0, jumpDuration * 0.45f)
                .SetEasing(Easing.InQuad))
            .Build();

        GTweenSequenceBuilder rotationBuilder = GTweenSequenceBuilder.New();

        foreach (Node3D cube in Cubes)
        {
            rotationBuilder.Join(cube.TweenRotationDegreesX(-90, jumpDuration, RotationMode.TotalDistance)
                .SetEasing(Easing.OutQuad));
        }
        
        GTween baseShake = GTweenSequenceBuilder.New()
            .Append(ShakePivot.TweenGlobalPositionXZ(Vector2.One * 0.3f, 0.2f)
                .SetEasing(BaseShakeCurve))
            .Build();

        GTween finalTween = GTweenSequenceBuilder.New()
            .Append(moveUpTween)
            .Join(rotationBuilder.Build())
            .Append(baseShake)
            .AppendTime(1f)
            .Build();
        
        finalTween.SetMaxLoops().Play();
    }
}