using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Much like the Start() and Update () methonds, OnTriggerEnter2D is a special Unity method that is called 
        //by Unity automatically at a specific point - in this case, when something enters the Trigger attached 
        //to this GameObject 

        //If the GameObject that has collided with our trigger is tagged with CleanUp...
        if (collision.gameObject.tag == "CleanUp")

        {
            //Then we use this method to destroy it 
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
