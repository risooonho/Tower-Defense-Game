using Godot;
using System;

public class Projectile : KinematicBody2D
{
   
	private int speed = 250; 

	Vector2 direction = new Vector2(); 
	
	Vector2 spriteSize = new Vector2();
	public override void _Ready()
	{
		Sprite sprite =  (Sprite)GetParent().GetNode("Sprite");
		spriteSize = sprite.Texture.GetSize();		
		Position = new Vector2(Position.x - spriteSize.x/3, Position.y - (9 * spriteSize.y/10));
		
		
	}

	/*public override void _PhysicsProcess(float delta)
	{
		MoveAndCollide(direction.Normalized() * speed * delta); 
	}*/


}
