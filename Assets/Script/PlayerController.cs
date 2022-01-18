using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;

    bool crouch;
    // private void Awake()
    // {
    //     Debug.Log("Player controller awake" );
    // }
    //   private void OnCollisionEnter2D(Collision2D collision){
    //     Debug.Log("Collision:" + collision.gameObject.name);
    //   }
    public void Update()
    {
        //PlayerFlip();
        //running
        float speed = Input.GetAxisRaw("Horizontal");//it desplay the the speed of a player = 1
        animator.SetFloat("speed", Mathf.Abs(speed));//in it real value

        Vector3 playerFlip = transform.localScale;//it is take the value from -x site it halp toward left site
        if (speed < 0) playerFlip.x = -1f * Mathf.Abs(playerFlip.x);
        else if (speed > 0) playerFlip.x = Mathf.Abs(playerFlip.x);

        transform.localScale = playerFlip;

        //jump
       //bool jump = Input.GetAxisRaw("Vertical");
        //Input.GetKeyDown(KeyCode.Space);
         Input.GetAxisRaw("Vertical");
        Input.GetKeyDown(KeyCode.Space);
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

}
