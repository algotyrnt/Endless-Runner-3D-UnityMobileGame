using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController Controller;
    Animator anim;
    public Joystick joystick;
    private float yVelocity = 0.0f;
    private float xVelocity = 0.0f;
    private float zVelocity = 0.0f;
    CountDown countdown;
    public GameObject manager;

    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float speedUp = 5.0f;
    [SerializeField] private float jumpHight = 10.0f;
    [SerializeField] private float jumpSpeed = 10.0f;
    [SerializeField] private float gravity = 1.0f;
    [SerializeField] private float turn = 1.0f;

    private void Start()
    {
        Controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
            Vector3 velocity = new Vector3(0f, 0f, 0f);

            zVelocity = speed;

            if (Controller.isGrounded == true)
            {
                if (joystick.Vertical >= 0.5f)
                {
                    yVelocity = jumpHight;
                    anim.SetTrigger("Jump");
                }
            }
            else
            {
                zVelocity = jumpSpeed;
                yVelocity -= gravity * Time.deltaTime;
                anim.ResetTrigger("Jump");
            }

            if (joystick.Horizontal <= -.2f)
            {
                xVelocity = -turn;
            }
            else if (joystick.Horizontal >= .2f)
            {
                xVelocity = turn;
            }
            else if (joystick.Horizontal == 0)
            {
                xVelocity = 0f;
            }


            velocity.z = zVelocity;
            velocity.x = xVelocity;
            velocity.y = yVelocity;

            Controller.Move(velocity * Time.deltaTime);
            anim.SetFloat("Speed", speed);
        
    }
    public void speedup()
    {
        speed += speedUp;
        jumpSpeed += speedUp;
    }
}

