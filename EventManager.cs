using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    //�̺�Ʈ ��� enemy��ũ�������� �׾����� ȣ���Ҽ��ְ� gamanager�� �Լ��� �������� enemy���� ȣ������
    //static�̶� �ٸ�Ŭ�������� ��ü���� �ҷ��ü����� �׸��� ���� ������
    //�̺�ƮŰ����� �׷� static���θ� ����ϴ°���
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
