using System.Threading;
using System.Threading.Tasks;
using Godot;
using GTweens.Easings;
using GTweens.Tweens;
using GTweensGodot.Extensions;

namespace GTweensGodot.Examples;

public partial class PlayAsyncTweenExample : Node
{
    [Export] public Node2D Target;
	
    public override void _Ready()
    {
        Execute(CancellationToken.None);
    }

    async Task Execute(CancellationToken cancellationToken)
    {
        GTween tween = Target.TweenPosition(new Vector2(100, 0), 1);
        tween.SetEasing(Easing.InOutCubic);
        await tween.PlayAsync(cancellationToken);
        
        GTween tween2 = Target.TweenPosition(new Vector2(0, 0), 1);
        tween2.SetEasing(Easing.InOutCubic);
        await tween2.PlayAsync(cancellationToken);
    }
}