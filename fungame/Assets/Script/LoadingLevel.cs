using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingLevel : MonoBehaviour {
    public GameObject Canvas;
    void OnTriggerEnter(Collider Col)
    {

        if (Col.gameObject.tag == "Player")
        {
            Canvas.GetComponent<Canvas>().enabled = true;
        }

    }
}