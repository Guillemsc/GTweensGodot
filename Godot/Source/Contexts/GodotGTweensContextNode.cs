using Godot;
using GTweens.Contexts;

namespace GTweensGodot.Contexts;

public partial class GodotGTweensContextNode : Node
{
    public static GTweensContext Context { get; } = new();
    
    public override void _Process(double delta)
    {
        Context.Tick((float)delta);
    }
}