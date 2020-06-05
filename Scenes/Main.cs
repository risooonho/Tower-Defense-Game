using Godot;
using System;

public class Main : Node
{
	[Export]
	
	 
	int enemyNumber = 5; 
	int resource = 10; 
	Vector2 mousePosition = new Vector2();

	private void OnNewGameTimeout()
	{
		Timer enemySpawnTimer = (Timer)GetNode("EnemySpawnTimer");
		enemySpawnTimer.Start(); 
	}

	private void enemySpawner() //Places an enemy every two seconds 
	{
		if(enemyNumber > 0)
		{
		Path2D enemyPath = (Path2D)GetNode("Path2D");
		PackedScene enemy = (PackedScene)ResourceLoader.Load("res://Scenes/Enemy.tscn"); 
		var Enemy = enemy.Instance(); 
		enemyPath.AddChild(Enemy);  
		}
		enemyNumber -= 1; 
		   
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



