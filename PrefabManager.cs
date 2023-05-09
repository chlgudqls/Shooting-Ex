using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    //public GameObject Enemy1Prefab;
    //public GameObject Enemy2Prefab;
    public GameObject[] EnemyPrefabs;
    public List<Coordinate> Coordinates = new List<Coordinate>
        {
            new Coordinate(3,1),
            new Coordinate(3,-1),
            new Coordinate(3,3),
            new Coordinate(3,-3),
            new Coordinate(-3,1),
            new Coordinate(-3,-1),
            new Coordinate(-3,3),
            new Coordinate(-3,-3)
        };
    void Start()
    {
        EventManager.EnemyDiesEvent += EnemyDies;
        //EnemyRandom();
        //SpawnEnemy(Enemy1Prefab, new Vector3(-3, 3, 0));
        //SpawnEnemy(Enemy2Prefab, new Vector3(3, 3, 0));
    }

    public IEnumerator EnemyRandom()
    {
        //while(true)니까 무한루프임 다른 조건이없으니까 그래서 코루틴이랑 같이써서 invoke와 같은 기능을함
        while(true)
        {
            SpawnEnemy(EnemyPrefabs[Random.Range(0, 2)], 
                 Coordinates[Random.Range(0, Coordinates.Count)].GetPosition());
            yield return new WaitForSeconds(5.0f);
            Debug.Log("적속도---------------234");
            //Invoke("EnemyRandom", 2.5f);
        }
    }

    
    public void SpawnEnemy(GameObject prefab, Vector3 _position)
    {
        GameObject enemy = Instantiate(prefab);
        enemy.transform.position = _position;
        enemy.GetComponent<Enemy>().Move();
        Debug.Log("적속도---------------12");
    }

    public void EnemyDies()
    {
        Coordinate coordinate = new Coordinate(Random.Range(-3, -5), Random.Range(3, -5));
        Coordinates.Add(coordinate);
    }    

    void Update()
    {
        
    }
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