
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float Jump;
    public bool crouch;
    public bool isGrounded = true;
    private Rigidbody2D rb2d;
    public GameOver GameOver;
    public ScoreController ScoreController;
   
  



  
    public void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
       
        MoveCharacter(horizontal);
        PlayMovementAnimation(horizontal);
        PlayerJump(vertical);
        PlayerCrouch();
    }

   

    private void MoveCharacter(float horizontal)
    {
        //move the character in horizontaly

        Vector3 position = transform.position;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        transform.position = position;

        //move the character in vertical
        /* if (vertical > 0)
         {
             rb2d.AddForce(new Vector2(0f, Jump),ForceMode2D.Force);
         }
        */
    }

    private void PlayMovementAnimation(float horizontal)
    {
        //running
        //speed = Input.GetAxisRaw("Horizontal");//it desplay the the speed of a player = 1
        animator.SetFloat("speed", Mathf.Abs(horizontal)); //in it real value

        Vector3 Scale = transform.localScale;//it is take the value from -x site it halp toward left site
        //(distance/sec)*(sec/30)

        if (horizontal < 0) Scale.x = -1f * Mathf.Abs(Scale.x);
        else if (horizontal > 0) Scale.x = Mathf.Abs(Scale.x);

        transform.localScale = Scale;

    }
    //jump
    void PlayerJump(float vertical)
    {
        if (vertical > 0 && (isGrounded = true))
        {
            Vector3 position = transform.position;
            position.y = position.y + vertical * Jump * Time.deltaTime;
            transform.position = position;

            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }
    }
    //crouch
    bool PlayerCrouch()//it is for crouch
    {
        if (Input.GetKey(KeyCode.S))
        {
            crouch = true;
            animator.SetBool("Crouch", crouch);
            return true;
        }
        else
        {
            crouch = false;
            animator.SetBool("Crouch", crouch);
            return false;
        }
    }
    //key destroy
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("key"))
        {
            PickUpScore();
            Destroy(other.gameObject);
        }
    }
    public void PickUpScore()
    {
        ScoreController.IncreaseScore(10);
    }


}