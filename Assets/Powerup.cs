using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
   
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            Destroy(gameObject);
            //give powerup depending on powerup type

        }
    }
}
