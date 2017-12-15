using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour {

    public string LevelToLoad;
    public AudioClip SoundWin;
    public GameObject canvas;

    void OnTriggerEnter (Collider Col) {

        if(Col.gameObject.tag == "Player")
        {
            canvas.SetActive(true);
            StartCoroutine (LoadNextLevel ());
        }

    }

    IEnumerator LoadNextLevel ()
    {
        GetComponent<AudioSource> ().PlayOneShot (SoundWin);
        yield return new WaitForSeconds (3f);
        SceneManager.LoadScene (LevelToLoad);
    }
}
