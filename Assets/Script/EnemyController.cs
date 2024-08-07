using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private Rigidbody2D rb;

    public bool walkRight;
    public float speed = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (walkRight)
        {
            transform.localScale = Vector3.one;
        } else
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (walkRight)
        {
            rb.velocity = new Vector3(speed,0f,0f);
            
        } else
        {
            rb.velocity = new Vector3(-speed, 0f, 0f);
        }
    }
}
