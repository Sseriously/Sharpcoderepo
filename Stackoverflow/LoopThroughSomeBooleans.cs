using UnityEngine;
using System.Collections;
 
 public class LoopThroughSomeBooleans : MonoBehaviour 
 {

	public bool[] inputBool;
      
     for(int i = 0; i < inputBool.Length; i++) {
       inputBool[i] = false;
     }

 }