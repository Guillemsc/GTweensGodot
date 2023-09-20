using Godot;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Node3DExtensions
{
    public static GTween TweenGlobalPosition(this Node3D node3D, Vector3 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node3D.GlobalPosition,
            current => node3D.GlobalPosition = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenGlobalPositionX(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.GlobalPosition.X,
            current => node3D.GlobalPosition = new Vector3(current, node3D.GlobalPosition.Y, node3D.GlobalPosition.Z), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenGlobalPositionY(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.GlobalPosition.Y,
            current => node3D.GlobalPosition = new Vector3(node3D.GlobalPosition.X, current, node3D.GlobalPosition.Z), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenGlobalPositionZ(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.GlobalPosition.Z,
            current => node3D.GlobalPosition = new Vector3(node3D.GlobalPosition.X, node3D.GlobalPosition.Y, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenPosition(this Node3D node3D, Vector3 to, float duration)
    {
        return GTweenGodotExtensions.To(
            () => node3D.Position,
            current => node3D.Position = current, 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenPositionX(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.Position.X,
            current => node3D.Position = new Vector3(current, node3D.Position.Y, node3D.Position.Z), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenPositionY(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.Position.Y,
            current => node3D.Position = new Vector3(node3D.Position.X, current, node3D.Position.Z), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
    
    public static GTween TweenPositionZ(this Node3D node3D, float to, float duration)
    {
        return GTweenExtensions.To(
            () => node3D.Position.Z,
            current => node3D.Position = new Vector3(node3D.Position.X, node3D.Position.Y, current), 
            () => to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(node3D)
        );
    }
}