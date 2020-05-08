using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float deactivetime = 2f;
    void Start()
    {
        Invoke("destoybullet", deactivetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);
    }

    void destoybullet()
    {
        // gameObject.SetActive(false);

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
