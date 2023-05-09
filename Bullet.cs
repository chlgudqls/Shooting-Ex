using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroyBullet", 2.10f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }


    void Update()
    {
        
    }
}
