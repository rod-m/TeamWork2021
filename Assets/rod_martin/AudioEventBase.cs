using UnityEngine;

namespace rod_martin
{
   
    public abstract class  AudioEventBase : ScriptableObject
    {
        public AudioClip[] clips;
        public abstract void Play(AudioSource _source);
    }
}