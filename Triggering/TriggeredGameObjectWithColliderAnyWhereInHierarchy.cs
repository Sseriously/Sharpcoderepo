using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredGameObjectWithColliderAnyWhereInHierarchy : MonoBehaviour {

	public GameObject topOfTriggeredGameObjectHierachy;

	// Use this for initialization
	void Start () {

		topOfTriggeredGameObjectHierachy = GameObject.Find ("TopOfTriggeredGameObjectHierachy");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay()
	{
		Destroy (topOfTriggeredGameObjectHierachy);
	}
}
