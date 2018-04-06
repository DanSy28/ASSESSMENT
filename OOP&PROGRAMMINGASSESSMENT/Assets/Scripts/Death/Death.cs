using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Death : MonoBehaviour
{

    public UnityEvent onDeath;

    //Gets called when it is Triggered on the other object
    void OnTriggerEnter(Collider other)
    {
        // If it touch the deathzone
        if (other.name.Contains("DeathZone")) 
        {
            // it will remove the object 
            onDeath.Invoke();
        }
    }


}
