using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoreForExamples : MonoBehaviour {

void Start(){

 int[] Generate(int count, int min, int max)
 {
     int[] numbers = new int[count];
     //Start at 0, and make sure the iterator (i) does not go beyond the array limit 
     for (int i = 0; i < count; i++)
     {
         numbers[i] = Random.Range(min,max);
     }
     return numbers;
 }

}

}