using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item, ITransparency
{
    public override void GetOpaque()
    {
        Color32 itemColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(itemColor.r, itemColor.g, itemColor.b, 50);
    }
    public override void DestroyAfterTime()
    {
        Invoke("GetOpaque", 5.0f);
        Invoke("DestroyObect", 10.0f);
    }
    public override void RunTime()
    {
        GameObject shipObject = GameObject.Find("Ship");
        ShipControl shipControl = shipObject.GetComponent<ShipControl>();
        DestroyObect();

    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ship"))
            RunTime();
    }
    public void DestroyObect()
    {
        Destroy(gameObject);
    }



}
