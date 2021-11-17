using UnityEngine;

namespace rod_martin
{
    [CreateAssetMenu(fileName = "PlayerPropertiesRod", menuName = "Add Player Prop Rod", order = 0)]
    public class PlayerProps : ScriptableObject
    {
        public float speed = 9f;
    }
}