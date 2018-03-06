using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class Bluh : MonoBehaviour {
 
 List<String> phraseList = new List<String>();
 
 void OnGUI() {
     int i = 0;
     foreach(String str in phraseList)
     {
        if(GUI.Button (Rect (100, 20 * i, 200, 20), str)) {
          Debug.Log("Box #" + i + " is working");
        }
        i++;
     }
 }
 void Update () {
     if(Input.GetKeyUp("z"))
     {
        phraseList.Add("Test string 1");
        phraseList.Add("Test string 2");
        phraseList.Add("Test string 3");
        foreach(String str in phraseList)
        {
          Debug.Log(str);
        }
     }
 }
 }