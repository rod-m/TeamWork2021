using UnityEngine;

namespace rod_martin
{
    public class SingletonGameManager : MonoBehaviour
    {
        private static SingletonGameManager _Instance = null;

        public static SingletonGameManager Instance
        {
            get
            {

                if (_Instance == null)
                {
                    _Instance = FindObjectOfType<SingletonGameManager>();
                    if (_Instance == null)
                    {
                        // create singleton game object
                        GameObject go = new GameObject();
                        _Instance = go.AddComponent<SingletonGameManager>();

                        DontDestroyOnLoad(go);
                    }

                }

                return _Instance;
            }

        }
        [SerializeField]
        private int _Score = 0;
        
        public int Score 
        
        { 
            get 
            
            {   
                return _Score;
                
            }   
            set   
            {   
                // update UI
                Debug.Log($"Score is {_Score}");
                _Score = value;
            }
        }
        

    }
}