using UnityEngine;

namespace Script.Protein
{
    public class ProteinHit : MonoBehaviour
    {
        private ScoreManager scoreManager;

        private void Start()
        {
            scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager == null)
            {
                Debug.LogError("ScoreManager not found in the scene.");
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                scoreManager?.AddScore(10); // Increase score by 10
                Destroy(gameObject);
            }

            if (other.CompareTag("Ground"))
            {
                scoreManager?.AddScore(-5); // Decrease score by 5
                Destroy(gameObject);
            }
        }
    }
}