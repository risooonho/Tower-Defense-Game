using Godot;
using System;

public class Tower : Area2D
{
	private int rotationSpeed = 5; 
	public override void _Ready()
	{
		Position = GetGlobalMousePosition(); 
		Sprite arrow = (Sprite)GetNode("Pointer/Sprite");
		arrow.Position = new Vector2(Position.x, Position.y); 
		arrow.Rotation = Mathf.Deg2Rad(60); 
	}

	public override void _Process(float delta)
	{
		Sprite arrow = (Sprite)GetNode("Pointer/Sprite");
		
		
		arrow.Rotation += rotationSpeed * delta; 

		if(arrow.Rotation ==  Mathf.Deg2Rad(120))
		{
			arrow.Rotation -= rotationSpeed * delta; 
		}
			
		
	 
	}


}
