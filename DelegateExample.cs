using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void TestDelegate();
    delegate void TestDelegate2(int number);
    TestDelegate2 testDelegate;

    delegate void GetGiftDelegate();

    void Start()
    {
        TestDelegate test = new TestDelegate(sample);
        TestDelegate guest = sample;

        testDelegate = Number;

        testDelegate += DoubleNumber;

        testDelegate(5);

        test();
        guest();

        Husband husband = new Husband();
        Wife wife = new Wife();

        husband.GiveGift(wife);
    }
    void sample()
    {
        Debug.Log("��������Ʈ ����");
    }

    void Number(int num)
    {
        Debug.Log($"���� : {num}");
    }

    void DoubleNumber(int num)
    {
        Debug.Log($"���� : {num * 2}");
    }


    void Update()
    {
        
    }
    class Husband
    {
        public void GiveGift(Wife wife)
        {
            //wife.GetGift(this);
            GetGiftDelegate toWife = TakeGift;
            wife.GetGift(toWife);
        }
        public void TakeGift()
        {
            Debug.Log("�����");
        }
    }
    //���� ���� ��������Ʈ�� �ݹ� ����� �̿��ϸ� ȣ�� ���� �ʿ��� ȣ���� �ʿ� �ִ� �޼��带 ȣ���� �� �ִ� ������ �ִ�.
    //������ ������� �ݹ� ����� �� �� ���׷��̵��� Event(�̺�Ʈ) �� �ִ�
    class Wife
    {
        //public void GetGift(Husband husband)
        //���ڰ����� �޼��带 �ް������� ȣ�������� �޼��带 �޾Ƽ� ȣ���ϴ°���
        public void GetGift(GetGiftDelegate toWife)
        {
            Debug.Log("����");
            //husband.TakeGift();
            toWife();
        }
    }
}