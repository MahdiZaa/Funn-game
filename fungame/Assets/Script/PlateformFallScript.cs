using UnityEngine;
using System.Collections;

public class PlateformFallScript : MonoBehaviour
{

    //Déclarations des Variables
    public float SecToFall = 2; //Temporisation avant la Chute 
    private Rigidbody rb; //Composant rigidbody
    private Material plateformColor; // Composant color
    private Vector3 PositionDepart; //Stocke la position de départ;

    void Start ()
    {
        //Assignation des variables
        rb = GetComponent<Rigidbody> ();//Composant Rigidbody
        PositionDepart = transform.position;//Position de l'objet
        plateformColor = GetComponent<Renderer> ().material;//Composant Material
    }

    void OnTriggerEnter (Collider Other)
    {

        //Le Player entre dans le Trigger
        if(Other.gameObject.tag == "Player")
        {
            plateformColor.color = Color.red; //Change la couleur en rouge
            StartCoroutine (FallDown ()); //Execute la courtine FallDown
        }

        //ZoneSpawn entre dans le Trigger
        if(Other.gameObject.tag == "ZoneSpawn")
        {
            plateformColor.color = Color.white; //Change la couleur en blanc
            rb.isKinematic = true; //Changement du IsKinematic ->Position fixe
            transform.position = PositionDepart;//Retour a la position de départ
        }
    }

    //Permet d'obtenir une pause grace au return de l'instruction Yield
    IEnumerator FallDown ()
    {
        yield return new WaitForSeconds (SecToFall);//Pause en secondes avant execution de la ligne suivante
        rb.isKinematic = false;//Changement du IsKinematic ->Chute
    }

}
