![LogoWide](https://github.com/Guillemsc/GTweensGodot/assets/17142208/704636fa-27da-42c3-b9c5-a5bc6e6a870c)

GTweensGodot is a lightweight and versatile tweening library for the Godot game engine, written in C#. 
This library simplifies the process of creating animations and transitions in your Godot projects, allowing you to bring your game elements to life with ease.

An extension that builds upon the [GTweens](https://github.com/Guillemsc/GTweens) library.

## 🤜 Features
- **Simple API**: GTweensGodot provides an intuitive and easy-to-use API with C# extension methods.
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
	            .Append(Target.TweenPositionY(100f, 1f))
	            .AppendTime(0.5f)
	            .Append(Target.TweenPositionX(0f, 1f))
	            .Append(Target.TweenPositionY(0f, 1f))
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
  
- **Delay and Duration**: Specify delays and duration for each tween, allowing precise timing of your animations.
- **Callback Events**: Attach callbacks to tweens for event handling at various points in the animation timeline.
- **Godot Integration**: Seamlessly integrates with the Godot engine, making it a natural extension of your Godot projects.

## 📦 Installation
1. [Download the latest release](https://github.com/Guillemsc/GTweensGodot/releases/latest).
2. Unpack the `GTweensGodot` folder into the Godot project.
3. On the Godot editor, go to `Project/Project Settings/Autoload`, and select `GTweensGodot/GTweensGodot/Source/Contexts/GodotGTweensContextNode.cs` to be autoloaded.

## 📚 Getting started
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
