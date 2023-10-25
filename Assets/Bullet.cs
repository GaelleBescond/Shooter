using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody myRigidbody;
    public Joueur monCreateur;
    public Enemy target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //monCreateur = FindObjectOfType<Joueur>();
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        myRigidbody.velocity = Vector3.up*speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy1")
        {
            Destroy(gameObject);
        }
    }
}
