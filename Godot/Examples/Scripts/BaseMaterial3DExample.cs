using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class BaseMaterial3DExample : Node
{
    [Export] public GeometryInstance3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;

        BaseMaterial3D material = (BaseMaterial3D)Target.MaterialOverride;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(material.TweenAlbedoColor(new Color(0, 0, 0), tweenDuration))
            .Append(material.TweenAlbedoColorAlpha(0, tweenDuration))
            .Append(material.TweenAlbedoColorAlpha(1, tweenDuration))
            .Append(material.TweenAlbedoColorRgb(Color.FromHtml("557cff"), tweenDuration))
            .Append(material.TweenMetallic(1, tweenDuration))
            .Append(material.TweenMetallic(0, tweenDuration))
            .Append(material.TweenMetallicSpecular(1, tweenDuration))
            .Append(material.TweenRoughness(1, tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}