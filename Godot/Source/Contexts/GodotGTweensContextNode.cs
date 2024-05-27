using Godot;

namespace GTweensGodot.Contexts;

public partial class GodotGTweensContextNode : Node
{
    public sealed override void _Ready()
    {
        ProcessMode = ProcessModeEnum.Always;
    }

    public sealed override void _Process(double delta)
    {
        float floatDelta = (float)delta;
        
        if (!GetTree().Paused)
        {
            GodotGTweensContext.Instance.NormalPausableContext.Tick(floatDelta);   
        }
        
        GodotGTweensContext.Instance.NormalUnpausableContext.Tick(floatDelta);
    }

    public sealed override void _PhysicsProcess(double delta)
    {
        float floatDelta = (float)delta;
        
        if (!GetTree().Paused)
        {
            GodotGTweensContext.Instance.PhysicsPausableContext.Tick(floatDelta);   
        }
        
        GodotGTweensContext.Instance.PhysicsUnpausableContext.Tick(floatDelta);
    }
}