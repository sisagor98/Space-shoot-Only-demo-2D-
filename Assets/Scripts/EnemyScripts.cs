using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    private float AiSpeed = 5f;
    public GameObject enemybullet;

    void Start()
    {
        Invoke("EnemyActive", 4f);
    }


    void Update()
    {
        transform.Translate(Vector3.left * AiSpeed * Time.deltaTime);

        //Invoke("shoot", 2f);
    }


    void EnemyActive()
    {
        // gameObject.SetActive(false);
        Destroy(gameObject);
    }
    void shoot()
    {
        Instantiate(enemybullet, transform.position + new Vector3(0.7f, 0, 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }

}
