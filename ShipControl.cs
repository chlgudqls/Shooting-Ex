using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject BulletPrefab;
    public float BulletSpeed;
    void Start()
    {
        
    }  

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i =1; i < 3; i++) 
            {
                GameObject Bullet = Instantiate(BulletPrefab);
                //Vector3 BulletPosition = this.transform.position;
                //BulletPosition.y += 0.5f * i;
                //Bullet.transform.position = BulletPosition;
                Bullet.transform.position = this.transform.position;
                Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed * i);
            }
        }
    }
}
