using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderGameObjectOne : MonoBehaviour {



	public GameObject myGameObject;


	// Use this for initialization
	void Start () 
	{

		myGameObject = GameObject.Find ("ReceiverGameObjectTwo");

		myGameObject.SendMessage ("Message", "AAAAAAAA", SendMessageOptions.RequireReceiver);

	}


}
