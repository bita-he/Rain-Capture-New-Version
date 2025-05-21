using System;
using UnityEngine;

namespace Assets.Script.Animation
{
    public class AnimTutorial : MonoBehaviour
    {
        public Animator animator;

        private void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                animator.SetInteger("Move", 1);
            }
            else
            {
                animator.SetInteger("Move", 0);
            }
        }
    }
}