using UnityEngine;
 
 public class TriggeringManyGameobjects : MonoBehaviour {

public GameObject[] enemies;
 
   void OnTriggerEnter(Collider collider)
{
    //activate enemies
    foreach (GameObject enemy in enemies)
    {
       enemy.active = true;   
    }
}
     
 }