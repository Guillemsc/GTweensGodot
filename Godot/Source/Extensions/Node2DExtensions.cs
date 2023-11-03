using Godot;
using GTweens.Enums;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Node2DExtensions
{
    public static GTween TweenGlobalPosition(this Node2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GlobalPosition,
            current => target.GlobalPosition = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionX(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.X,
            current => target.GlobalPosition = new Vector2(current, target.GlobalPosition.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionY(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.Y,
            current => target.GlobalPosition = new Vector2(target.GlobalPosition.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPosition(this Node2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Position,
            current => target.Position = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionX(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.X,
            current => target.Position = new Vector2(current, target.Position.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionY(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.Y,
            current => target.Position = new Vector2(target.Position.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotation(this Node2D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotation,
            current => target.GlobalRotation = current, 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.GlobalRotation, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotation(this Node2D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.Rotation,
            current => target.Rotation = current, 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.Rotation, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationDegrees(this Node2D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotationDegrees,
            current => target.GlobalRotationDegrees = current, 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.GlobalRotationDegrees, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegrees(this Node2D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.RotationDegrees,
            current => target.RotationDegrees = current, 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.RotationDegrees, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalScale(this Node2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GlobalScale,
            current => target.GlobalScale = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalScaleX(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalScale.X,
            current => target.GlobalScale = new Vector2(current, target.GlobalScale.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalScaleY(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalScale.Y,
            current => target.GlobalScale = new Vector2(target.GlobalScale.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScale(this Node2D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Scale,
            current => target.Scale = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleX(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.X,
            current => target.Scale = new Vector2(current, target.Scale.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleY(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.Y,
            current => target.Scale = new Vector2(target.Scale.X, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalSkew(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalSkew,
            current => target.GlobalSkew = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSkew(this Node2D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Skew,
            current => target.Skew = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}