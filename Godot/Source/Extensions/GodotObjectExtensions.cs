using Godot;
using GTweens.Delegates;

namespace GTweensGodot.Extensions;

public static class GodotObjectExtensions
{
    public static ValidationDelegates.Validation GetGodotObjectValidationFunction(GodotObject godotObject) 
        => () => GodotObject.IsInstanceValid(godotObject);
}