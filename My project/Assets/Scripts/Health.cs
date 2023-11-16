using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //variable for the gamr
    public int maxHealth;       //determines max amount of health the player can have
    public int currentHealth;   //tracks current health of the player


    public GameObject health1;
    public GameObject health2;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;                  //set max health to two
        currentHealth = maxHealth;      //set current health to max health
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;                        //lower health

        if (currentHealth <= 0)                         //if health equal zero
        {
            SceneManager.LoadScene("GameOver");         //go to GameOver Scene
        }
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

        else if(coll.tag == "Wall" && left == false)
        {
            left = true;
        }


    }  
        




}
