using UnityEngine;
using System.Collections;

public class ProjectilScript : MonoBehaviour {

    public AudioClip SoundDead;
    private Vector3 spawnPoint;//Coordonées du Point de Spawn

	void Start () {
        //Assignation dans la variable du point de spawn
        spawnPoint = GameObject.Find ("SpawnPoint").GetComponent<Transform> ().position;
	}
		
	void OnTriggerEnter (Collider other) {
	
        if(other.gameObject.tag =="Player")//Si la balle touche le player
        {
            GetComponent<AudioSource> ().PlayOneShot (SoundDead);
            other.transform.position = spawnPoint;//Deplacement du player au SpawnPoint
        }
	}

    
}
