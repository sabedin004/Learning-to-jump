using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour



{
    // variable for the game
    Health demage;

    public GameObject hitPoints;

    // Vector2 Direction;

    public float speed;
    public bool left = true;




    void Start()
    {
        damage = hitPoint
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OntriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            damage.TakeDamage(1);
        }

        if (coll.tag == "Wall" && left == true)
        {
            left = false;
        }

        else if (coll.tag == "Wall" && left == false)
        {
            left = true;
        }



    }
