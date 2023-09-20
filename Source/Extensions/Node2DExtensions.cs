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
            () => GodotObject.IsInstanceValid(node2D)
        );
    }
}