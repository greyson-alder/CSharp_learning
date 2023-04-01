using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{

 private int Speed = 400;
 private float AngularSpeed = Mathf.Pi;

    public override void _Process(double delta) {
        var direction = 0;
        if (Input.IsActionPressed("ui_left")) {
            direction = -1;
        }
        if (Input.IsActionPressed("ui_right")) {
            direction = 1;
        }

        Rotation += AngularSpeed * direction * (float)delta;

        // velocity has both direction AND speed (it's a vector of the two)
        // The UP.rotated(rotation) is a vector which points ahead RELATIVE to the icon
        var velocity = Vector2.Zero;
        if (Input.IsActionPressed("ui_up")) {
            velocity = Vector2.Up.Rotated(Rotation) * Speed;
        }
       

        Position += velocity * (float)delta;
        // this.ApplyScale(new Vector2((float)1.1, (float)1.1));
    }

    // we use unhandled_input() when we want logic to run on a key-press
    // i.e. not every frame, only on that event
    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventKey eventKey) {
            if (eventKey.Pressed && eventKey.Keycode == Key.Escape) {
                GetTree().Quit();
            }
        }
    }

}
