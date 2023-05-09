using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : Item, ITransparency
{
    public float speed;
    public override void GetOpaque()
    {
        //객체가 가지고있던 원래 색깔을 변수에 넣고 다시 객체 색깔을 불러와서 거기에 투명도만 변경함 뭔말인지 모르겠다
        Color32 itemColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color32(itemColor.r, itemColor.g, itemColor.b, 60);
    }
    public override void DestroyAfterTime()
    {
        Invoke("GetOpaque", 5.0f);
        Invoke("DestroyObject", 10.0f);
    }
    public override void RunTime()
    {
        GameObject shipObject = GameObject.Find("Ship");
        ShipControl shipControl = shipObject.GetComponent<ShipControl>();

        shipControl.speed *= speed;
        DestroyObject();
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ship"))
            RunTime();
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

}
