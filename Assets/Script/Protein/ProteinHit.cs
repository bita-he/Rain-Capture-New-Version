using System;
using UnityEngine;

namespace Script.Protein
{
    public class ProteinHit : MonoBehaviour
    {
        

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                //Increase score +10
                Destroy(gameObject);
            }

            if (other.CompareTag("Ground"))
            {
                //Decrease score -5
                Destroy(gameObject);
            }
        }
    }
}
