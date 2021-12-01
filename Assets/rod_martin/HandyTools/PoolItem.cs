using UnityEngine;

namespace rod_martin.HandyTools
{
    public class PoolItem : MonoBehaviour
    {
        private IPoolAwake _poolAwake;
        public GameObject prefab;

        public void PoolItemAdd(GameObject o)
        {
            prefab = o;
            _poolAwake = o.GetComponent<IPoolAwake>();
            prefab.SetActive(false);
        }

        public void ReSpawnb(Vector3 _pos, Quaternion _rot)
        {
            prefab.SetActive(true);
            if (_poolAwake != null)
            {
                _poolAwake.PoolAwake(_pos, _rot);
            }
        }
    }
}