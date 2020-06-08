using Godot;
using System;

public class Enemy : PathFollow2D
{
private int speed = 200; 

	public override void _PhysicsProcess(float delta)
	{
		Offset += speed * delta; 

		if(UnitOffset == 1)
		{
			QueueFree(); 
		}
	}
}
