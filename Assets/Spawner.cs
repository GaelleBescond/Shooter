using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform limitL;
    public Transform limitR;
    public Rigidbody selfBody;
    public GameObject enemy;
    public GameObject enemy2;
    public float speed;
    public float spawntime;

     private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        selfBody.velocity = Vector3.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //à changer pour donner une^vitesse au lieu d'un transform
        if (transform.position.x < limitL.position.x || transform.position.x > limitR.position.x)
        {
            selfBody.velocity *= -1;
        }
                      
        if (timer >= spawntime)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            //ajouter paramètres d'ennemis: direction et type
            timer = 0;
        }
    }

}
