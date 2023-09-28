using Godot;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples.Scripts;

public partial class GenericTweeningExample : Node
{
    [Export] public Node2D Target;
	
    public override void _Ready()
    {
        GTween tween = GTweenGodotExtensions.Tween(
            () => Target.Position,
            x => Target.Position = x, 
            new Vector2(100, 100),
            1
        );
        tween.Play();
    }
}