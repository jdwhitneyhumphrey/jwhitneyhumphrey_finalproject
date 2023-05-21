using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CrushDepth : MonoBehaviour
{
	//A reference to the game manager
	public GameManager gameManager;
	private FirstPersonController fpsController;
	public GameObject player;

	// Triggers when the player enters the open trench
	void OnTriggerEnter(Collider other)
	{
		fpsController = player.GetComponent<FirstPersonController>();
		fpsController.enabled = false;
	}
}
