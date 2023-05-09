using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    //이벤트 기버 enemy스크립스에서 죽었을때 호출할수있게 gamanager의 함수를 저장한후 enemy에서 호출했음
    //static이라서 다른클레스에서 객체없이 불러올수있음 그리고 값도 고정됨
    //이벤트키워드는 그럼 static으로만 사용하는건지
    public static event Action EnemyDiesEvent;

    public static void RunEnemyDiesEvent()
    {
        if(EnemyDiesEvent != null)
        {
            EnemyDiesEvent();
        }
    }

    void Start()
    {
        
    }



    void Update()
    {
        
    }
}
