using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void DestroyAfterTime();
    public abstract void RunTime();
    public abstract void GetOpaque();
    void Start()
    {
        DestroyAfterTime();
        //왜 스타트에 넣어야되는거지
        //GameObject CoinPrefab = ItemPrefabs[(int)Items.Coin];
        //GameObject SpeedUpPrefab = ItemPrefabs[(int)Items.SpeedUp];
        //GameObject PowerUpPrefab = ItemPrefabs[(int)Items.PowerUp];
        GameObject CoinPrefab = GetItem(Items.Coin);
        GameObject SpeedUpPrefab = GetItem(Items.SpeedUp);
        GameObject PowerUpPrefab = GetItem(Items.PowerUp);
    }

    GameObject GetItem(Items item)
    {
        return ItemPrefabs[(int)item];
    }
    public enum Items
    {
        Coin,
        SpeedUp,
        PowerUp,
    }
    public GameObject[] ItemPrefabs = new GameObject[3];

    void Update()
    {
        
    }
}
    public interface ITransparency
    {
    }

       