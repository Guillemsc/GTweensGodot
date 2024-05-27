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
using GTweensGodot.Godot.Source.Enums;
using GTweensGodot.Tweeners;

namespace GTweensGodot.Extensions;

public static class GTweenGodotExtensions
{
    public static GTween Tween(
        Tweener<Vector2>.Getter getter, 
        Tweener<Vector2>.Setter setter,
        Tweener<Vector2>.Getter to, 
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
        float duration,
        ValidationDelegates.Validation validation
    ) => Tween(getter, setter, () => to, duration, validation);
    
    public static GTween Tween(
        Tweener<Vector2>.Getter getter, 
        Tweener<Vector2>.Setter setter,
        Vector2 to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Vector2I>.Getter getter, 
        Tweener<Vector2I>.Setter setter,
        Tweener<Vector2I>.Getter to, 
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
        float duration,
        ValidationDelegates.Validation validation
    ) => Tween(getter, setter, () => to, duration, validation);
    
    public static GTween Tween(
        Tweener<Vector2I>.Getter getter, 
        Tweener<Vector2I>.Setter setter,
        Vector2I to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Vector3>.Getter getter, 
        Tweener<Vector3>.Setter setter,
        Tweener<Vector3>.Getter to, 
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
        float duration,
        ValidationDelegates.Validation validation
    ) => Tween(getter, setter, () => to, duration, validation);
    
    public static GTween Tween(
        Tweener<Vector3>.Getter getter, 
        Tweener<Vector3>.Setter setter,
        Vector3 to, 
        float duration
    ) => Tween(getter, setter, to, duration, ValidationExtensions.AlwaysValid);
    
    public static GTween Tween(
        Tweener<Color>.Getter getter, 
        Tweener<Color>.Setter setter,
        Tweener<Color>.Getter to, 
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
        float duration, 
        ValidationDelegates.Validation validation
    ) => Tween(getter, setter, () => to, duration, validation);
    
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
    /// Plays the specified tween in a configured context based on the provided process type and pause behaviour.
    /// </summary>
    /// <param name="tween">The tween instance to play.</param>
    /// <param name="processType">The type of process mode in which to play the tween. It can be either normal or physics.</param>
    /// <param name="unpausable"> If unpausable is set to true, the tween will never pause, even when GetTree().Paused is set to true.</param>
    public static void PlayConfigured(this GTween tween, ProcessType processType, bool unpausable)
    {
        switch (processType)
        {
            default:
            {
                if (unpausable)
                {
                    GodotGTweensContext.Instance.NormalUnpausableContext.Play(tween);
                }
                else
                {
                    GodotGTweensContext.Instance.NormalPausableContext.Play(tween);
                }
                break;
            }
            
            case ProcessType.Physics:
            {
                if (unpausable)
                {
                    GodotGTweensContext.Instance.PhysicsUnpausableContext.Play(tween);
                }
                else
                {
                    GodotGTweensContext.Instance.PhysicsPausableContext.Play(tween);
                }
                break;
            }
        }
    }
    
    /// <summary>
    /// Plays a GTween. This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="tween">The GTween to play.</param>
    /// <remarks>This method will play in ProcesType <see cref="ProcessType.Normal"/> and be unpausable.</remarks>
    public static void Play(this GTween tween)
    {
        tween.PlayConfigured(ProcessType.Normal, false);
    }
    
    /// <summary>
    /// Plays a GTween. This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="tween">The GTween to play.</param>
    /// <param name="processType">The type of process mode in which to play the tween. It can be either normal or physics.</param>
    /// <param name="unpausable"> If unpausable is set to true, the tween will never pause, even when GetTree().Paused is set to true.</param>
    /// <param name="instantly">If set to true, sets the tween as completed after playing, making it reach the end instantly.</param>
    public static void PlayConfigured(this GTween tween, ProcessType processType, bool unpausable, bool instantly)
    {
        tween.PlayConfigured(processType, unpausable);

        if (instantly)
        {
            tween.Complete();   
        }
    }

    /// <summary>
    /// Plays a GTween. This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="tween">The GTween to play.</param>
    /// <param name="instantly">If set to true, sets the tween as completed after playing, making it reach the end instantly.</param>
    /// <remarks>This method will play in ProcesType <see cref="ProcessType.Normal"/> and be unpausable.</remarks>
    public static void Play(this GTween tween, bool instantly)
    {
        tween.PlayConfigured(ProcessType.Normal, instantly, false);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="processType">The type of process mode in which to play the tween. It can be either normal or physics.</param>
    /// <param name="unpausable"> If unpausable is set to true, the tween will never pause, even when GetTree().Paused is set to true.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static Task PlayConfiguredAsync(this GTween gTween, ProcessType processType, bool unpausable, CancellationToken cancellationToken)
    {
        gTween.PlayConfigured(processType, false);

        cancellationToken.Register(gTween.Kill);
            
        return gTween.AwaitCompleteOrKill(cancellationToken);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <remarks>This method will play in ProcesType <see cref="ProcessType.Normal"/> and be unpausable.</remarks>
    public static Task PlayAsync(this GTween gTween, CancellationToken cancellationToken)
    {
        return gTween.PlayConfiguredAsync(ProcessType.Normal, false, cancellationToken);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="processType">The type of process mode in which to play the tween. It can be either normal or physics.</param>
    /// <param name="unpausable"> If unpausable is set to true, the tween will never pause, even when GetTree().Paused is set to true.</param>
    /// <param name="instantly">If set to true, sets the tween as completed after playing, making it reach the end instantly.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static Task PlayConfiguredAsync(this GTween gTween, ProcessType processType, bool unpausable, bool instantly, CancellationToken cancellationToken)
    {
        if (!instantly)
        {
            return gTween.PlayConfiguredAsync(processType, unpausable, cancellationToken);
        }
        
        gTween.PlayConfigured(processType, unpausable);
        gTween.Complete();
        
        return Task.CompletedTask;
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="instantly">If set to true, sets the tween as completed after playing, making it reach the end instantly.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <remarks>This method will play in ProcesType <see cref="ProcessType.Normal"/> and be unpausable.</remarks>
    public static Task PlayAsync(this GTween gTween, bool instantly, CancellationToken cancellationToken)
    {
        return gTween.PlayConfiguredAsync(ProcessType.Normal, instantly, cancellationToken);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="processType">The type of process mode in which to play the tween. It can be either normal or physics.</param>
    /// <param name="unpausable"> If unpausable is set to true, the tween will never pause, even when GetTree().Paused is set to true.</param>
    /// <param name="completeToken">A token to complete the GTween's execution.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    public static Task PlayConfiguredAsync(
        this GTween gTween, 
        ProcessType processType, 
        bool unpausable, 
        CancellationToken completeToken, 
        CancellationToken cancellationToken
        )
    {
        gTween.PlayConfigured(processType, unpausable);

        cancellationToken.Register(gTween.Kill);
        completeToken.Register(gTween.Complete);
            
        return gTween.AwaitCompleteOrKill(cancellationToken);
    }
    
    /// <summary>
    /// Asynchronously plays a GTween and awaits its completion or cancellation.
    /// If the cancellationToken cancellation is requested, the tween will be killed.
    /// This tween will be paused when GetTree().Paused is set to true.
    /// </summary>
    /// <param name="gTween">The GTween to play.</param>
    /// <param name="completeToken">A token to complete the GTween's execution.</param>
    /// <param name="cancellationToken">A token to cancel the GTween's execution.</param>
    /// <returns>A Task representing the asynchronous operation.</returns>
    /// <remarks>This method will play in ProcesType <see cref="ProcessType.Normal"/> and be unpausable.</remarks>
    public static Task PlayAsync(this GTween gTween, CancellationToken completeToken, CancellationToken cancellationToken)
    {
        return gTween.PlayConfiguredAsync(ProcessType.Normal, false, completeToken, cancellationToken);
    }
}