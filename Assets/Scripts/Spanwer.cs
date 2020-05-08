using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{
    public float Spawner = 2f;
    //public GameObject rocketPrefabs;
    private float nextTime;
    public GameObject[] enemy;

    // Update is called once per frame
    void Update()
    {
        if (nextTime <= Time.time)
        {
            Spawn();
            nextTime = Time.time + Spawner;

            float Randomarea = Random.Range(-4.5f, 4.5f);
            transform.position = new Vector3(10, Randomarea, 0);
        }
        
    }
    void Spawn()
    {
       // Instantiate(rocketPrefabs, transform.position, transform.rotation);
       Instantiate(enemy[0], transform.position, transform.rotation);
    }
}


