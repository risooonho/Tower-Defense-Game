using Godot;
using System;

public class Main : Node
{
	[Export]
	
	private PackedScene _Enemy = (PackedScene)ResourceLoader.Load("res://Scenes/Enemy.tscn"); 
	int enemyNumber = 5; 
	int resource = 10; 
	Vector2 mousePosition = new Vector2();

	private void OnNewGameTimeout()
	{
		Timer enemySpawnTimer = (Timer)GetNode("EnemySpawnTimer");
		enemySpawnTimer.Start(); 
	}

	private void enemySpawner()
	{

		var enemyInstance = (Enemy)_Enemy.Instance();
	  	AddChild(enemyInstance);   
	} 
	private void OnEnemySpawnTimerTimeout()
	{
		enemySpawner(); 
	}

	private void playerInput() //Places a tower where the player clicked if they have the required resources
	{
		if(Input.IsActionJustPressed("LeftClick"))
		{
			
			if(resource > 0)
			{
			PackedScene tower = (PackedScene)ResourceLoader.Load("res://Scenes/Tower.tscn");
	  		var Tower = tower.Instance();
	  		AddChild(Tower);
			}
			resource -= 1; //Subtracts the resources to build the tower  	
		}
	}
	public override void _Process(float delta) //Checks for player input each frame
	{
		playerInput(); 
	}
	



}



