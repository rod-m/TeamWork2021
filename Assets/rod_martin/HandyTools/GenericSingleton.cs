using UnityEngine;

namespace rod_martin.HandyTools
{
    public class GenericSingleton<T> : MonoBehaviour where T:Component
    {
        private static T _Instance = null;

        public static T Instance
        {
            get
            {

                if (_Instance == null)
                {
                    _Instance = FindObjectOfType<T>();
                    if (_Instance == null)
                    {
                        // create singleton game object
                        GameObject go = new GameObject();
                        _Instance = go.AddComponent<T>();

                        DontDestroyOnLoad(go);
                    }

                }

                return _Instance;
            }

        }
        
        public virtual void Awake()

        {

            if (_Instance == null)

            {

                _Instance = this as T;

                DontDestroyOnLoad(this.gameObject);

            }

            else

            {

                Destroy(gameObject);

            }

        }
    }
    
}