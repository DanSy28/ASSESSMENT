using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Movement
{
    [RequireComponent(typeof(CharacterController))]//object get Charecter controler conponent

    public class Movement : MonoBehaviour
    {
        [Header("Movement")]
        public Vector3 moveDir = Vector3.zero; //put it in zero dirction
        public CharacterController charC; //name charecter controler charC
        public GameObject cam;
        [Header("Speed")] //variables
        public float speed = 8f;// movement speed
        public float jumpSpeed = 6;// speed of the jumpSpeed 
        public float run = 16;// speed of the run
        public float crouch = 4; //speed of the crouch
        public float walk = 8;//speed of the walk
        [Header("Gravity")]
        public float gravity = 20f;
        // Use this for initialization
        void Start()
        {
            charC = this.GetComponent<CharacterController>(); //this allows us to get character controler
        }

        // Update is called once per frame
        void Update()
        {
            if (charC.isGrounded) // if charecter is on the ground
            {
                if (Input.GetKey(KeyCode.LeftShift))// this allow us to press leftShift
                {
                    speed = run;// this do speed of the run key 
                }
                else if (Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.LeftShift))// allow use to crouch and once finish run it will go back to normal speed 
                {
                    speed = crouch;// the crouch speed 
                }
                else
                {
                    speed = walk;// wall speed 
                }

                moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));// move direction
                moveDir = transform.TransformDirection(moveDir);// change  moveDir
                moveDir *= speed;// how fast change Dir
                if (Input.GetButton("Jump")) // jump key
                {
                    moveDir.y = jumpSpeed;// jumpspeed
                }

            }
            moveDir.y -= gravity * Time.deltaTime; // it is dir of gravity speed on seconed

            charC.Move(moveDir * Time.deltaTime);// speed of moveDir
        }

    }
}
