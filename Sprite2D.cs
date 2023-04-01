using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{

    public override void _Ready()
    {
        base._Ready();
        GD.Print("Hello World");
    }

}
