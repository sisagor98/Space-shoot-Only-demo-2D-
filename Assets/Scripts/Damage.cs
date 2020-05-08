using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            Debug.Log("Colide");
        }

        if(other.tag == "bullet")
        {
            Debug.Log("bullet");
        }
        
    }
}
