using Godot;
using System;

public class Main : Node
{

	public override void _Ready()
	{
		PackedScene enemy = (PackedScene)ResourceLoader.Load("res://Scenes/Enemy.tscn");
	  	var Enemy = enemy.Instance();
	  	AddChild(Enemy);
	}


}
