using GTweens.Contexts;

namespace GTweensGodot.Contexts;

/// <summary>
/// Represents a context for managing tweens in the Godot environment.
/// </summary>
public class GodotGTweensContext
{
    public static readonly GodotGTweensContext Instance = new();
    
    /// <summary>
    /// Gets the unpausable context for managing tweens.
    /// This process runs on the _Process method.
    /// This context is always running, even when GetTree().Paused is set to true.
    /// </summary>
    public GTweensContext NormalUnpausableContext { get; } = new();
    
    /// <summary>
    /// Gets the phsics pausable context for managing tweens.
    /// This process runs on the _Process method.
    /// This context is stops running when GetTree().Paused is set to true.
    /// </summary>
    public GTweensContext NormalPausableContext { get; } = new();
    
    /// <summary>
    /// Gets the unpausable context for managing tweens.
    /// This process runs on the _PhysicsProcess method.
    /// This context is always running, even when GetTree().Paused is set to true.
    /// </summary>
    public GTweensContext PhysicsUnpausableContext { get; } = new();
    
    /// <summary>
    /// Gets the physics pausable context for managing tweens.
    /// This process runs on the _PhysicsProcess method.
    /// This context is stops running when GetTree().Paused is set to true.
    /// </summary>
    public GTweensContext PhysicsPausableContext { get; } = new();

    GodotGTweensContext() { }
}