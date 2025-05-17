using UnityEngine;

    public class Movementplayer : MonoBehaviour
    {
        public Rigidbody2D rb;

        // speed
        public float speed;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //init speed
            speed = 10.0f;
        }
        
        private void FixedUpdate()
        {
            Movement();
        }
        //movement method
        private void Movement()
        {
            //get Axis conterol
            var xAxis = Input.GetAxis("Horizontal");
            //force
            var force = new Vector2(xAxis * (speed * Time.deltaTime), 0);
            
            //Add force
            rb.AddForce(force, ForceMode2D.Impulse);
        }
        
        
    }
