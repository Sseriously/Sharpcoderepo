using UnityEngine;
using System.Collections;
 
 public class ValueTypes : MonoBehaviour 
 {
     const int SEARCHED_INTEGER = 2;
     int[] _Integers;
 
     void Start () 
     {
         _Integers = new int[]{1,2,2,3,4};
 
         int numberOfSearchedInts = 0;
         foreach (int integer in _Integers)
         {
             if (integer == SEARCHED_INTEGER)
             {
                 numberOfSearchedInts ++;
             }
         }
 
         Debug.Log ("We found " + numberOfSearchedInts + " occurrences of the number " + SEARCHED_INTEGER + " in the array" );
     }
 }