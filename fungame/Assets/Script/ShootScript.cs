using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {

    public AudioClip SoundShoot;
    public GameObject prefabProjectil; //Le projectil
    private GameObject projectil; //Variable pour stocker l'instance du projectil
    public float shootRate = 2f;//Cadence de tir
    private float nextShoot;//Temporisation du tir
    public int speed = 1000;//Force du tir

   	void Update () {

        if(Time.time > nextShoot)
        {
            nextShoot = Time.time + shootRate;//On redifinit le prochain Tir
            projectil = Instantiate (prefabProjectil, transform.position, Quaternion.identity) as GameObject;//Instanciation du prefab
            GetComponent<AudioSource> ().PlayOneShot (SoundShoot);
            projectil.GetComponent<Rigidbody> ().AddForce (transform.TransformDirection( Vector3.right) * speed);//Force vers le V3 Right
            Destroy (projectil, 2f);//Suppression du prefab aprés 2float;
        }
        
	
	}
}
