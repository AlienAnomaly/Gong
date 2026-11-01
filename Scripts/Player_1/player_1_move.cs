using Godot;
using System;

public partial class player_1_move : CharacterBody2D {
	[Export]
	int MoveSpeed = 100;

	[Export]
	float DECELERATION_SPEED = 75.0f;
	
	public override void _PhysicsProcess(double delta)
	{
		Godot.Vector2 velocity = Velocity;
		Godot.Vector2 direction = Input.GetVector("left", "right", "up", "down");

		if (direction.Y != 0)
		{	
			velocity.Y = direction.Y * MoveSpeed;
		}
		else
		{
			velocity.Y = Mathf.MoveToward(velocity.Y, 0.0f, DECELERATION_SPEED);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
