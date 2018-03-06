using UnityEngine;
 
 public class DoingSomethingWithPosition : MonoBehaviour {

GameObject FindClosestEnemy()
  {
      enemyTarget = GameObject.FindGameObjectsWithTag("Player");
      Vector3 position = transform.position;
      float distance = Mathf.Infinity;
      
      foreach (GameObject go in enemyTarget) 
      {
          if(go == this.gameObject)       // Here, you check if the game object is not this game object
          {
             continue;
          }
          Vector3 diff = go.transform.position - position;
          float curDistance = diff.sqrMagnitude;
          
          if (curDistance < distance) 
          {
              closest = go;
              distance = curDistance;
              //Debug.Log(closest.name);
          }
      }
      return closest;
  }     
 }