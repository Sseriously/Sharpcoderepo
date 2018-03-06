using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OtherForForEach : MonoBehaviour {

public int shipCount = 13;
  
 void Start()
 {
      GameObject[] ships = new GameObject[shipCount];
  
     for(int i = 1; i < shipCount; i++)
     {
         ships[i] = GameObject.FindWithTag ("ship" + i);
     }
 
     foreach(GameObject ship in ships)
     {
         EnemyAI.isActive = false;
     }
 }

}