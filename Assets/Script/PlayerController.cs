using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    float speed;
    // private void Awake()
    // {
    //     Debug.Log("Player controller awake" );
    // }

    //   private void OnCollisionEnter2D(Collision2D collision){
      //   Debug.Log("Collision:" + collision.gameObject.name);
       //}
    public void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");


        MoveCharacter(horizontal);
        PlayMovementAnimation(horizontal, vertical); 
    }

    private void MoveCharacter(float horizontal)
    {
        Vector3 position  = transform.position;
        position.x = position.x+horizontal * speed * Time.deltaTime; 
        transform.position=position;
    }

    private void PlayMovementAnimation(float horizontal, float vertical)
    {
        //running
       speed = Input.GetAxisRaw("Horizontal");//it desplay the the speed of a player = 1
        animator.SetFloat("speed", Mathf.Abs(speed));//in it real value

        Vector3 Scale = transform.localScale;//it is take the value from -x site it halp toward left site
        //(distance/sec)*(sec/30)
        if (speed < 0) Scale.x = -1f * Mathf.Abs(Scale.x);
        else if (speed > 0) Scale.x = Mathf.Abs(Scale.x);

        transform.localScale = Scale;


        //jump
        
        if(vertical>0)
        {
            animator.SetBool("Jump", true);
        }
        else
        {
            animator.SetBool("Jump", false);
        }

    }

}




/*
    void PlayerFlip()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(speed));
        Vector3 playerFlip = transform.localScale; 
        if (speed < 0) playerFlip.x = -1f * Mathf.Abs(playerFlip.x);
        else if (speed > 0) playerFlip.x = Mathf.Abs(playerFlip.x);
        transform.localScale = playerFlip;

        bool Jump = Input.GetButtonDown("jump");
        animator.SetBool("Jump", Jump);

        bool crouch = Input.GetKeyDown(KeyCode.LeftControl);
        animator.SetBool("crouch", crouch);
    }

    */