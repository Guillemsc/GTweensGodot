using Godot;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class LoopingTweenExample : Node
{
    [Export] public Node2D Target;
    [Export] public int Loops;
	
    public override void _Ready()
    {
        GTween tween = Target.TweenPositionX(150, 1);
        tween.SetLoops(Loops);
        tween.Play();
    }
}