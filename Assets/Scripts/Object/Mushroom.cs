using UnityEngine;

namespace ForestView.Object.Mushroom
{
    public class Mushroom : MonoBehaviour
    {
        public float upForce = 1f;
        public float sideForce = .1f;
        [SerializeField] private float _duration = 3f;
        private float _timer = 0f;

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= _duration)
            {
                gameObject.SetActive(false);
                _timer = 0f;
            }
        }

        public void Spawn()
        {
            float xForce = Random.Range(-sideForce, sideForce);
            float yForce = Random.Range(upForce / 2f, upForce);
            float zForce = Random.Range(-sideForce, sideForce);

            Vector3 force = new Vector3(xForce, yForce, zForce);

            GetComponent<Rigidbody>().velocity = force;

            _timer = 0f;

            gameObject.SetActive(true);
        }
    }
}
