using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    public Rigidbody bullet;
    public float bulletSpeed = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

           Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position,
               transform.rotation);
            bulletClone.velocity = transform.forward * bulletSpeed;
        }
    }
}
