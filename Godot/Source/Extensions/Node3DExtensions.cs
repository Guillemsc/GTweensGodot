using Godot;
using GTweens.Enums;
using GTweens.Extensions;
using GTweens.Tweens;

namespace GTweensGodot.Extensions;

public static class Node3DExtensions
{
    public static GTween TweenGlobalPosition(this Node3D target, Vector3 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GlobalPosition,
            current => target.GlobalPosition = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionX(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.X,
            current => target.GlobalPosition = new Vector3(current, target.GlobalPosition.Y, target.GlobalPosition.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionY(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.Y,
            current => target.GlobalPosition = new Vector3(target.GlobalPosition.X, current, target.GlobalPosition.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionZ(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalPosition.Z,
            current => target.GlobalPosition = new Vector3(target.GlobalPosition.X, target.GlobalPosition.Y, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionXY(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.GlobalPosition.X, target.GlobalPosition.Y),
            current => target.GlobalPosition = new Vector3(current.X, current.Y, target.GlobalPosition.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionXZ(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.GlobalPosition.X, target.GlobalPosition.Z),
            current => target.GlobalPosition = new Vector3(current.X, target.GlobalPosition.Y, current.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalPositionYZ(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.GlobalPosition.Y, target.GlobalPosition.Z),
            current => target.GlobalPosition = new Vector3(target.GlobalPosition.X, current.X, current.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPosition(this Node3D target, Vector3 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Position,
            current => target.Position = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionX(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.X,
            current => target.Position = new Vector3(current, target.Position.Y, target.Position.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionY(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.Y,
            current => target.Position = new Vector3(target.Position.X, current, target.Position.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionZ(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Position.Z,
            current => target.Position = new Vector3(target.Position.X, target.Position.Y, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionXY(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.Position.X, target.Position.Y),
            current => target.Position = new Vector3(current.X, current.Y, target.Position.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionXZ(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.Position.X, target.Position.Z),
            current => target.Position = new Vector3(current.X, target.Position.Y, current.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenPositionYZ(this Node3D target, Vector2 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => new Vector2(target.Position.Y, target.Position.Z),
            current => target.Position = new Vector3(target.Position.X, current.X, current.Y), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotation(this Node3D target, Vector3 to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GlobalRotation,
            current => target.GlobalRotation = current,
            () => AngleExtensions.GetDestinationAngleRadiants(target.GlobalRotation, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationX(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotation.X,
            current => target.GlobalRotation = new Vector3(current, target.GlobalRotation.Y, target.GlobalRotation.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.GlobalRotation.X, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationY(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotation.Y,
            current => target.GlobalRotation = new Vector3(target.GlobalRotation.X, current, target.GlobalRotation.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.GlobalRotation.Y, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationZ(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotation.Z,
            current => target.GlobalRotation = new Vector3(target.GlobalRotation.X, target.GlobalRotation.Y, current), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.GlobalRotation.Z, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotation(this Node3D target, Vector3 to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Rotation,
            current => target.Rotation = current,
            () => AngleExtensions.GetDestinationAngleRadiants(target.Rotation, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationX(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.Rotation.X,
            current => target.Rotation = new Vector3(current, target.Rotation.Y, target.Rotation.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.Rotation.X, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationY(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.Rotation.Y,
            current => target.Rotation = new Vector3(target.Rotation.X, current, target.Rotation.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.Rotation.Y, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationZ(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.Rotation.Z,
            current => target.Rotation = new Vector3(target.Rotation.X, target.Rotation.Y, current), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleRadiants(target.Rotation.X, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationDegrees(this Node3D target, Vector3 to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenGodotExtensions.Tween(
            () => target.GlobalRotationDegrees,
            current => target.GlobalRotationDegrees = current, 
            () => AngleExtensions.GetDestinationAngleDegrees(target.GlobalRotationDegrees, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationDegreesX(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotationDegrees.X,
            current => target.GlobalRotationDegrees = new Vector3(current, target.GlobalRotationDegrees.Y, target.GlobalRotationDegrees.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.GlobalRotationDegrees.X, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationDegreesY(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotationDegrees.Y,
            current => target.GlobalRotationDegrees = new Vector3(target.GlobalRotationDegrees.X, current, target.GlobalRotationDegrees.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.GlobalRotationDegrees.Y, to, rotationMode),  
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenGlobalRotationDegreesZ(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.GlobalRotationDegrees.Z,
            current => target.GlobalRotationDegrees = new Vector3(target.GlobalRotationDegrees.X, target.GlobalRotationDegrees.Y, current), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.GlobalRotationDegrees.Z, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegrees(this Node3D target, Vector3 to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenGodotExtensions.Tween(
            () => target.RotationDegrees,
            current => target.RotationDegrees = current, 
            () => AngleExtensions.GetDestinationAngleDegrees(target.RotationDegrees, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegreesX(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.RotationDegrees.X,
            current => target.RotationDegrees = new Vector3(current, target.RotationDegrees.Y, target.RotationDegrees.Z),
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.RotationDegrees.X, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegreesY(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.RotationDegrees.Y,
            current => target.RotationDegrees = new Vector3(target.RotationDegrees.X, current, target.RotationDegrees.Z), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.RotationDegrees.Y, to, rotationMode),
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenRotationDegreesZ(this Node3D target, float to, float duration, RotationMode rotationMode = RotationMode.ShortestDistance)
    {
        return GTweenExtensions.Tween(
            () => target.RotationDegrees.Z,
            current => target.RotationDegrees = new Vector3(target.RotationDegrees.X, target.RotationDegrees.Y, current), 
            () => GTweens.Extensions.AngleExtensions.GetDestinationAngleDegrees(target.RotationDegrees.Z, to, rotationMode), 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScale(this Node3D target, Vector3 to, float duration)
    {
        return GTweenGodotExtensions.Tween(
            () => target.Scale,
            current => target.Scale = current, 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleX(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.X,
            current => target.Scale = new Vector3(current, target.Scale.Y, target.Scale.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleY(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.Y,
            current => target.Scale = new Vector3(target.Scale.X, current, target.Scale.Z), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
    
    public static GTween TweenScaleZ(this Node3D target, float to, float duration)
    {
        return GTweenExtensions.Tween(
            () => target.Scale.Z,
            current => target.Scale = new Vector3(target.Scale.X, target.Scale.Y, current), 
            to, 
            duration,
            GodotObjectExtensions.GetGodotObjectValidationFunction(target)
        );
    }
}