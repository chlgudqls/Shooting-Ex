using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    int Health = 100000;

    public int health
    {
        get { return Health;}
    }

    void Start()
    {
        Debug.Log($"health : {Health}");
    }
    public void OnCollisionStay2D(Collision2D col)
    {
        //충돌되는 객체를 Tag로 분류해서 적용
        if (col.gameObject.CompareTag("Enemy"))
        { 
            TakeDamage(10);
            Debug.Log($"health : {Health}");
        }
    }
    

    void TakeDamage(int value)
    {
        Health -= value;
        if (Health <= 0)
            Die();
    }

    void TakeDamage(float ratio)
    {
        Health -= (int)(Health * ratio);
        if (Health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(this.gameObject, .5f);
    }

    void Update()
    {
        
    }
}
