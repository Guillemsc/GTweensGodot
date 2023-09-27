using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class ControlExtensions
{
    public static GTween TweenGlobalPosition(this Control target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => target.GlobalPosition,
            current => target.GlobalPosition = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionX(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.X,
            current => target.GlobalPosition = new Vector2(current, target.GlobalPosition.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionY(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.Y,
            current => target.GlobalPosition = new Vector2(target.GlobalPosition.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPosition(this Control target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => target.Position,
            current => target.Position = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionX(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.X,
            current => target.Position = new Vector2(current, target.Position.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionY(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.Y,
            current => target.Position = new Vector2(target.Position.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotation(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Rotation,
            current => target.Rotation = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegreesWithin180Range(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.RotationDegrees,
            current => target.RotationDegrees = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegrees(this Control target, float to, float duration)
    {
        return target.TweenRotation(to * MathExtensions.Deg2Rad, duration);
    }
    
    public static GTween TweenScale(this Control target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => target.Scale,
            current => target.Scale = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleX(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.X,
            current => target.Scale = new Vector2(current, target.Scale.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleY(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.Y,
            current => target.Scale = new Vector2(target.Scale.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSize(this Control target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => target.Size,
            current => target.Size = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSizeX(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Size.X,
            current => target.Size = new Vector2(current, target.Size.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenSizeY(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Size.Y,
            current => target.Size = new Vector2(target.Size.X, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPivotOffset(this Control target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => target.PivotOffset,
            current => target.PivotOffset = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPivotOffsetX(this Control target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.PivotOffset.X,
            current => target.PivotOffset = new Vector2(current, target.PivotOffset.Y), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}