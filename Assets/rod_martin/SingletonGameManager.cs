using UnityEngine;

namespace rod_martin
{
    public class SingletonGameManager : MonoBehaviour
    {
        public static SingletonGameManager Instance;
        private void Awake() {
            if (Instance != null) {
                Destroy(gameObject);
            }else{
                Instance = this;
            }
        }

    }
}