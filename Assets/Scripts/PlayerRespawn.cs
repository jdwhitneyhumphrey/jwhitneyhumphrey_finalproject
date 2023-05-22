using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager; 

	// Triggers when the player enters the water
	void Start
	{
		// Moves the player to the spawn point
		gameManager.PositionPlayer();
	}
}
