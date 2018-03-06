using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAndHoldToDoSomething : MonoBehaviour {

	public float timepassed = 0f;

	void Update ()
	{
		if(timepassed >= 0f)
		{
			if (Input.GetKey (KeyCode.K)) 
			{
				timepassed += Time.deltaTime;

				if (timepassed > 1f) {

					Debug.Log ("HHHHHHHH");

					timepassed = -1f;

				}
			}
		}

		if (Input.GetKeyUp (KeyCode.K)) 
		{
			timepassed = 0;
		}
	}
}
