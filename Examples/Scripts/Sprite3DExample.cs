using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Sprite3DExample : Node3D
{
    [Export] public Sprite3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}