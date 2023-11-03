using System;
using System.Threading;
using System.Threading.Tasks;
using Godot;
using GTweens.Delegates;
using GTweens.Extensions;
using GTweens.TweenBehaviours;
using GTweens.Tweeners;
using GTweens.Tweens;
using GTweensGodot.Contexts;
using GTweensGodot.Tweeners;

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
    
    /// <summary>
    /// Sets the easing function for a GTween using a specified Curve.
    /// </summary>
    /// <param name="gTween">The GTween to set the easing function for.</param>
    /// <param name="curve">The Curve representing the desired easing behavior.</param>
    /// <returns>The modified GTween with the specified easing function.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="curve"/> is null.</exception>
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
    
    /// <summary>
    /// Plays a GTween.
    /// </summary>
    /// <param name="tween">The GTween to play.</param>
    public static void Play(this GTween tween)
    {
        GodotGTweensContext.Instance.Context.Play(tween);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static Task PlayAsync(this GTween gTween, CancellationToken cancellationToken)
    {
        gTween.Play();

        cancellationToken.Register(gTween.Kill);
            
        return gTween.AwaitCompleteOrKill(cancellationToken);
    }
}