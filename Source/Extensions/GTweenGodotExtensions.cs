using Godot;
using GTweens.Delegates;
using GTweens.TweenBehaviours;
using GTweens.Tweeners;
using GTweens.Tweens;
using GTweensGodot.Tweeners;
using GodotGTweensContextNode = GTweensGodot.Contexts.GodotGTweensContextNode;

namespace GTweensGodot.Extensions;

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
    
    public static GTween To(
        Tweener<Vector3>.Getter currValueGetter, 
        Tweener<Vector3>.Setter setter,
        Tweener<Vector3>.Getter finalValueGetter, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotVector3Tweener(currValueGetter, setter, finalValueGetter, duration, validation));
        return new GTween(tweenBehaviour);
    }
    
    public static GTween To(
        Tweener<Color>.Getter currValueGetter, 
        Tweener<Color>.Setter setter,
        Tweener<Color>.Getter finalValueGetter, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotColorTweener(currValueGetter, setter, finalValueGetter, duration, validation));
        return new GTween(tweenBehaviour);
    }
}