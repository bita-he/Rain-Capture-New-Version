using UnityEngine;

namespace Script.Player
{
    public class PlayerController : MonoBehaviour
    {
        public Rigidbody2D rb;

        // speed
        public float speed;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //init speed
            speed = 15.0f;
        }
        
        private void FixedUpdate()
        {
            Movement();
        }
        //movement method
        public void Movement()
        {
            //get Axis control
            var xAxis = Input.GetAxis("Horizontal");
            //force
            var force = new Vector2(xAxis * (speed * Time.deltaTime), 0);
            
            //Add force
            rb.AddForce(force, ForceMode2D.Impulse);
        }
    }
}
