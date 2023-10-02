using Godot;
using GTweens.Builders;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class ShaderMaterialExample : Node
{
    [Export] public GeometryInstance3D Target;
	
    public override void _Ready()
    {
        float tweenDuration = 0.5f;

        const string albedo = "albedo";

        ShaderMaterial material = (ShaderMaterial)Target.MaterialOverride;
        
        GTween tween = GTweenSequenceBuilder.New()
            .Append(material.TweenPropertyColor(albedo, new Color(0, 0, 0), tweenDuration))
            .Append(material.TweenPropertyColorAlpha(albedo, 0, tweenDuration))
            .Append(material.TweenPropertyColorAlpha(albedo, 1, tweenDuration))
            .Append(material.TweenPropertyColorRgb(albedo, Color.FromHtml("557cff"), tweenDuration))
            .Build();
        
        tween.SetEasing(Easing.InOutCubic);
        tween.Play();
    }
}