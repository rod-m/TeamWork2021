using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;
using rod_martin.HandyTools;

namespace rod_martin.MessageSystem
{
    public sealed class EventManager : GenericSingleton<EventManager>
    {
        // properties: eventDictionary, Instance
        private Dictionary<string, UnityEvent> eventDictionary = new Dictionary<string, UnityEvent>();
// Awake
public void Awake()
{
    base.Awake();
    
}
// Start Listening
        public void StartListening(string eventName, UnityAction listener)
        {
            Debug.Log($"StartListening {eventName}");
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.AddListener(listener);
            }
            else
            {
                thisEvent = new UnityEvent();
                thisEvent.AddListener(listener);
                Instance.eventDictionary.Add(eventName, thisEvent);
            }
        }
// Stop Listening
        public void StopListening(string eventName, UnityAction listener)
        {
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.RemoveListener(listener);
            }
        }
// Trigger Event
        public void TriggerEvent(string eventName)
        {
            Debug.Log($"TriggerEvent {eventName}");
            UnityEvent thisEvent = null;
            if (Instance.eventDictionary.TryGetValue(eventName, out thisEvent))
            {
                thisEvent.Invoke();
            }

        }
    }
}