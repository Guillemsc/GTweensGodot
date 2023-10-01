using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class Light3DExample : Node
{
    [Export] public DirectionalLight3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 1f;
        
        GTween tween = GTweenSequenceBuilder.New()
            .AppendTime(tweenDuration)
            .Append(Target.TweenLightColor(new Color(2, 0, 0), tweenDuration))
            .Append(Target.TweenLightColor(new Color(1, 1, 1), tweenDuration))
            .Append(Target.TweenLightEnergy(5, tweenDuration))
            .Append(Target.TweenLightEnergy(1, tweenDuration))
            .Append(Target.TweenLightIndirectEnergy(5, tweenDuration))
            .Append(Target.TweenLightIndirectEnergy(1, tweenDuration))
            .Append(Target.TweenLightVolumetricFogEnergy(5, tweenDuration))
            .Append(Target.TweenLightVolumetricFogEnergy(1, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}