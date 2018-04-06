using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;// it allow to collide when the object is meant to move to the next 


public class Goal : MonoBehaviour
{

    public UnityEvent onEnter;// it allows to collide object 

    // Trigger function when is collide to the other object it can enters
    void OnTriggerEnter(Collider other)
    {
        //it is searching for name player that allow it to enter 
        if (other.name == "Player")
        {
            // allows the player to collide
            onEnter.Invoke();
        }
    }
}

