using Godot;
using System;

public class Tower : Area2D
{
	
	public override void _Ready()
	{
		Position = GetGlobalMousePosition(); 
	}


}
