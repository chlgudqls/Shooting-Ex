using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy
{
    void Start()
    {
        
    }

    public override void Move()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * enemySpeed);
        Debug.Log("���ӵ�---------------");
    }
    void Update()
    {
        
    }
}
