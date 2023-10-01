using Godot;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class PlayTweenExample : Node
{
	[Export] public Node2D Target;
	
	public override void _Ready()
	{
		GTween tween = Target.TweenPosition(new Vector2(100, 0), 3);
		tween.SetEasing(Easing.InOutCubic);
		tween.Play();
	}
}