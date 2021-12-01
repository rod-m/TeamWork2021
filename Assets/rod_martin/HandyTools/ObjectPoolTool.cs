using UnityEngine;
using System.Collections.Generic;


namespace rod_martin.HandyTools
{
    public class ObjectPoolTool : MonoBehaviour
    {
        public List<PoolInfo> poolList;
        private Dictionary<string, Queue<PoolItem>> poolDictionary;

        void Start()
        {
            poolDictionary = new Dictionary<string, Queue<PoolItem>>();
            foreach (var _pool in poolList)
            {
                Queue<PoolItem> objectPool = new Queue<PoolItem>();
                for (int i = 0; i < _pool.size; i++)
                {
                    GameObject obj = Instantiate(_pool.prefab);
                    obj.transform.parent = transform;
                    PoolItem poolItem = new PoolItem();
                    objectPool.Enqueue(poolItem);
                }
                poolDictionary.Add(_pool.tag, objectPool);
            }
        }

        public PoolItem SpawnFromPool(string _tag, Vector3 _pos, Quaternion _rot)
        {
            if (!poolDictionary.ContainsKey(_tag))
            {
                return null;
            }

            PoolItem _item = poolDictionary[_tag].Dequeue();
            _item.ReSpawnb(_pos, _rot);
            return _item;
        }
    }
}

