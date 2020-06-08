using Godot;
using System;

public class Main : Node
{

	int maxEnemyNumber = 10;

	int enemyCounter = 0;  
	int resource = 10; 
	Vector2 mousePosition = new Vector2();
	private void OnStartTimerTimeout()
	{
		Timer enemySpawnTimer = (Timer)GetNode("EnemySpawnTimer");
		enemySpawnTimer.Start(); 
	}

	
	private void EnemySpawner() //Places an enemy every two seconds 
	{
		enemyCounter += 1;
 
		if(enemyCounter <= maxEnemyNumber)
		{
			Path2D enemyPath = (Path2D)GetNode("Path2D");
			PackedScene enemy = (PackedScene)ResourceLoader.Load("res://Scenes/Enemy.tscn"); 
			var Enemy = enemy.Instance(); 
			enemyPath.AddChild(Enemy);  
			//GD.Print(enemyCounter); 
		}
	}
	private void OnEnemySpawnTimerTimeout()
	{
		EnemySpawner(); 	
	}

	private void OnTowerTimerTimeout()
	{
		resource -= 1;
	}
	private void playerInput() //Places a tower where the player clicked if they have the required resources
	{
		if(Input.IsActionJustPressed("LeftClick"))
		{
			//GD.Print(resource); 
			if(resource > 0)
			{
			PackedScene tower = (PackedScene)ResourceLoader.Load("res://Scenes/Tower.tscn");
	  		var Tower = tower.Instance();
	  		AddChild(Tower);
			}	
		}
	}

	public override void _Process(float delta) //Checks for player input each frame
	{
		playerInput(); 
	}
	
}









