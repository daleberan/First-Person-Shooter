using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleanUp : MonoBehaviour
{
  
 
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("bullet"))
            {
                Destroy(other.gameObject);

            }

        
    }


}
