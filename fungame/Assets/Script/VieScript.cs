using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class VieScript : MonoBehaviour {

    public float nbVies = 3;
    public Text TxtInfos;
	
	void Start () {
        TxtInfos.text = "Vie " + nbVies;
    }
	
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag=="Player")
        {
            nbVies -= 0.5f;
            TxtInfos.text = "Vie " + (int)nbVies;

            if (nbVies == 0)
            {
                //GameOver
                SceneManager.LoadScene("GameOver");
            }
        }
	}
}
