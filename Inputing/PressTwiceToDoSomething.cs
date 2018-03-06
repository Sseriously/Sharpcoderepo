using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressTwiceToDoSomething : MonoBehaviour {

	public float timerTime;

	public bool timerState;

	void Update () 
	{

		if (Input.GetKeyUp(KeyCode.K)) 
		{
			timerState = true;
		}

		if (timerState) 
		{
			timerTime += Time.deltaTime;

			if (timerTime > .5f) 
			{
				timerState = false;

				timerTime = 0f;
			}
		}

		if (timerState == true && timerTime <= .5f && Input.GetKeyDown(KeyCode.K)) 
		{
			Debug.Log ("HHHHHHHH");
		}
			
	}
		
}
