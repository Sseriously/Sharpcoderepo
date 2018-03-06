using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomethingForAWhile : MonoBehaviour {

	public int myInt = 0;

	public float myTiempo;

	void Update () {

		if (Input.GetKeyDown (KeyCode.K)) 
		{
			myInt = 1;

		}

		if (myInt == 0) 
		{
			return;
		}
		else 
		{
			Debug.Log ("HHHHH");

			myTiempo += Time.deltaTime;

			if (myTiempo > 2f) 
			{

				myTiempo = 0f;

				myInt = 0;

				Debug.Log ("HHHHH");
			}

		}
	}
}
