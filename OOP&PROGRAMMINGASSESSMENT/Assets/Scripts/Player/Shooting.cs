using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // the it is the bullet prefab folder
    public Transform[] spawnPoint;// trying to find it postion will it spawns
    public float bulletSpeed = 5f;// speed of the bullet

    void Update()
    {
        // we are putting a key on E Key
        if(Input.GetKeyDown(KeyCode.E))
        {
            //make the bullet fire forward
            Fire(transform.forward);
        }
    }
    public void Fire(Vector3 direction)// this allow to fire in a 3d enviroment
    {
        //show how many it can spawn 
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            // it spwan many bullet at the postion 
            Spawn(direction, spawnPoint[i].position);
        }

    }
    void Spawn(Vector3 direction, Vector3 point)// it spawn bullet directly on the the person move 
    {
        GameObject clone = Instantiate(bulletPrefab);// that it finding the bulletprefabs
        clone.transform.position = point; // the clone will spawn on the position 
        float angle = Mathf.Atan2(direction.y, direction.x); // it's firing on angle on the x and y dicrection 
        float degrees = Mathf.Rad2Deg;// the radious of where the bullet will go 
        clone.transform.rotation = Quaternion.AngleAxis(degrees, Vector3.forward);//trying to find angleaxis on the dgrees will seeing the the bullet move forward 
        Rigidbody rigid = clone.GetComponent<Rigidbody>();//that the clone needs a rigidbody
        rigid.AddForce(direction * bulletSpeed, ForceMode.Impulse);// addforce and speed of the bullet
    }


}
