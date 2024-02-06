using GTweens.Contexts;

namespace GTweensGodot.Contexts;

/// <summary>
/// Represents a context for managing tweens in the Godot environment.
/// </summary>
public class GodotGTweensContext
{
    public static readonly GodotGTweensContext Instance = new();
    
    /// <summary>
    /// Gets the unpausable context for managing tweens. This context is always running, even when GetTree().Paused
    /// is set to true.
    /// </summary>
    public GTweensContext UnpausableContext { get; } = new();
    
    /// <summary>
    /// Gets the pausable context for managing tweens. This context is stops running when GetTree().Paused
    /// is set to true.
    /// </summary>
    public GTweensContext PausableContext { get; } = new();

    GodotGTweensContext() { }
}