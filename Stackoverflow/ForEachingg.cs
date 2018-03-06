using UnityEngine;
 
 public class ForEachingg : MonoBehaviour {
 
   GameObject[] go;

     // Use this for initialization
     void Start () {
 
 
 go = GameObject.FindGameObjectsWithTag("ObjectTag");
 foreach(GameObject obj in go){
    Script sc = obj.GetComponent<Script>();
    sc.boolName = false;
 }  
      
     }
     
 }