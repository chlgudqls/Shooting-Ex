using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int Health = 11;
    public float enemySpeed;

    public int health
    {
        get { return Health; }
    }
    void Start()
    {
        Debug.Log($"health : {Health}");
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Bullet"))
        { 
            //순차적으로 실행되기때문에 데미지를 받고나서 col객체는 충돌되는 즉시 사라진다
            TakeDamage(10);
            Debug.Log($"health : {Health}");
            //col.gameObject.SetActive(false);
            Destroy(col.gameObject);
        }
    }

    void TakeDamage(int value)
    {
        Health -= value;
        if (Health <= 0)
            Die();
    }
    public void Die()
    {
        EventManager.RunEnemyDiesEvent();
        Destroy(this.gameObject, 0.5f);
    }

    public virtual void Move()
    {

    }
    void Update()
    {
        
    }
}
