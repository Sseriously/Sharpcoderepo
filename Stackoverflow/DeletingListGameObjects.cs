using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class DeletingListGameObjects : MonoBehaviour {
 
 GameObject[] objects = GameObject.FindGameObjectsWithTag( "Target" );
foreach( GameObject go in objects )
{
    Destroy( go );
}




 }