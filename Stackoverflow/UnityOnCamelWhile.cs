using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityOnCamelWhile : MonoBehaviour {

void Start(){

string[] arrayExample= new string[]
{"Array First Element","Array Second Element", "Array Third Element",
"Array 4th Element", "Array 5th Element"};

int i = 0;
while (i < arrayExample.Length) {
Debug.Log (arrayExample [i]);
i++;
}

}

}