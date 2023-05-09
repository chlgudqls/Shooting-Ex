using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    void Start()
    {
        
    }

    delegate void testEventHandler();

    class EventGiver
    {
        public static event testEventHandler TestEvent;

        public void RunEvent()
        {
            if(TestEvent != null)
            {
                TestEvent();
            }
        }
    }
    class EventCatchers
    {
        public EventCatchers()
        {
            EventGiver.TestEvent += EventHandler;
        }

        public void EventHandler()
        {
            Debug.Log("이벤트 발생!");
        }
    }
    void Update()
    {
        
    }
}
