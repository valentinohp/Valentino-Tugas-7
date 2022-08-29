using UnityEngine;
using ForestView.Object.Mushroom;

namespace ForestView.Spawner
{
    public class MushroomSpawner : MonoBehaviour
    {
        public GameObject objPrefab;
        public int poolSize = 200;
        private Mushroom[] _objPool;
        private int _objPoolIndex = 0;

        private void Start()
        {
            _objPool = new Mushroom[poolSize];

            for (int i = 0; i < poolSize; i++)
            {
                GameObject obj = Instantiate(objPrefab, transform.position, Quaternion.identity);
                obj.SetActive(false);
                _objPool[i] = obj.GetComponent<Mushroom>();
            }
        }

        private void FixedUpdate()
        {
            if (_objPoolIndex >= _objPool.Length)
            {
                _objPoolIndex = 0;
            }

            Mushroom obj = _objPool[_objPoolIndex];
            obj.Spawn();
            obj.transform.position = transform.position;
            _objPoolIndex++;
        }
    }
}
