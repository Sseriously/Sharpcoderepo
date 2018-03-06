using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderGameObjectInMiddleOfHierarchy : MonoBehaviour {




	// Use this for initialization
	void Start () 
	{
		BroadcastMessage ("ApplyDamage", 5.0F, SendMessageOptions.RequireReceiver);

		SendMessageUpwards ("ApplyDamage", 5.0F, SendMessageOptions.RequireReceiver);

	}


}
