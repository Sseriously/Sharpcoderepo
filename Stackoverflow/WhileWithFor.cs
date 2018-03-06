using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WhileWithFor : MonoBehaviour {

public GameObject[] enemy;
 public Vector3 spawnValues;
 public int hazardCount;
 public float spawnWait;
 public float startWait;
 public float waveWait;
 
 void Start ()
 {
     StartCoroutine (SpawnWaves ());
 
 
 }
 
 IEnumerator SpawnWaves ()
 {
     yield return new WaitForSeconds (startWait);
     while (true)
     {
         foreach (GameObject objects in enemy)
         {     
             Vector3 spawnPosition = new Vector3 (spawnValues.x, 
                 Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
             Quaternion spawnRotation = Quaternion.identity;
             Instantiate (objects, spawnPosition, spawnRotation);
             yield return new WaitForSeconds (spawnWait);
         }
         yield return new WaitForSeconds (waveWait);
     }     
 }

}