using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public Joueur monJoueur;
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
         monJoueur = FindObjectOfType<Joueur>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        hp--;
        if (hp <= 0)
        {
            monJoueur.Score += scoreValue;
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
