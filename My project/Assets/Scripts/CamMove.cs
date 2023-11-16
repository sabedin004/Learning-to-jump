using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{

    //variable for the game
    public GameObject target;                                   //determine what object is the camera going to follow


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);  
    }
}
