using UnityEngine;

namespace rod_martin
{
    [CreateAssetMenu(fileName = "simple_sound", menuName = "Add simple sound", order = 0)]
    public class SimpleSounds : AudioEventBase
    {
        public override void Play(AudioSource _source)
        {
            if (clips.Length == 0) return;
            _source.clip = clips[Random.Range(0, clips.Length)];
            _source.volume = Random.Range(0, 1);
            _source.pitch = Random.Range(0, 1);

        }
    }
}