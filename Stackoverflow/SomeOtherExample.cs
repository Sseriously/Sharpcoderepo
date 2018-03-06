using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherExample : MonoBehaviour {

void Start(){

public GameObject[] Objects = new GameObject[]
{"Array First Element","Array Second Element", "Array Third Element",
"Array 4th Element", "Array 5th Element"};

Debug.Log ("Array lenght: " + Objects.Length);

for (int i = 0; i < Objects.Length; i++)
{
  if (Objects[i] == ItemLookingAt)
  {
    dot.SetActive(true);
  } else
  {
    dot.SetActive(false);
  }
}

}

}