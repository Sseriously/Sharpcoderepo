using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityOnCamelForEach : MonoBehaviour {

void Start(){

string[] arrayExample= new string[]
{"Array First Element","Array Second Element"};

foreach (string element in arrayExample) {
Debug.Log (element);
}

List listExample = new List () 
{"List First Element","List Second Element"}; 

foreach (string element in listExample) { 
Debug.Log (element); 
} 

Dictionary dictionaryExample= new Dictionary() 
{{99,"Dictionary First Element"},{44,"Dictionary Second Element"}}; 

foreach (KeyValuePair element in dictionaryExample) { 
Debug.Log (element.Key+ " "+ element.Value); 
} 

} 

} 