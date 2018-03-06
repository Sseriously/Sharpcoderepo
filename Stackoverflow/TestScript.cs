using System;
using System.Collections.Generic;
 
using UnityEngine;
 
public class TestScript : MonoBehaviour
{
	private const int NumIterations = 100000;
 
	private string report;
 
	void Start()
	{
		report = "Size,Array For Time,Array Foreach Time,List For Time,List Foreach Time\n";
		var sizes = new []{10,100,1000};
		foreach (var size in sizes)
		{
			report += Test(size);
		}
	}
 
	private string Test(int size)
	{
		var array = new object[size];
		var list = new List<object>(size);
		list.AddRange(array);
		var stopwatch = new System.Diagnostics.Stopwatch();
		object obj = null;
 
		stopwatch.Reset();
		stopwatch.Start();
		for (var iteration = 0; iteration < NumIterations; ++iteration)
		{
			for (int i = 0, len = array.Length; i < len; ++i)
			{
				obj = array[i];
			}
		}
		var arrayForTime = stopwatch.ElapsedMilliseconds;
 
		stopwatch.Reset();
		stopwatch.Start();
		for (var iteration = 0; iteration < NumIterations; ++iteration)
		{
			foreach (var cur in array)
			{
			}
		}
		var arrayForeachTime = stopwatch.ElapsedMilliseconds;
 
		stopwatch.Reset();
		stopwatch.Start();
		for (var iteration = 0; iteration < NumIterations; ++iteration)
		{
			for (int i = 0, len = list.Count; i < len; ++i)
			{
				obj = list[i];
			}
		}
		var listForTime = stopwatch.ElapsedMilliseconds;
 
		stopwatch.Reset();
		stopwatch.Start();
		for (var iteration = 0; iteration < NumIterations; ++iteration)
		{
			foreach (var cur in list)
			{
			}
		}
		var listForeachTime = stopwatch.ElapsedMilliseconds;
 
		return size + ","
			+ arrayForTime + ","
			+ arrayForeachTime + ","
			+ listForTime + ","
			+ listForeachTime + "\n";
	}
 
	void OnGUI()
	{
		GUI.TextArea(new Rect(0, 0, Screen.width, Screen.height), report);
	}
}