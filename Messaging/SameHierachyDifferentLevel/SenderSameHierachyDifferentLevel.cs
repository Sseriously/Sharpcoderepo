using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SenderSameHierachyDifferentLevel : MonoBehaviour {


 	public GameObject sameHierachyDifferentLevelGameObjectOne;
 	public GameObject sameHierachyDifferentLevelGameObjectTwo;
 	public GameObject sameHierachyDifferentLevelGameObjectThree;
 
	

	  Use this for initialization
	void Start () {

 		sameHierachyDifferentLevelGameObjectOne = GameObject.Find ("ReceiverDifferentLevelGameObject1");
 		sameHierachyDifferentLevelGameObjectTwo= GameObject.Find ("ReceiverDifferentLevelGameObject2");
 		sameHierachyDifferentLevelGameObjectThree = GameObject.Find ("ReceiverDifferentLevelGameObject3");
 
	
	}
	  Update is called once per frame
	void Update () 
	{

 
 		sameHierachyDifferentLevelGameObjectOne.SendMessage("ApplyDamage", 5.0F, SendMessageOptions.RequireReceiver);
 
 		sameHierachyDifferentLevelGameObjectTwo.SendMessage("ApplyDamage", 5.0F, SendMessageOptions.RequireReceiver);
 
 		sameHierachyDifferentLevelGameObjectThree.BroadcastMessage("ApplyDamage", 5.0F, SendMessageOptions.RequireReceiver);


	}
	

}
