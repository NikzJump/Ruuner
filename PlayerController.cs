using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    float speedPlus;
    public float jumpForce;
    private int extraJump;

    private int extraJumps;
    public int extraJumpsValue;

    public Rigidbody2D rb;
    public Collider2D myCollider;
    public LayerMask whatIsGround;

    private bool isGrounded;

    private void Start()
    {
        extraJumps = extraJumpsValue;
        speedPlus = 0.001f;
        rb = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        rb.velocity = new Vector2(Speed, rb.velocity.y);

        if (isGrounded)
        {
            extraJump = extraJumpsValue;
        }
            

        if (Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            extraJump--;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

    }

    private void FixedUpdate()
    {
        Speed += speedPlus;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Death")
        {
            SceneManager.LoadScene(0);
        }
    }

}
