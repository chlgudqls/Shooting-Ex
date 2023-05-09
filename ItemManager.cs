using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Coordinate[] Coordinates =
    {
        new Coordinate(0,0),
        new Coordinate(1,0),
        new Coordinate(-1,0),
        new Coordinate(1,1),
        new Coordinate(1,-1),
        new Coordinate(2,1),
        new Coordinate(-2,0),
    };
    //public GameObject[] ItemPrefabs;
    //랜덤 함수를 사용하기 위해서 배열수 지정 안하면 안되는건가
    public GameObject[] ItemPrefabs = new GameObject[3];
    void Start()
    {
        //SpawnItem(ItemPrefabs[0], new Vector2(1,0));
        //SpawnItem(ItemPrefabs[1], new Vector2(-1, 0));
        //ItemRandom();
    }

    public void ItemRandom()
    {
        GameObject ItemPrefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        Vector2 itemPosition = Coordinates[Random.Range(0, Coordinates.Length)].GetPosition();
        SpawnItem(ItemPrefab, itemPosition);
        Invoke("ItemRandom", 2.0f);
    }
    public void SpawnItem(GameObject itemPrefab, Vector2 _position)
    {
        GameObject item = Instantiate(itemPrefab);
        item.transform.position = _position;
    }

    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 GetPosition()
        {
            return new Vector2(x, y);
        }
    }


    void Update()
    {
        
    }
}
