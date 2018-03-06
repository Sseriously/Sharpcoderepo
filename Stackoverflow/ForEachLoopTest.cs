using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;

public class ForEachLoopTest : MonoBehaviour
{ 

    #region PUBLIC_DECLARATIONS

    public List<GameObject> emptyGameObjects;
    public Text indicatorText;

    #endregion


    #region UNITY_CALLBACKS


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            indicatorText.text = "EXECUTION ON";
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            indicatorText.text = "HOLD SPACE TO TURN ON EXECUTION";
        }
        if (Input.GetKey(KeyCode.Space))
        {
            UpdateTextValue();
        }
    }

    #endregion

    #region PUBLIC_METHODS

    public void UpdateTextValue()
    {
       
        foreach (var item in emptyGameObjects)
        {
            // PROCESS ITEMS IN LIST
        }
//        for (int i = 0; i < emptyGameObjects .Count; i++)
//        {
        // PROCESS ITEMS IN LIST
//        }
    }

    #endregion
}