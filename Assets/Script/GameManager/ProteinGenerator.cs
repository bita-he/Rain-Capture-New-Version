using Script.Player;
using UnityEngine;

namespace Script.GameManager
{
    public class ProteinGenerator : MonoBehaviour
    {
        public GameObject proteinPrefab;
        private float _minX = -6.3f;
        private float _maxX = 6.3f;
        
        void Start()
        {
            InvokeRepeating(nameof(GenerateProtein),1, 2);
        }

        void Update()
        {
        
        }

        public void GenerateProtein()
        {
            float xRandomPos = Random.Range(_minX, _maxX);
            var spawnPos = new Vector2(xRandomPos, transform.position.y);

            Instantiate(proteinPrefab, spawnPos, Quaternion.identity);
        }
    }
}
