using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrileSqure : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed;
    private float moveInput;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
    }

    private bool isGrounded;
    public Transform feetpos;
    public float checkRadius;
    public LayerMask whatIsGrounded;
    public float jumpforce;

    private void Update()
    {
        isGrounded=Physics2D.OverlapCircle(feetpos.position, checkRadius,whatIsGrounded);
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space));
        {
            rb2d.velocity = Vector2.up * jumpforce;
        }
    }


}
