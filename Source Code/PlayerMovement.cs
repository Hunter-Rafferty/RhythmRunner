using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public TrailRenderer trailRenderer;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public Animator animator;
    bool jump = false;
    public AudioClip swordSwipe;
    AudioSource audioData;
    bool slideState = false;
    public bool groundCheck;
    public Rigidbody2D playerRB;
    public float dashThrust;
    bool doubleDashCheck;
    bool slideEnter = false;
    public Transform player;
    bool dashCooldown = false;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        trailRenderer = GetComponent<TrailRenderer>();
    }

    void Update () {

        horizontalMove = runSpeed;

        if (Input.GetKey("s"))
        {
            animator.Play("Player_Slide");
            slideState = true;
        }
        else if (Input.GetKeyUp("s"))
        {
            animator.SetBool("Slide", false);
            slideState = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        

        if (Input.GetKeyDown("e") && slideState == false && dashCooldown == false)
        {
            animator.Play("Player_Dash");
            trailRenderer.widthMultiplier = 0.4f;
            playerRB.velocity = new Vector2(15, 0);
            Invoke("DelayedTraile", 0.5f);
            dashCooldown = true;
            Invoke("DashCooldown", 1f);

        }

    }

    private void DelayedTraile()
    {
        trailRenderer.widthMultiplier = 0.0f;
        animator.SetBool("Slide", false);
    }

    private void DashCooldown()
    {
        dashCooldown = false;
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
