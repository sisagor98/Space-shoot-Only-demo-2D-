using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speeds = 5f;

    public GameObject bullet;
    private void Start()
    {
        //transform.position = new Vector3(0, 0, 0);
    }


    private void Update()
    {
        PlayerMove();
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetMouseButtonDown(0)))
        {
            Shoot();
        }
    }

    void PlayerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speeds * moveX * Time.deltaTime);
        transform.Translate(Vector3.up * speeds * moveY * Time.deltaTime);


        if (transform.position.y >4.2f)
        {
            transform.position = new Vector3(transform.position.x,4.2f, 0);
        }
        else if (transform.position.y < -6.5f)
        {
            transform.position = new Vector3(transform.position.x,-4.2f, 0);
        }

    }

    void Shoot()
    {
        Instantiate(bullet, transform.position +new Vector3(0.7f, 0, 0), Quaternion.identity);
    }

}
