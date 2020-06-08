using Godot;
using System;

// 0 = GrassTile
// 1 = RoadTile
public class Tower : Area2D
{
	Vector2 tileLocation = new Vector2(); 

	Vector2 cursorLocation = new Vector2();

	public override void _Ready()
	{
		TileMap worldTileMap = (TileMap)GetNode("../WorldTileMap"); 
		tileLocation = worldTileMap.WorldToMap(GetLocalMousePosition()); //Checks which cell is at the mouseclick location
		var cell = worldTileMap.GetCellv(tileLocation); //Gets the cell ID 
		
				
		if(cell != 1) //Makes sure the tower is being placed on allowed terrain 
		{	
			Position = worldTileMap.MapToWorld(tileLocation) + worldTileMap.CellSize / 2; //Snaps the tower to the center of the tile 
			Timer towerTimer = (Timer)GetNode("../TowerTimer"); 
			towerTimer.Start(); 
			//At the end of timer resources will be subtracted in main class. Means resources will be lost only if a tower is placed 
		}
		else
		{
			Sprite towerSprite = (Sprite)GetNode("Sprite");
			towerSprite.QueueFree(); 
		}	
	}
}
