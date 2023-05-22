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
    
}