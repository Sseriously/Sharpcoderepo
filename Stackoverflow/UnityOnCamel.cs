using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityOnCamel : MonoBehaviour {

void Start(){

string[] arrayExample= new string[]
{"Array First Element","Array Second Element", "Array Third Element",
"Array 4th Element", "Array 5th Element"};

Debug.Log ("Array lenght: "+arrayExample.Length);

for (int i = 0; i < arrayExample.Length; i++) {
Debug.Log(arrayExample[i]);
}


}

}