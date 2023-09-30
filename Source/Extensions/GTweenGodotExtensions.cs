using System;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using GTweens.Delegates;
using GTweens.Extensions;
using GTweens.TweenBehaviours;
using GTweens.Tweeners;
using GTweens.Tweens;
using GTweensGodot.Tweeners;
using GodotGTweensContextNode = GTweensGodot.Contexts.GodotGTweensContextNode;

namespace GTweensGodot.Extensions;

public static class GTweenGodotExtensions
{
    public static GTween Tween(
        Tweener<Vector2>.Getter getter, 
        Tweener<Vector2>.Setter setter,
        Vector2 to, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotVector2Tweener(getter, setter, to, duration, validation));
        return new GTween(tweenBehaviour);
    }
    
    public static GTween Tween(
        Tweener<Vector2>.Getter getter, 
        Tweener<Vector2>.Setter setter,
        Vector2 to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Vector2I>.Getter getter, 
        Tweener<Vector2I>.Setter setter,
        Vector2I to, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotVector2ITweener(getter, setter, to, duration, validation));
        return new GTween(tweenBehaviour);
    }
    
    public static GTween Tween(
        Tweener<Vector2I>.Getter getter, 
        Tweener<Vector2I>.Setter setter,
        Vector2I to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Vector3>.Getter getter, 
        Tweener<Vector3>.Setter setter,
        Vector3 to, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotVector3Tweener(getter, setter, to, duration, validation));
        return new GTween(tweenBehaviour);
    }
    
    public static GTween Tween(
        Tweener<Vector3>.Getter getter, 
        Tweener<Vector3>.Setter setter,
        Vector3 to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Color>.Getter getter, 
        Tweener<Color>.Setter setter,
        Color to, 
        float duration, 
        ValidationDelegates.Validation validation
    )
    {
        InterpolationTweenBehaviour tweenBehaviour = new InterpolationTweenBehaviour();
        tweenBehaviour.Add(new GodotColorTweener(getter, setter, to, duration, validation));
        return new GTween(tweenBehaviour);
    }
    
    public static GTween Tween(
        Tweener<Color>.Getter getter, 
        Tweener<Color>.Setter setter,
        Color to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    

    public static GTween SetEasing(this GTween gTween, Curve curve)
    {
        if (curve == null)
        {
            throw new ArgumentNullException(
                $"Tried to {nameof(SetEasing)} on a {nameof(GTween)} with a null {nameof(Curve)}"
            );
        }

        return gTween.SetEasing(curve.ToEasingDelegate());
    }
    
    public static void Play(this GTween tween)
    {
        GodotGTweensContextNode.Context.Play(tween);
    }
    
    public static Task PlayAsync(this GTween gTween, CancellationToken cancellationToken)
    {
        gTween.Play();

        cancellationToken.Register(gTween.Kill);
            
        return gTween.AwaitCompleteOrKill(cancellationToken);
    }
}