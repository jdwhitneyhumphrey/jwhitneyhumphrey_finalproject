using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {

	public float coolDown = 2;
	public float coolDownTimer;

	Light light;

	// Use this for initialization
	void Start()
	{
		light = GetComponent<Light>();
	}

	// Update is called once per frame
	void Update()
	{
		if (coolDownTimer > 0)
        {
			coolDownTimer -= Time.deltaTime;
        }

		if(coolDownTimer < 0)
        {
			coolDownTimer = 0;
			light.enabled = false;
		}

		if(Input.GetKeyUp(KeyCode.F) && coolDownTimer == 0)
        {
			light.enabled = true;
			coolDownTimer = coolDown;
        }
	}
}