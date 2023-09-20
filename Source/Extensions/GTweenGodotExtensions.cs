using Godot;
using GTweens.Delegates;
using GTweens.TweenBehaviours;
using GTweens.Tweeners;
using GTweens.Tweens;
using GTweensGodot.Source.Contexts;
using GTweensGodot.Source.Tweeners;

namespace GTweensGodot.Source.Extensions;

public static class GTweenGodotExtensions
{
    public static void Play(this GTween tween)
    {
        GodotGTweensContextNode.Context.Play(tween);
    }
    
    public static GTween To(
        Tweener<Vector2>.Getter currValueGetter, 
        Tweener<Vector2>.Setter setter,
        Tweener<Vector2>.Getter finalValueGetter, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotVector2Tweener(currValueGetter, setter, finalValueGetter, duration, validation));
        return new GTween(tweenBehaviour);
    }
}