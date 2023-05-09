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
        Debug.Log("델리게이트 샘플");
    }

    void Number(int num)
    {
        Debug.Log($"숫자 : {num}");
    }

    void DoubleNumber(int num)
    {
        Debug.Log($"숫자 : {num * 2}");
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
            Debug.Log("사랑해");
        }
    }
    //위와 같이 델리게이트의 콜백 기능을 이용하면 호출 받은 쪽에서 호출한 쪽에 있는 메서드를 호출할 수 있는 장점이 있다.
    //내용이 길어져서 콜백 기능을 좀 더 업그레이드한 Event(이벤트) 가 있다
    class Wife
    {
        //public void GetGift(Husband husband)
        //인자값으로 메서드를 받고있으니 호출한쪽의 메서드를 받아서 호출하는거임
        public void GetGift(GetGiftDelegate toWife)
        {
            Debug.Log("고마워");
            //husband.TakeGift();
            toWife();
        }
    }
}