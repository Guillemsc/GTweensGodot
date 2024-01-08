using GTweens.Contexts;

namespace GTweensGodot.Contexts;

public class GodotGTweensContext
{
    public static readonly GodotGTweensContext Instance = new();
    
    public GTweensContext Context { get; } = new();

    GodotGTweensContext()
    {
        
    }
}