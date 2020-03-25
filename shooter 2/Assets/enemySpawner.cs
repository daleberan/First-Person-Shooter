using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public Rigidbody enemy1;
    public float speed = 2;
    public float Timer = 5; 

    void SpitEnemy()
    {

        Rigidbody enemyClone = (Rigidbody)Instantiate(enemy1, transform.position,
            transform.rotation);
        enemyClone.velocity = transform.right * speed;

    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            SpitEnemy();
            Timer = 5f;
        }
        
    }
}
