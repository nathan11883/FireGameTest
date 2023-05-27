using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class MovePlayer : MonoBehaviour
    {
    
        public MovementJoystick movementJoystick;
        public bool locked = false;
        public float playerSpeed;
        private Rigidbody2D rb;
        Animator animator;
        SpriteRenderer spriteRenderer;
    
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    
        // Update is called once per frame
        void FixedUpdate()
        {
            if (!locked){
                if(movementJoystick.joystickVec.y != 0)
                {
                    rb.velocity = new Vector2(movementJoystick.joystickVec.x * playerSpeed, movementJoystick.joystickVec.y * playerSpeed);
                    
                    animator.SetBool("Moving_right",true);
                    // Set direction 
                    if (rb.velocity[0] < 0){
                        spriteRenderer.flipX=true;
                    }
                    else if(rb.velocity[0] > 0){
                        spriteRenderer.flipX=false;
                    }
                }
                else
                {
                    rb.velocity = Vector2.zero;
                    animator.SetBool("Moving_right",false);
                }
                //print("Moving_right "+animator.GetBool("Moving_right"));
                //print("velocity "+rb.velocity);
                //print("joystickVec.y "+movementJoystick.joystickVec.y);
        }
        }
    }