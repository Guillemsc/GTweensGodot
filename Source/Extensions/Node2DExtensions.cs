using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Source.Extensions;

public static class Node2DExtensions
{
    public static GTween TweenGlobalPosition(this Node2D node2D, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node2D.GlobalPosition,
            current => node2D.GlobalPosition = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalPositionX(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalPosition.X,
            current => node2D.GlobalPosition = new Vector2(current, node2D.GlobalPosition.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalPositionY(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalPosition.Y,
            current => node2D.GlobalPosition = new Vector2(node2D.GlobalPosition.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenPosition(this Node2D node2D, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node2D.Position,
            current => node2D.Position = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenPositionX(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Position.X,
            current => node2D.Position = new Vector2(current, node2D.Position.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenPositionY(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Position.Y,
            current => node2D.Position = new Vector2(node2D.Position.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalRotation(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalRotation,
            current => node2D.GlobalRotation = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenRotation(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Rotation,
            current => node2D.Rotation = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalRotationDegrees(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalRotationDegrees,
            current => node2D.GlobalRotationDegrees = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenRotationDegrees(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.RotationDegrees,
            current => node2D.RotationDegrees = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalScale(this Node2D node2D, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node2D.GlobalScale,
            current => node2D.GlobalScale = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalScaleX(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalScale.X,
            current => node2D.GlobalScale = new Vector2(current, node2D.GlobalScale.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalScaleY(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalScale.Y,
            current => node2D.GlobalScale = new Vector2(node2D.GlobalScale.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenScale(this Node2D node2D, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node2D.Scale,
            current => node2D.Scale = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenlScaleX(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Scale.X,
            current => node2D.Scale = new Vector2(current, node2D.Scale.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenScaleY(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Scale.Y,
            current => node2D.Scale = new Vector2(node2D.Scale.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenGlobalSkew(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.GlobalSkew,
            current => node2D.GlobalSkew = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
    
    public static GTween TweenSkew(this Node2D node2D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node2D.Skew,
            current => node2D.Skew = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node2D)
        );
    }
}