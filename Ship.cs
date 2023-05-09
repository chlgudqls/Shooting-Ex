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
        //�浹�Ǵ� ��ü�� Tag�� �з��ؼ� ����
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
