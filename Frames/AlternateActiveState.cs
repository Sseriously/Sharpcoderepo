using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternatingObjectsPerFrameUpdate : MonoBehaviour
{


    public GameObject image1;

    public GameObject image2;

    public bool imageState;

    public float imageSpeed;


    void Start()
    {

        image1.SetActive(false);

        image2.SetActive(true);

        imageState = true;
        
    }


    void Update()
    {
        if (imageState)
        {
            if (image1.activeSelf == false)
            {
                image1.SetActive(true);
            }
            else
            {
                image1.SetActive(false);
            }

            if (image2.activeSelf == true)
            {
                image2.SetActive(false);
            }
            else
            {
                image2.SetActive(true);
            }

            imageState = false;

            Invoke("DelayImageState", imageSpeed);

        }
    }

    void DelayImageState()
    {
        imageState = true;
    }

   

}
