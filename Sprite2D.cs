using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{

 private int Speed = 400;
 private float AngularSpeed = Mathf.Pi;

    public override void _Process(double delta) {
        Rotation += AngularSpeed * (float)delta;
        this.ApplyScale(new Vector2((float)1.1, (float)1.1));
    }

}
