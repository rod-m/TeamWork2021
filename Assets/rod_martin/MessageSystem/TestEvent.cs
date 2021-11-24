using System;
using UnityEngine;
using UnityEngine.Events;

namespace rod_martin.MessageSystem
{
    public class TestEvent : MonoBehaviour
    {
        private UnityAction someListener;

        public string MyEventName = "test1";
        void DoSomething()
        {
            Debug.Log($"DoSomething called on {this.gameObject.name}");
        }
        void DoSomethingElse()
        {
            Debug.Log($"Do DoSomethingElse called on {this.gameObject.name}");
        }
        private void Awake()
        {
            someListener = new UnityAction(DoSomething);
            someListener += DoSomethingElse;
        }
        private void OnEnable()
        {
            EventManager.Instance.StartListening(MyEventName, someListener);
        }
        private void OnDisable()
        {
            EventManager.Instance.StopListening(MyEventName, someListener);
        }
    }
}