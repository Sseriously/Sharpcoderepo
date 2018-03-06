using UnityEngine;
using System.Collections;
 
 public class NonValueTypes : MonoBehaviour 
 {
    GameObject[] _GameObjects = new GameObject[]{new GameObject(), new GameObject(), new GameObject()};

         foreach (GameObject gobj in _GameObjects)
         {
             // NOTE: GameObject is not a value type -> gobj is an actual reference to stuff inside the array
             // changing "gobj" really changes things inside the array.
             gobj.transform.position = Vector3.one;
         }
 }