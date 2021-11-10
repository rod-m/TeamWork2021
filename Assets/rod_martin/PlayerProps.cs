using UnityEngine;

namespace rod_martin
{
    [CreateAssetMenu(fileName = "PlayerProperties", menuName = "Add Player Prop", order = 0)]
    public class PlayerProps : ScriptableObject
    {
        public float speed = 10f;
    }
}