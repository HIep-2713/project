using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public LayerMask groundLayer;
    public float maxJumpHeight = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (IsGrounded())
        {
            Jump();
        }
    }

    bool IsGrounded()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.75f, groundLayer);
        return hit.collider != null;
    }

    void Jump()
    {
        if (transform.position.y < maxJumpHeight)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}