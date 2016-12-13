using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject cameraVue;
    public GameObject player;
    Rigidbody rbd;
    float Vitesse;
    

    // Use this for initialization
    void Start () {
        Vitesse = 3.0f;
        rbd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 velocity = rbd.velocity;

        Vector3 mouvement = new Vector3(Vitesse * Input.GetAxis("Horizontal"), 0f, Vitesse * Input.GetAxis("Vertical"));

        if (mouvement != Vector3.zero)
        {
            mouvement = Quaternion.Euler(0f, cameraVue.transform.eulerAngles.y, 0f) * mouvement;//permet de se déplacer selon l'axe de la camera
            transform.rotation = Quaternion.LookRotation(mouvement);


        }

        velocity.x = mouvement.x;
        velocity.z = mouvement.z;
        rbd.velocity = velocity;

    }

    void OnCollisionEnter(Collision collision)
        {

        if (collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("contact !");
        }

    }


}
