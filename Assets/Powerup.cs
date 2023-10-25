using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

    private Transform limit;
    public ReferenceLibrary referenceLibrary;
    // Start is called before the first frame update
    void Start()
    {
        referenceLibrary = FindObjectOfType<ReferenceLibrary>();
        limit = referenceLibrary.LimitL;
    }

       private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ship")
        {
            Destroy(gameObject);
            //give powerup depending on powerup type
        }
    
    }

    private void Update()
    {
        if (transform.position.y < limit.position.y)
        {
            Destroy(gameObject);
        }
        //if body reaches below limit, then destroy
    }
}
