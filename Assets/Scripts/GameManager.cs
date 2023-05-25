using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
	// Place holders to allow connecting to other objects
	public GameManager manager;
	public Transform spawnPoint;
	public GameObject player;
	public Sample sample1, sample2, sample3, sample4, sample5, sample6;

	// So that we can access the player's controller from this script
	private FirstPersonController fpsController;

	// Use this for initialization
	void Start()
	{
		//Tell Unity to allow character controllers to have their position set directly. This will enable our lose condition to work
		Physics.autoSyncTransforms = true;

		// Finds the First Person Controller script on the Player
		fpsController = player.GetComponent<FirstPersonController>();

		// Enables controls at the start.
		fpsController.enabled = true;

	}
	//This resets to game back to the way it started
	private void StartGame()
	{
		// Move the player to the spawn point, and allow it to move.
		PositionPlayer();
		fpsController.enabled = true;
	}

	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}

	void OnGUI()
	{
		Rect rect = new Rect(Screen.width / 2 - 80, Screen.height / 2 - 180, 180, 100);
		GUI.Box(rect, "Controls");
		Rect rect2 = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 160, 200, 100);
		GUI.Label(rect2, "WASD: Move  F: Flash Camera");
	}
}
