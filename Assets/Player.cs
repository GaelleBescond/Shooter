using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject prefabBullet;
    public Transform limitL;
    public Transform limitR;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textLevel;

    public GameObject levelUpEffect;

    public float speed = 0.05f; //player speed
    public int Score; //will define weapon mode
    public int level = 1; //weapon mode
    public int bonus = 0; //will change when player receives a bonus

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shootBullet(level, bonus);
        }
        //move
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
            if (transform.position.x < limitL.position.x)
            {
                transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
            if (transform.position.x > limitR.position.x)
            {
                transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
            }
        }
        //level up
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Score >= level * 100)
            {
                Score -= level * 100;
                level += 1;
               GameObject levelUp = Instantiate(levelUpEffect, transform.position, transform.rotation);
                //.transform.rotation = transform.rotation + new Vector3(-90, 0, 0);
            }
        }
        //UI update
        textScore.text = Score.ToString();
        textLevel.text = level.ToString();

    }

    void shootBullet(int level, int bonus)
    {
        GameObject newBullet = Instantiate(prefabBullet, transform.position + new Vector3(0, 0.7f, 0), transform.rotation);
        newBullet.GetComponent<Bullet>().creator = this;
    }
}
