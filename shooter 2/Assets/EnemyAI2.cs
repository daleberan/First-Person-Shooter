using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI2 : MonoBehaviour
{
    Transform playerTransform2;

    UnityEngine.AI.NavMeshAgent myNavMesh2;

    public float checkRate2 = 0.01f;
    float nextCheck2;


    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player").activeInHierarchy)
       playerTransform2 = GameObject.FindGameObjectWithTag("Player").transform;

      myNavMesh2 = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        

    }

  
    void Update()
    {
        if (Time.time > nextCheck2)
        {
            nextCheck2 = Time.time + checkRate2;
            FollowPlayer();
        }


    }

    void FollowPlayer()
    {
        myNavMesh2.transform.LookAt(playerTransform2);
        myNavMesh2.destination = playerTransform2.position;

    }



}
