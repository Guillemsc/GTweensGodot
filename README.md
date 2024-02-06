[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![Release](https://img.shields.io/github/release/Guillemsc/GTweensGodot.svg)](#from-releases)
[![NuGet](https://img.shields.io/nuget/v/GTweensGodot.svg?label=nuget)](#from-nuget)
[![Downloads](https://img.shields.io/nuget/dt/GTweensGodot)](https://www.nuget.org/packages/GTweensGodot)
[![Tests](https://github.com/Guillemsc/GTweens/actions/workflows/tests.yml/badge.svg)](https://github.com/Guillemsc/GTweens/actions/workflows/tests.yml)
[![Twitter Follow](https://img.shields.io/badge/twitter-%406uillem-blue.svg?label=Follow)](https://twitter.com/6uillem)
<img src="https://img.shields.io/badge/Godot-v4.x-%23478cbf?logo=godot-engine&logoColor=cyian&color=green">
[![Contributions welcome](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/Guillemsc/GTweensGodot/blob/main/CONTRIBUTING.md)

![LogoWide](https://github.com/Guillemsc/GTweensGodot/assets/17142208/704636fa-27da-42c3-b9c5-a5bc6e6a870c)

GTweens-Godot is a lightweight and versatile tweening library for Godot 4 with C#. 
This library simplifies the process of creating animations and transitions in your Godot projects, allowing you to bring your game elements to life with ease.

Unlike the default Godot tweening engine, which relies on nodes and their string properties to create animations, this tweening engine doesn't require the use of nodes. 

An extension that builds upon the [GTweens](https://github.com/Guillemsc/GTweens) library.

## 🍰 Features
- **Simple API**: GTweens-Godot provides an intuitive and easy-to-use API with C# extension methods.
    ```csharp
    public partial class TweenExample : Node
    {
        [Export] public Node2D Target;
		
        public override void _Ready()
        {
            Target.TweenPosition(new Vector2(100, 0), 3)
                .SetEasing(Easing.InOutCubic)
                .Play();
        }
    }
    ```

- **Sequencing**: Easily chain multiple tweens together to create complex sequences of animations.
    ```csharp
    public partial class PlayTweenSequenceExample : Node
    {
        [Export] public Node2D Target;
		
        public override void _Ready()
        {
            GTween tween = GTweenSequenceBuilder.New()
                .Append(Target.TweenPositionX(100f, 0.5f))
                    .Join(Target.TweenScale(new Vector2(2f, 2f), 1f))
                .AppendTime(0.5f)
                    .JoinCallback(() => GD.Print("I'm waiting some time!"))
                .Append(Target.TweenPositionX(0f, 1f))
                .AppendCallback(() => GD.Print("I'm finished!"))
                .Build();

            tween.SetEasing(Easing.InOutCubic);
            tween.Play();
        }
    }
    ```

- **Versatile Easing Functions**: Choose from a variety of easing functions to achieve different animation effects, including linear, ease-in, ease-out, and custom curves.
    ```csharp
    public partial class EasingExample : Node
    {
        [Export] public Node2D Target1;
        [Export] public Node2D Target2;
	
        [Export] public Easing Easing1;
        [Export] public Curve Easing2;
		
        public override void _Ready()
        {
            GTween tween1 = Target1.TweenPositionX(100, 3);
            tween1.SetEasing(Easing1);
            tween1.Play();
	        
            GTween tween2 = Target2.TweenPositionX(100, 3);
            tween2.SetEasing(Easing2);
            tween2.Play();
        }
    }
    ```
  
- **Looping**: Create looping animations with a single line of code, and control loop count and behavior.
    ```csharp
    public partial class LoopingTweenExample : Node
    {
        [Export] public Node2D Target;
        [Export] public int Loops;
		
        public override void _Ready()
        {
             GTween tween = Target.TweenPositionX(150, 1);
             tween.SetLoops(Loops);
             tween.Play();
        }
    }
    ```
  
- **Delays**: Specify delays, allowing precise timing of your animations.
    ```csharp
    GTween tween = GTweenSequenceBuilder.New()
        .AppendTime(0.5f)
        .Build();
    ```

- **Callbacks**: Attach callbacks to tweens for event handling at various points in the animation timeline.
    ```csharp
    void Callback()
    {
    }

    GTween tween = GTweenSequenceBuilder.New()
        .AppendCallback(Callback)
        .Build();
    ```
- **Async support**: GTweens uses the full power of C# and async tasks:
    ```csharp
    async Task RunSomething(CancellationToken)
    {
        await tween1.PlayAsync(cancellationToken);
        await tween2.PlayAsync(cancellationToken);
    }
    ```

- **Godot pause support**: GTweens supports changes to [GetTree().Paused](https://docs.godotengine.org/en/stable/tutorials/scripting/pausing_games.html):
    ```csharp
    tween.Play(); // Will be paused when GetTree().Paused is set to true
    tween.PlayUnpausable(); // Won't be paused when GetTree().Paused is set to true
    ```
  
- **Safety**: When a node that's being tweened becomes invalid or gets destroyed, the tween automatically handles that on a safe manner, and kills itself.

## 📦 Installation

### Form Asset Library
1. Inside Godot, open the AssetLib tab.
   
![image](https://github.com/Guillemsc/GTweensGodot/assets/17142208/6d2aaa22-9d3a-462e-82af-38852bbee417)

2. Search for and select "GTweens (C#)".
   
![image](https://github.com/Guillemsc/GTweensGodot/assets/17142208/2ff4a54f-af89-49f3-93af-8cd65a9f2214)

3. Download then install the asset.

4. On the Godot editor, go to `Project/Project Settings/Autoload`, and select `GTweensGodot/Godot/Source/Contexts/GodotGTweensContextNode.cs` to be autoloaded.

### From NuGet:
1. Install the [GTweensGodot NuGet package](https://www.nuget.org/packages/GTweensGodot/) in your godot project.
2. Create a new node script, anywhere in your project, that's going to update all the tweens. Copy and paste the code from here:
    ```csharp
    public partial class GTweensGodotUpdater : GodotGTweensContextNode
    {
      
    }
    ```
3. On the Godot editor, go to `Project/Project Settings/Autoload`, and select the `GTweensGodotUpdater.cs` we just created, to be autoloaded.
   
    To quickly check if everything has been setup properly, you can create a new script with this code, and assign any `Node2D` to the `Target` export, and play it.
    ```csharp
    public partial class TweenExample : Node
    {
        [Export] public Node2D Target;
		
        public override void _Ready()
        {
            Target.TweenPosition(new Vector2(100, 0), 3)
               .SetEasing(Easing.InOutCubic)
               .Play();
        }
    }
    ```

### From releases:
1. [Download the latest GTweensGodot.zip release](https://github.com/Guillemsc/GTweensGodot/releases/latest).
2. Unpack the `GTweensGodot.zip` folder into the Godot's project root folder.
3. On the Godot editor, go to `Project/Project Settings/Autoload`, and select `GTweensGodot/Godot/Source/Contexts/GodotGTweensContextNode.cs` to be autoloaded.

> [!WARNING]
> If the example scenes cannot be opened, it probably means that the contents of `GTweensGodot.zip` were not placed on the root of your project,
> or that the extracted folder has been renamed. Make sure you don't change the path nor rename any folder, since this will break scene references.


## ✔️ After installing
> [!NOTE]
> (Except on NuGet installation) To quickly check if everything has been setup properly, you can go to `GTweensGodot/Godot/Examples/Scenes/` and open any of the example scenes. 
When you run any of those scenes, a simple functionality example should play.

> [!NOTE]
> If after playing an example scene, nothing moves or gets animated, this means that the `GodotGTweensContextNode.cs` has not been autoloaded. Make sure to properly follow the last installation step.

## 📚 Getting started
### Nomenclature
- Tween: a generic word that indicates some or multiple values being animated.
- Sequence: an combination of tweens that get animated as a group.

### Prefixes
Prefixes are important to use the most out of IntelliSense, so try to remember these:
- **Tween**: prefix for all tween shortcuts (operations that can be started directly from a known object, like a Node2D or a Control).
    ```csharp
    node2D.TweenPositionX(100f, 1f);
    control.TweenSizeY(200f, 2f);
    ```
- **Set**: prefix for all settings that can be chained to a tween.
    ```csharp
    myTween.SetLoops(4).SetEasing(Easing.InOutCubic);
    ```
- **On**: prefix for all callbacks that can be chained to a tween.
    ```csharp
    myTween.OnStart(myStartFunction).OnComplete(myCompleteFunction);
    ```
 
### Generic tweening
This is the most flexible way of tweening and allows you to tween almost any value.
```csharp
// For default C# values (int, float, etc)
GTweenExtensions.Tween(getter, setter, to, duration)

// For Godot specific values (Vector2, Vector3, etc)
GTweenGodotExtensions.Tween(getter, setter, to, duration)
```
- **Getter**: a delegate that returns the value of the property to tween. Can be written as a lambda like this: `() => myValue`
where `myValue` is the name of the property to tween.
- **Setter**: a delegate that sets the value of the property to tween. Can be written as a lambda like this: `x => myValue = x`
where `myValue` is the name of the property to tween.
- **To**: the end value to reach.
- **Duration**: the duration of the tween in seconds.
- **Validation** (optional): a delegate that every time the tween updates, checks if it should be running. Can be written as a lambda like this: `() => shouldKeepRunning`
where `shouldKeepRunning` is a boolean.
  
```csharp
// For default C# values
GTween tween = GTweenExtensions.Tween(
    () => Target.SomeFloat, // Getter
    x => Target.SomeFloat = x, // Setter
    100f, // To
    1 // Duration
);

// For Godot specific values
GTween tween = GTweenGodotExtensions.Tween(
    () => Target.Position, // Getter
    x => Target.Position = x, // Setter
    new Vector2(100f, 100f), // To
    1 // Duration
);
```

### Shortcut tweening
GTweem includes shortcuts for some known C# and Godot objects, like Node2D, Node3D, Control, etc. You can create a tween directly from a reference to these objects, like:
```csharp
node2D.TweenPositionX(100f, 1f);
node3D.TweenScale(new Vector3(2f, 2f, 2f), 1f);
﻿﻿﻿﻿﻿﻿﻿﻿control.TweenSizeY(200f, 2f);
```
See all [shortcuts you can use](#-shortcuts).

### Sequences
Sequences are a combination of tweens that get animated as a group. 
Sequences can be contained inside other sequences without any limit to the depth of the hierarchy.
To create sequences, you need to use the helper `GTweenSequenceBuilder`.
- First you call to start creating a new sequence with `GTweenSequenceBuilder.New()`.
- Next you `Append()` or `Join()` any tweens to the sequence.
	- **Append**: Adds the given tween to the end of the Sequence. This tween will play after all the previous tweens have finished.
	- **Join**: Inserts the given tween at the same time position of the last tween added to the Sequence. This tween will play at the same time as the previous tween.
- Finally you call `Build()` to get the generated sequence Tween.
```csharp
 GTween tween = GTweenSequenceBuilder.New()
    .Append(Target.TweenPositionX(100, 0.5f))
        .Join(Target.TweenScale(new Vector2(2, 2), 1))
    .Append(Target.TweenPositionY(100, 1))
    .AppendTime(0.5f)
    .Append(Target.TweenPositionX(0, 1))
    .AppendSequence(s => s
        .AppendTime(0.5f)
        .Append(Target.TweenPositionX(1, 1))
        )
    .AppendCallback(() => GD.Print("I'm finished!"))
    .Build();
        
tween.SetEasing(Easing.InOutCubic);
tween.Play();
```
As it can be seen on the example, you can Append/Join different things with the builder:
- Append/Join Callback: adds a callback that will be called when this part of the sequence is executed.
- Append/Join Time: adds a time delay (in seconds) to the sequence.
- Append/Join Sequence: creates a new `GTweenSequenceBuilder` and provides it through the action. Then it automatically builds it and adds the resulting tween to the sequence.

[Example of a complex sequence](https://github.com/Guillemsc/GTweensGodot/blob/main/Godot/Examples/Scripts/Cube3DExample.cs):

![ezgif com-gif-maker](https://github.com/Guillemsc/GTweensGodot/assets/17142208/92e01c51-a9e8-43c4-a5d8-280ea03d4ae9)

### Tween controls
- **Play**: plays the tween (will be paused if `GetTree().Paused` is set to true).
- **PlayUnpausable**: plays the tween (won't be paused if `GetTree().Paused` is set to true).
- **Kill**: kills the tween. This means that the tween will instantly stop playing, leaving it at its current state.
- **Complete**: instantly reaches the final state of the tween, and stops playing.
- **Reset**: sets the tween to its initial state, and stops playing.
- **SetLoops**: sets the amount of times the tween should loop.
- **SetEasing**: sets the easing used by the tween. If the tween is a sequence, the easing will be applied to all child tweens. Set to linear by default.
- **SetTimeScale**: sets the time scale that will be used to tick the tween. Set to 1 by default.

### Tasks
- **PlayAsync**: plays the tween and returns a Task that waits until the tween is killed or completed. If the parameter CancellationToken is cancelled, the tween will be killed.
- **AwaitCompleteOrKill**: returns a Task that waits until the tween is killed or completed.

## 📖 Shortcuts
These are the currently avaliable shortcuts for Godot nodes (the list grows with time).
- **Node2D**: GlobalPosition, Position, GlobalRotation, Rotation, GlobalRotationDegrees, RotationDegrees, GlobalScale, Scale, GlobalSkew, Skew.  
- **Node3D**: GlobalPosition, Position, GlobalRotation, Rotation, GlobalRotationDegrees, RotationDegrees, GlobalScale, Scale.
- **Control**: GlobalPosition, Position, Rotation, RotationDegrees, Scale, Size, PivotOffset.
- **Sprite2D**: Offset.
- **SpriteBase3D**: Modulate, Offset.
- **Light2D**: Color, Energy, ShadowColor.
- **Light3D**: LightColor, LightEnergy, LightIndirectEnergy, LightVolumetricFogEnergy, LightAngularDistance, ShadowBias, ShadowNormalBias, ShadowTransmittanceBias, ShadowOpacity, ShadowBlur.
- **Camera2D**: Offset, Zoom.
- **Camera3D**: HOffset, VOffset, Fov.
- **AudioStreamPlayer2D**: VolumeDb, PitchScale.
- **AudioStreamPlayer3D**: VolumeDb, PitchScale, AttenuationFilterDb, AttenuationFilterCutoffHz.
- **CanvasModulate**: Color.
- **CanvasItem**: Modulate, SelfModulate.
- **ShaderMaterial**: PropertyInt, PropertyFloat, PropertyVector2, PropertyVector2I, PropertyColor.
- **BaseMaterial3D**: AlbedoColor, Metallic, MetallicSpecular, Roughness.

  ![Reddit](https://github.com/Guillemsc/GTweensGodot/assets/17142208/f03cca23-94b5-484b-8202-0d1961b14f98)

  
 
