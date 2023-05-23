using UnityEngine;
using System.Collections.Generic;
using UnityStandardAssets.Characters.FirstPerson;

public class BEAST : MonoBehaviour
{

	public GameManager gameManager;
	private FirstPersonController fpsController;
	bool IsGameOver = false;
	public GameObject player;
	

	// Triggers when the final sample is collected
	void OnTriggerEnter(Collider other)
	{
		fpsController = player.GetComponent<FirstPersonController>();
		fpsController.enabled = false;
		IsGameOver = true;
	}
	void OnGUI()

	{
		if (IsGameOver == true)
		{
			Rect rect = new Rect(Screen.width / 2 - 80, Screen.height / 2 - 100, 120, 50);
			GUI.Box(rect, "To be Continued?");
			Rect rect2 = new Rect(Screen.width / 2 - 55, Screen.height / 2 - 50, 200, 300);
			GUI.Label(rect2, "Though flares were deployed the submarine could not be retrieved as the wreckage is scattered all over the bottom of the trench as though it had been torn apart by a huge beast, wreckage cannot be retrieved at this time, further exploration is needed.");
		}

	}
}
