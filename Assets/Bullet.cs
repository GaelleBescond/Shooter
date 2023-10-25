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
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        //monCreateur = FindObjectOfType<Joueur>();
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        myRigidbody.velocity = Vector3.up * speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy1")
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            Destroy(gameObject);
        }

    }
}
