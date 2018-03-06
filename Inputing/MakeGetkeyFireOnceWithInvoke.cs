using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGetkeyFireOnceWithInvoke : MonoBehaviour {


	public bool canDrop = true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


		if (canDrop) 
		{

			if (Input.GetKey (KeyCode.K)) 
			{

				Debug.Log ("HHHHHHHH");

				canDrop = false;

				Invoke ("DelayGetKey", 3.5f);
			}
		}

	}

	void DelayGetKey()
	{
		canDrop = true;
	}

}