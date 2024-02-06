using Godot;

namespace GTweensGodot.Contexts;

public partial class GodotGTweensContextNode : Node
{
    public override void _Ready()
    {
        ProcessMode = ProcessModeEnum.Always;
    }

    public override void _Process(double delta)
    {
        float floatDelta = (float)delta;
        
        if (!GetTree().Paused)
        {
            GodotGTweensContext.Instance.PausableContext.Tick(floatDelta);   
        }
        
        GodotGTweensContext.Instance.UnpausableContext.Tick(floatDelta);
    }
}