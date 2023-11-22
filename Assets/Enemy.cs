using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public Player player;
    public GameObject prefabBonus;
    public Transform limit;
    public int hp; //hp
    private string type; // enemy type will be to give different powerups
    public int scoreValue;
    public ReferenceLibrary referenceLibrary;
    // Start is called before the first frame update
    void Start()
    {
        referenceLibrary = FindObjectOfType<ReferenceLibrary>();
        limit = referenceLibrary.LimitL;
         player = FindObjectOfType<Player>();
    }

    //add check collider
    private void OnCollisionEnter(Collision collision)
    {
        //hp loss
        hp--;
        if (hp <= 0)
        {
            player.Score += scoreValue;
            Destroy(gameObject);
            int r = Random.Range(0, 10);
            if (r < 3)
            {
                Instantiate(prefabBonus, transform.position, transform.rotation);
            }
        }
    }

    private void Update()
    {
        if (transform.position.y < limit.position.y)
        {
            Destroy(gameObject);
        }
    }

}
