using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter(Collider col)//when bullet will be trigger when it is collid
    {
        if (col.name.Contains("Bullet"))//tring look for bullet if it's in the scene 
        {            
            Destroy(col.gameObject);//the bullet collider
            Destroy(gameObject);// destory game object

        }
    }

}
