![LogoWide](https://github.com/Guillemsc/GTweensGodot/assets/17142208/704636fa-27da-42c3-b9c5-a5bc6e6a870c)

**Still in development, not ready to use.**

GTweens-Godot is a lightweight and versatile tweening library for Godot with C#. 
This library simplifies the process of creating animations and transitions in your Godot projects, allowing you to bring your game elements to life with ease.

Unlike the default Godot tweening engine, which relies on nodes and their properties to create animations, this tweening engine doesn't require the use of nodes. 

An extension that builds upon the [GTweens](https://github.com/Guillemsc/GTweens) library.

## 🤜 Features
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
- **Callbacks**: Attach callbacks to tweens for event handling at various points in the animation timeline.

## 📦 Installation
1. [Download the latest release](https://github.com/Guillemsc/GTweensGodot/releases/latest).
2. Unpack the `GTweensGodot` folder into the Godot project.
3. On the Godot editor, go to `Project/Project Settings/Autoload`, and select `GTweensGodot/GTweensGodot/Source/Contexts/GodotGTweensContextNode.cs` to be autoloaded.

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
GTweem includes shortcuts for some known C# and Godot objects, like Node2D, Node3D, Control, etc. You can start a tween directly from a reference to these objects, like:
```csharp
node2D.TweenPositionX(100f, 1f);
node3D.TweenScale(new Vector3(2f, 2f, 2f), 1f);
﻿﻿﻿﻿﻿﻿﻿﻿control.TweenSizeY(200f, 2f);
```

### Sequences
Sequences are a combination of tweens that get animated as a group. 
Sequences can be contained inside other sequences without any limit to the depth of the hierarchy.
To create sequences, you need to use the helper `GTweenSequenceBuilder`.
- First you call to start creating a new sequence `New()`.
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
    .AppendCallback(() => GD.Print("I'm finished!"))
    .Build();
        
tween.SetEasing(Easing.InOutCubic);
tween.Play();
```
 
