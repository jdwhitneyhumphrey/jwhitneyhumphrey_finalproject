using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Place holders to allow connecting to other objects
	public Transform spawnPoint;
	public GameObject player;
	public GoalScript sample1, sample2, sample3, sample4, sample5, sample6;
	private bool IsGameOver = true;

	// Use this for initialization
	void Start()
	{
		//Tell Unity to allow character controllers to have their position set directly. This will enable our respawn to work
		Physics.autoSyncTransforms = true;

	}

	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}
}
