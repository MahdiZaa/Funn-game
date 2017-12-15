using UnityEngine;
using System.Collections;

public class Radeau : MonoBehaviour {

    void OnTriggerEnter (Collider Other)    {

        if(Other.gameObject.tag == "Player")
        {
            Other.transform.SetParent (this.transform);
        }
    }

    void OnTriggerExit (Collider Other)
    {
        if(Other.gameObject.tag == "Player")
        {
            Other.transform.parent = null;
        }
    }

}
