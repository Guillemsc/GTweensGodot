using GTweens.Contexts;

namespace GTweensGodot.Contexts;

public class GodotGTweensContext
{
    public static GodotGTweensContext Instance = new();
    
    public GTweensContext Context { get; } = new();

    GodotGTweensContext()
    {
        
    }
}