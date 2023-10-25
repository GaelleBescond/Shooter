using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform limitL;
    public Transform limitR;
    public Rigidbody selfBody;
    public GameObject enemy;
    public float speed;

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
        if (transform.position.x < limitL.position.x || transform.position.x > limitR.position.x)
        {
            selfBody.velocity *= -1;
        }
        if (timer >= 1)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            timer = 0;
        }
    }

}
