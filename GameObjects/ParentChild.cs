using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChild : MonoBehaviour
{

	public GameObject childGameObject;

	public Vector3 childGameObjectTransform;

	public Transform parentTransform;


	void Start()
	{
		childGameObject = GameObject.Find("Child");

		parentTransform = GameObject.Find("Parent").GetComponent<Transform>();

		childGameObjectTransform = childGameObject.transform.position;

	}


	void Update()
	{
		if (Input.GetKey(KeyCode.K))
		{
			ParentSomeChildObject(parentTransform);
		}
		else
		{
			UnParentSomeChildObject();
		}
	}


	public void ParentSomeChildObject(Transform newParent)
	{
		childGameObject.transform.SetParent(newParent);

		childGameObject.transform.SetParent(newParent, false);

		childGameObject.transform.position = Vector3.zero;
	}


	public void UnParentSomeChildObject()
	{
		parentTransform.transform.DetachChildren();

		childGameObject.transform.position = childGameObjectTransform;

	}

}
