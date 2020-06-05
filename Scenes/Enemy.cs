using Godot;
using System;

public class Enemy : Area2D
{
  
 private int speed = 200; 

public override void _Ready()
{
	PathFollow2D enemyPathFollow = (PathFollow2D)GetNode("../Path2D/EnemyPathFollow"); 
	enemyPathFollow.Offset = 0;
	Position = enemyPathFollow.Position; //Enemy units spawns at the first node of the outlined Path2D
}
public override void _Process(float delta)
{
	PathFollow2D enemyPathFollow = (PathFollow2D)GetNode("../Path2D/EnemyPathFollow"); 
	enemyPathFollow.Offset += speed * delta; 

	Position = enemyPathFollow.Position;
	  

	if(enemyPathFollow.UnitOffset == 1) //If the unit reaches the end of the path intact, it will be deleted. 
	{
		QueueFree(); 
	}


	

}

}
