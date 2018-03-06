using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingTimeDotTimeScript : MonoBehaviour
{

	float nextTimeToDoSomething = 0;

	float timeIncrease = 1;

	public float RateOfDoingSomethingPerSec = 1;


	void Update()
	{
		if (Input.GetKey(KeyCode.K))
		{
			if(Time.time >= nextTimeToDoSomething)
				
			{
				nextTimeToDoSomething = Time.time + timeIncrease / RateOfDoingSomethingPerSec;

				print("Hello");
			}
		}
	}
}
