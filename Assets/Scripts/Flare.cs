using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Flare : MonoBehaviour
{
    public GameManager gameManager;
    private FirstPersonController fpsController;
    public GameObject player;

    Light light;

    // Use this for initialization
    void Start()
    {
      light = GetComponent<Light>();
        light.enabled = false;
    }

     void OnTriggerEnter(Collider other)
     {
        fpsController = player.GetComponent<FirstPersonController>();
        light.enabled = true;
     }
}
