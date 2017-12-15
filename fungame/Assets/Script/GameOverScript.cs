using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {

    public float TimeToLoadMenu = 3f;
    //public AudioClip gameoverSound;//

    void Start ()
    {
       // GetComponent<AudioSource>().PlayOneShot(gameoverSound);//
        StartCoroutine(LoadMenu());
	}
	
	IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(TimeToLoadMenu);
        SceneManager.LoadScene("menu");
    } 
}
