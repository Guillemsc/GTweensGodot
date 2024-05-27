using Godot;
using GTweens.Enums;
using GTweensGodot.Extensions;
using GTweensGodot.Godot.Source.Enums;

namespace GTweensGodot.Examples;

public partial class PauseGameExample : Node
{
    [Export] public Node3D PausableTarget;
    [Export] public Node3D UnpausableTarget;

    [Export] public Button TogglePauseButton;

    public override void _Ready()
    {
        PausableTarget.TweenRotationDegreesX(360, 2, RotationMode.TotalDistance)
            .SetMaxLoops()
            .Play();
        
        UnpausableTarget.TweenRotationDegreesX(360, 2, RotationMode.TotalDistance)
            .SetMaxLoops()
            .PlayConfigured(ProcessType.Normal, true);

        TogglePauseButton.Connect("pressed", Callable.From(Toggle));
    }

    void Toggle()
    {
        GetTree().Paused = !GetTree().Paused;
    }
}