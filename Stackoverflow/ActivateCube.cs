using UnityEngine;
 
 public class ActivateCube : MonoBehaviour {
 
     //Create an array to hold any number of cubes you want
     public GameObject[] cubeArray = new GameObject[10]; //initialize the array for e.g. 10 cubes
 
     //Holds the index of the cubeArray, which corresponds to the next cube to be activated
     private int activateNext = 0;
 
 
     // Use this for initialization
     void Start () {
 
         for (int i = 0; i < cubeArray.Length; i++)
         {
             cubeArray[i].SetActive(false);
         }
     
     }
     
     // Update is called once per frame
     void Update () {
 
         //whenever a click occurs, and as long as activateNext is less than the length of the array...
         if (Input.GetButtonDown("Fire1") && activateNext < cubeArray.Length)
         {
             //... activate next cube
             cubeArray[activateNext].SetActive(true);
 
             activateNext++;
         }
     
     }
 }