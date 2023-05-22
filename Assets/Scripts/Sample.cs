using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Sample : MonoBehaviour
{
    public GameManager gameManager;
    private FirstPersonController fpsController;
    public GameObject player;
    public bool IsSolved = false;

    void OnTriggerEnter(Collider other)
    {
       fpsController = player.GetComponent<FirstPersonController>();
        IsSolved = true;
    }
    void OnGUI()

    {
        if (IsSolved == true)
        {
            Rect rect = new Rect(Screen.width / 2 - 80, Screen.height / 2 - 100, 120, 50);
            GUI.Box(rect, "Sample Collected");
        }

    }
}
