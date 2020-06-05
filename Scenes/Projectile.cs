using Godot;
using System;

public class Projectile : Area2D
{
	private int speed = 200; 


	public override void _Ready()
	{
		Position2D projectileSpawnPoint = (Position2D)GetNode("../Tower/ProjectileSpawnPoint");
		GlobalPosition = projectileSpawnPoint.GlobalPosition; 
	}


}
