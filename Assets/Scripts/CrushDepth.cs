using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CrushDepth : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager;
	private FirstPersonController fpsController;
	public GameObject player;
	bool IsGameOver = false;

	// Triggers when the player enters the open trench
	void OnTriggerEnter(Collider other)
	{
		fpsController = player.GetComponent<FirstPersonController>();
		fpsController.enabled = false;
		IsGameOver = true;
		Rect rect = new Rect(Screen.width / 2 - 60, Screen.height / 2 - 100, 120, 50);
		GUI.Box(rect, "Game Over");
		Rect rect2 = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 80, 90, 40);
		GUI.Label(rect2, "You were crushed by the water pressure");
	}
}
