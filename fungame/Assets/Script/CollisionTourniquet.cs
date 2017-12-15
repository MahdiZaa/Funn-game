using UnityEngine;
using System.Collections;

public class CollisionTourniquet : MonoBehaviour
{
    public AudioClip SoundDead;
    private Vector3 SpawnPoint;


    void Start ()
    {
        SpawnPoint = GameObject.Find ("SpawnPoint").GetComponent<Transform> ().position;
    }


    void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.tag == "Player")
        {
            GetComponent<AudioSource> ().PlayOneShot (SoundDead);
            Other.gameObject.transform.position = SpawnPoint;
        }
    }
}
