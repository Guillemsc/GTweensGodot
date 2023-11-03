using Godot;
using GTweens.Enums;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class LoopingTweenExample : Node
{
    [Export] public Node2D Target;
    [Export] public int Loops;
    [Export] public ResetMode ResetMode = ResetMode.InitialValues;
	
    public override void _Ready()
    {
        GTween tween = Target.TweenPositionX(150, 1);
        tween.SetLoops(Loops, ResetMode);
        tween.Play();
    }
}