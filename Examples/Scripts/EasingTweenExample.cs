using Godot;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class EasingTweenExample : Node
{
    [Export] public Node2D Target1;
    [Export] public Node2D Target2;

    [Export] public Easing Easing1;
    [Export] public Curve Easing2;
	
    public override void _Ready()
    {
        GTween tween1 = Target1.TweenPositionX(100, 3);
        tween1.SetEasing(Easing1);
        tween1.Play();
        
        GTween tween2 = Target2.TweenPositionX(100, 3);
        tween2.SetEasing(Easing2);
        tween2.Play();
    }
}