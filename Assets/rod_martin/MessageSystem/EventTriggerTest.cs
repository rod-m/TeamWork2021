using System;
using UnityEngine;

namespace rod_martin.MessageSystem
{
    public class EventTriggerTest : MonoBehaviour
    {
        public string MyEventName = "test1";
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log($"EventTriggerTest {gameObject.name} {MyEventName}");
                EventManager.Instance.TriggerEvent(MyEventName);
            }
        }
    }
}