using UnityEngine;

namespace rod_martin
{
    public class AudioSingleton : GenericSingleton<AudioSingleton>
    {
        [SerializeField]private float _volume;
        public float Volume
        {
            get
            {
                return _volume;
                
            }
            set
            {
                _volume = value;
                Debug.Log($"volumne is {_volume}");
            }
        }
    }
}