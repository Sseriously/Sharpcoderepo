using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGetKeyFireOnceWithIEnumerator : MonoBehaviour {


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

				StartCoroutine (DelayGetKey());

			}
		}

	}

	IEnumerator DelayGetKey()
	{
		yield return new WaitForSeconds (4);

		canDrop = true;
	}

}
