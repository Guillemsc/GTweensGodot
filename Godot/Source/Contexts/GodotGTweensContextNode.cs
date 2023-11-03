using Godot;

namespace GTweensGodot.Contexts;

public partial class GodotGTweensContextNode : Node
{
    public override void _Process(double delta)
    {
        GodotGTweensContext.Instance.Context.Tick((float)delta);
    }
}