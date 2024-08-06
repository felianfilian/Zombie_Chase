using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 10f;
    [SerializeField]
    private float jumpForce = 30f;

    private float moveX;
    private bool isGrounded = true;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator anim;

    private string ANIMATION_WALK = "walk";
    private string TAG_GROUND = "Ground";

     void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        Jump();
        Animate();
        
    }


    void PlayerMove()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveX, 0f,0f) * moveSpeed * Time.deltaTime;
    }

    void Animate()
    {
        // move
        if (moveX > 0)
        {
            anim.SetBool(ANIMATION_WALK, true);
        } else if(moveX < 0)
        {
            anim.SetBool(ANIMATION_WALK, true);
        } else
        {
            anim.SetBool(ANIMATION_WALK, false);
        }
        
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);           
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(TAG_GROUND))
        {
            isGrounded = true;
        }
    }
}
